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
    
    public partial class Att_StudentReflection_Attendance
    {
        public int StudentReflectionAttendanceId { get; set; }
        public int StudentId { get; set; }
        public int IncidentId { get; set; }
        public System.DateTime ReflectionDate { get; set; }
        public string Message { get; set; }
        public Nullable<int> AttendanceStatusId { get; set; }
        public Nullable<bool> IsMessageSent { get; set; }
        public Nullable<System.DateTime> RecCreatedDate { get; set; }
        public string RecCreatedBy { get; set; }
    
        public virtual Rpt_Incidents Rpt_Incidents { get; set; }
        public virtual SR_Students SR_Students { get; set; }
    }
}
