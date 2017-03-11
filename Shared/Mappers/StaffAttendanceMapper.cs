using DataAccess;
using Shared.Models;

namespace Shared.Mappers
{
    public static class StaffAttendanceMapper
    {
        public static StaffAttendanceModel MapToModel(this ATT_Staff_Attendance source)
        {
            StaffAttendanceModel model = new StaffAttendanceModel();
            model.StaffAttendanceId = source.StaffAttendanceId;
            model.CheckInDateTime = source.CheckInDateTime;
            model.CheckInDateTimeString = source.CheckInDateTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? string.Empty;
            model.CheckOutDateTime = source.CheckOutDateTime;
            model.CheckOutDateTimeString = source.CheckOutDateTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? string.Empty;
            model.RecCreatedDt = source.RecCreatedDt;
            model.RecCreatedDtString = source.AttendanceDate?.ToString("yyyy-MM-dd") ?? source.RecCreatedDt.ToString("yyyy-MM-dd");
            model.RecCreatedBy = source.RecCreatedBy;
            model.RecLastUpdateDate = source.RecLastUpdateDate;
            model.RecLastUpdatedBy = source.RecLastUpdatedBy;
            model.AttendanceStatusId = source.AttendanceStatusId;
            model.AttendanceStatusName = source.SYS_Attendance_Status != null? source.SYS_Attendance_Status.Name: string.Empty;
            model.ReasonId = source.ReasonId;
            model.ReasonName = source.SYS_Attendance_Status_Reason != null? source.SYS_Attendance_Status_Reason.ReasonName: string.Empty;
            model.TeacherId = source.TeacherId;
            model.TeacherName = source.TR_Teachers.FirstName + " " + source.TR_Teachers.LastName;
            model.CampusId = source.CampusId;
            model.IsSystemUpdated = source.IsSystemUpdated;
            model.AttendanceDate = source.AttendanceDate;           
            model.MarkedBy = source.MarkedBy;
            model.LeaveId = source.LeaveId;
            model.PayOption = source.PayOption;
            model.InServiceRequestId = source.InServiceRequestId;
            model.IncursionExcursionRequestId = source.IncursionExcursionRequestId;

            model.CheckInDate =source.CheckInDateTime?.ToString("yyyy-MM-dd") ?? string.Empty;
            model.CheckInTime =source.CheckInDateTime?.ToString("HH:mm") ?? string.Empty;

            model.CheckOutDate = source.CheckOutDateTime?.ToString("yyyy-MM-dd") ?? string.Empty;
            model.CheckOutTime = source.CheckOutDateTime?.ToString("HH:mm") ?? string.Empty;

            return model;
        }
    }
}
