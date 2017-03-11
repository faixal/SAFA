using System;

namespace Shared.Models
{
    public class StaffAttendanceModel
    {
        public long StaffAttendanceId { get; set; }
        public DateTime? CheckInDateTime { get; set; }
        public string CheckInDateTimeString { get; set; }
        public DateTime? CheckOutDateTime { get; set; }
        public string CheckOutDateTimeString { get; set; }
        public DateTime RecCreatedDt { get; set; }
        public string RecCreatedBy { get; set; }
        public DateTime RecLastUpdateDate { get; set; }
        public string RecLastUpdatedBy { get; set; }
        public int? AttendanceStatusId { get; set; }
        public int? ReasonId { get; set; }
        public int TeacherId { get; set; }
        public int CampusId { get; set; }
        public bool? IsSystemUpdated { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public int? MarkedBy { get; set; }
        public int? LeaveId { get; set; }
        public int? PayOption { get; set; }
        public int? InServiceRequestId { get; set; }
        public int? IncursionExcursionRequestId { get; set; }


        public string TeacherName { get; set; }
        public string AttendanceStatusName { get; set; }
        public string ReasonName { get; set; }
        public string RecCreatedDtString { get; set; }
        public string CheckInDate { get; set; }
        public string CheckInTime { get; set; }
        public string CheckOutDate { get; set; }
        public string CheckOutTime { get; set; }
    }
}
