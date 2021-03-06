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
    
    public partial class Config_Statuses
    {
        public Config_Statuses()
        {
            this.Att_Staff_InServiceRequests = new HashSet<Att_Staff_InServiceRequests>();
            this.Config_AfterSchoolReflectionSchedule = new HashSet<Config_AfterSchoolReflectionSchedule>();
            this.Feedbacks = new HashSet<Feedback>();
            this.Rpt_BehaviorReports = new HashSet<Rpt_BehaviorReports>();
            this.Rpt_Incidents = new HashSet<Rpt_Incidents>();
            this.SR_Student_Logs = new HashSet<SR_Student_Logs>();
            this.TR_HazardRequests = new HashSet<TR_HazardRequests>();
            this.TR_IncursionExcursionRequests = new HashSet<TR_IncursionExcursionRequests>();
            this.TR_ItSupportRequests = new HashSet<TR_ItSupportRequests>();
            this.TR_MaintenanceRequests = new HashSet<TR_MaintenanceRequests>();
            this.TR_PurchaseOrderRequests = new HashSet<TR_PurchaseOrderRequests>();
            this.TR_TeacherVenueRequests = new HashSet<TR_TeacherVenueRequests>();
            this.Config_RequestTypes = new HashSet<Config_RequestTypes>();
            this.Config_StatusLevel = new HashSet<Config_StatusLevel>();
        }
    
        public short StatusId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short RequestStatusKey { get; set; }
        public string Description { get; set; }
        public bool IsFinalStep { get; set; }
        public Nullable<short> RequestTypeId { get; set; }
    
        public virtual ICollection<Att_Staff_InServiceRequests> Att_Staff_InServiceRequests { get; set; }
        public virtual ICollection<Config_AfterSchoolReflectionSchedule> Config_AfterSchoolReflectionSchedule { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Rpt_BehaviorReports> Rpt_BehaviorReports { get; set; }
        public virtual ICollection<Rpt_Incidents> Rpt_Incidents { get; set; }
        public virtual ICollection<SR_Student_Logs> SR_Student_Logs { get; set; }
        public virtual ICollection<TR_HazardRequests> TR_HazardRequests { get; set; }
        public virtual ICollection<TR_IncursionExcursionRequests> TR_IncursionExcursionRequests { get; set; }
        public virtual ICollection<TR_ItSupportRequests> TR_ItSupportRequests { get; set; }
        public virtual ICollection<TR_MaintenanceRequests> TR_MaintenanceRequests { get; set; }
        public virtual ICollection<TR_PurchaseOrderRequests> TR_PurchaseOrderRequests { get; set; }
        public virtual ICollection<TR_TeacherVenueRequests> TR_TeacherVenueRequests { get; set; }
        public virtual ICollection<Config_RequestTypes> Config_RequestTypes { get; set; }
        public virtual ICollection<Config_StatusLevel> Config_StatusLevel { get; set; }
    }
}
