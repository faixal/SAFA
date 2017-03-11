using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using DataAccess;
using Shared.Mappers;
using Shared.Models;
using StaffAttendanceFixApp.Utilities;

namespace StaffAttendanceFixApp.Api
{
    public class StaffAttendanceApiController : ApiController
    {
        private readonly StaffAttendanceEntities _db;

        public StaffAttendanceApiController()
        {
            _db = new StaffAttendanceEntities();
        }

        public IEnumerable<StaffAttendanceModel> Get(int teacherId, int campusId, DateTime startDate, DateTime endDate)
        {
            try
            {
                startDate = startDate.Date;
                endDate = endDate.Date;
                var allAttendances =
                    _db.ATT_Staff_Attendance
                        .Where(
                            x =>
                                ((teacherId > 0 && x.TeacherId == teacherId) || teacherId == 0) &&
                                ((teacherId == 0 && x.CampusId == campusId) || teacherId != 0) &&
                                DbFunctions.TruncateTime(x.RecCreatedDt) >= startDate &&
                                DbFunctions.TruncateTime(x.RecCreatedDt) <= endDate).ToList();

                var mappedAttendances = allAttendances.Select(x => x.MapToModel()).OrderBy(x=>x.TeacherName).ThenBy(x=>x.StaffAttendanceId).ToList();

                return mappedAttendances;
            }

            catch (Exception ex)
            {
                LogUtility.WriteLog("StaffAttendanceApiController", ex.Message, "ATT_FIX_LOGS");
                return null;
            }            
        }

        private Att_Staff_Leaves GetStaffLeave(StaffAttendanceModel model)
        {
            var attDate = model.AttendanceDate?.Date;
            if (attDate == null) return null;
            var leaves = _db.Att_Staff_Leaves.Where(
                x =>
                    !x.isDeleted && x.TeacherId == model.TeacherId && attDate >= DbFunctions.TruncateTime(x.StartDate) &&
                    attDate <= DbFunctions.TruncateTime(x.EndDate)).ToList();

            if (!leaves.Any()) return null;

            if (model.ReasonId.HasValue && model.ReasonId > 0)
            {
                var dayId = model.ReasonId == 18 ? 2 : model.ReasonId == 19 ? 3 : 1;
                return leaves.FirstOrDefault(x => x.DayOptionId == dayId);
            }

            return leaves.FirstOrDefault();

        }

        private TR_StaffSchedule GetStaffSchedule(StaffAttendanceModel model)
        {
            var dayId = model.AttendanceDate != null ? (int) model.AttendanceDate.Value.DayOfWeek : 6;
            TR_StaffSchedule schedule = _db.TR_StaffSchedule.FirstOrDefault(
                x => x.TeacherId == model.TeacherId && x.CampusId == model.CampusId && (x.DayId == 6 || x.DayId == dayId));
            if (schedule == null)
            {
                schedule = new TR_StaffSchedule {StartTime = new TimeSpan(8, 30, 0), FinishTime = new TimeSpan(16, 30, 0) };
            }

            return schedule;
        }

        private TimeSpan[] GetStartFinishTimes(int dayId, StaffAttendanceModel model)
        {
            var schedule = GetStaffSchedule(model);
            TimeSpan[] timeSpans = new TimeSpan[2];
            switch (dayId)
            {
                case 1:
                    timeSpans[0] = schedule.StartTime?? new TimeSpan();
                    timeSpans[1] = schedule.FinishTime ?? new TimeSpan();
                    break;
                case 2:
                    timeSpans[0] = schedule.StartTime ?? new TimeSpan();
                    timeSpans[1] = schedule.StartTime?.Add(new TimeSpan(0, 4, 0, -1)) ?? new TimeSpan();
                    break;
                case 3:                    
                    timeSpans[0] = schedule.FinishTime?.Add(new TimeSpan(0, -4, 0, 0)) ?? new TimeSpan();
                    timeSpans[1] = schedule.FinishTime ?? new TimeSpan();
                    break;
            }

            return timeSpans;
        }
        private Att_Staff_Leaves AddStaffLeaveRecord(StaffAttendanceModel model)
        {
            var dayId = model.ReasonId == 18 ? 2 : model.ReasonId == 19 ? 3 : 1;
            var attDate = model.AttendanceDate ?? DateTime.Now;
            TimeSpan[] schedule = GetStartFinishTimes(dayId, model);
            Att_Staff_Leaves leave = new Att_Staff_Leaves
            {
                StartDate = attDate.Date + schedule[0],
                EndDate = attDate.Date + schedule[1],
                StatusId = 1,
                DayOptionId = dayId,
                IsArchieved = false,
                LeaveTypeId = 8,
                TeacherId = model.TeacherId,
                RecCreatedDt = DateTime.Now,
                RecLastUpdatedDt = DateTime.Now,
                RecCreatedBy = 0,
                RecUpdatedBy = 0,
                isDeleted = false,
                Attachment = null
            };

            _db.Att_Staff_Leaves.Add(leave);
            _db.SaveChanges();

            return leave;
        }

        public bool? Post(StaffAttendanceModel model)
        {
            try
            {
                if (model.StaffAttendanceId == 0)
                { 
                    // NEW RECORD INSERTION
                    ATT_Staff_Attendance attendance = new ATT_Staff_Attendance
                    {
                        //RecCreatedDt = DateTime.Now,
                        RecCreatedBy = "FixApp",
                        RecLastUpdateDate = DateTime.Now,
                        RecLastUpdatedBy = "FixApp",
                        TeacherId = model.TeacherId,
                        CampusId = model.CampusId,
                        AttendanceStatusId = model.AttendanceStatusId,
                        ReasonId = model.ReasonId,
                        //AttendanceDate = model.AttendanceDate?.Date + DateTime.Now.TimeOfDay
                    };

                    if (model.AttendanceStatusId == null || model.AttendanceStatusId == 6)
                    {
                        var date = Convert.ToDateTime(model.CheckInDate);
                        var time = Convert.ToDateTime(model.CheckInTime).TimeOfDay;
                        DateTime result = date + time;
                        attendance.CheckInDateTime = result;

                        attendance.RecCreatedDt = result;
                        attendance.AttendanceDate = result;

                        if (!string.IsNullOrEmpty(model.CheckOutDate))
                        {
                            date = Convert.ToDateTime(model.CheckOutDate);
                            time = Convert.ToDateTime(model.CheckOutTime).TimeOfDay;
                            result = date + time;
                            attendance.CheckOutDateTime = result;
                        }
                        else
                        {
                            attendance.CheckOutDateTime = null;
                        }
                        
                    }
                    else if(model.AttendanceStatusId == 1)
                    {
                        Att_Staff_Leaves staffLeave = GetStaffLeave(model);
                        if (staffLeave == null) staffLeave = AddStaffLeaveRecord(model);
                        attendance.LeaveId = staffLeave.LeaveId;

                        attendance.RecCreatedDt = model.AttendanceDate?.Date + DateTime.Now.TimeOfDay ?? DateTime.Now;
                        attendance.AttendanceDate = model.AttendanceDate?.Date + DateTime.Now.TimeOfDay;
                    }

                    _db.ATT_Staff_Attendance.Add(attendance);
                    _db.SaveChanges();
                }
                else
                {
                    // EDIT RECORD
                    ATT_Staff_Attendance attendance = _db.ATT_Staff_Attendance.Find(model.StaffAttendanceId);
                    if (attendance == null) return false;

                    if (model.AttendanceStatusId == null || model.AttendanceStatusId == 6)
                    {
                        var date = Convert.ToDateTime(model.CheckInDate);
                        var time = Convert.ToDateTime(model.CheckInTime).TimeOfDay;
                        DateTime result = date + time;
                        attendance.CheckInDateTime = result;

                        if (!string.IsNullOrEmpty(model.CheckOutDate))
                        {
                            date = Convert.ToDateTime(model.CheckOutDate);
                            time = Convert.ToDateTime(model.CheckOutTime).TimeOfDay;
                            result = date + time;
                            attendance.CheckOutDateTime = result;
                        }
                        else
                        {
                            attendance.CheckOutDateTime = null;
                        }

                        if (attendance.LeaveId > 0)
                        {
                            attendance.LeaveId = null;
                            var leave = _db.Att_Staff_Leaves.Find(attendance.LeaveId);
                            if (leave != null)
                            {
                                leave.isDeleted = true;
                                _db.SaveChanges();
                            }
                        }                                            
                    }
                    else if(model.AttendanceStatusId == 1)
                    {
                        attendance.CheckInDateTime = null;
                        attendance.CheckOutDateTime = null;

                        if (attendance.ReasonId != model.ReasonId && (model.ReasonId == null || model.ReasonId == 18 || model.ReasonId == 19))
                        {
                            if (attendance.LeaveId > 0)
                            {
                                Att_Staff_Leaves leave = GetStaffLeave(model);
                                if (leave != null)
                                {
                                    leave.isDeleted = true;
                                    _db.SaveChanges();
                                }                                
                            }
                            Att_Staff_Leaves newLeaveRec = AddStaffLeaveRecord(model);
                            attendance.LeaveId = newLeaveRec.LeaveId;
                        }
                    }

                    attendance.AttendanceStatusId = model.AttendanceStatusId;
                    attendance.ReasonId = model.ReasonId;
                    attendance.RecLastUpdateDate = DateTime.Now;
                    attendance.RecLastUpdatedBy = "FixApp";

                    _db.SaveChanges();

                }

                return true;
            }
            catch (Exception ex)
            {
                LogUtility.WriteLog("StaffAttendanceApiController", ex.Message, "ATT_FIX_LOGS");
                return null;
            }
        }

        public bool? Delete(StaffAttendanceModel model)
        {
            try
            {
                var attendanceRecord = _db.ATT_Staff_Attendance.Find(model.StaffAttendanceId);
                if (attendanceRecord == null) return false;

                if (attendanceRecord.LeaveId != null)
                {
                    var leave = _db.Att_Staff_Leaves.Find(attendanceRecord.LeaveId);
                    if (leave != null) leave.isDeleted = true;
                }

                _db.ATT_Staff_Attendance.Remove(attendanceRecord);
                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                LogUtility.WriteLog("StaffAttendanceApiController",ex.Message,"ATT_FIX_LOGS");
                return null;
            }            
        }
    }
}