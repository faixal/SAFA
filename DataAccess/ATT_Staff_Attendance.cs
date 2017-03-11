//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ATT_Staff_Attendance
    {
        public long StaffAttendanceId { get; set; }
        public Nullable<System.DateTime> CheckInDateTime { get; set; }
        public Nullable<System.DateTime> CheckOutDateTime { get; set; }
        public System.DateTime RecCreatedDt { get; set; }
        public string RecCreatedBy { get; set; }
        public System.DateTime RecLastUpdateDate { get; set; }
        public string RecLastUpdatedBy { get; set; }
        public Nullable<int> AttendanceStatusId { get; set; }
        public Nullable<int> ReasonId { get; set; }
        public int TeacherId { get; set; }
        public int CampusId { get; set; }
        public Nullable<bool> IsSystemUpdated { get; set; }
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        public Nullable<int> MarkedBy { get; set; }
        public Nullable<int> LeaveId { get; set; }
        public Nullable<int> PayOption { get; set; }
        public Nullable<int> InServiceRequestId { get; set; }
        public Nullable<int> IncursionExcursionRequestId { get; set; }
    
        public virtual TR_IncursionExcursionRequests TR_IncursionExcursionRequests { get; set; }
        public virtual Config_Campus Config_Campus { get; set; }
        public virtual SYS_Attendance_Status_Reason SYS_Attendance_Status_Reason { get; set; }
        public virtual SYS_Attendance_Status SYS_Attendance_Status { get; set; }
        public virtual TR_Teachers TR_Teachers { get; set; }
    }
}
