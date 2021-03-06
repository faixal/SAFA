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
    
    public partial class TR_IncursionExcursionRequests
    {
        public TR_IncursionExcursionRequests()
        {
            this.ATT_Staff_Attendance = new HashSet<ATT_Staff_Attendance>();
            this.TR_IncursionExcursionClasses = new HashSet<TR_IncursionExcursionClasses>();
            this.TR_Teachers1 = new HashSet<TR_Teachers>();
        }
    
        public int RequestId { get; set; }
        public short ActivityType { get; set; }
        public string DestinationName { get; set; }
        public string DestinationAddress { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan SchoolDepartureTime { get; set; }
        public System.TimeSpan SchoolArrivalTime { get; set; }
        public short LunchOption { get; set; }
        public int Attendance { get; set; }
        public short Category { get; set; }
        public string Rational { get; set; }
        public decimal Cost { get; set; }
        public Nullable<decimal> ExcursionCost { get; set; }
        public string Transport { get; set; }
        public System.TimeSpan DestinationDepartureTime { get; set; }
        public System.TimeSpan DestinationArrivalTime { get; set; }
        public string StopOver { get; set; }
        public int TeacherId { get; set; }
        public System.DateTime RecCreatedDate { get; set; }
        public int RecCreatedBy { get; set; }
        public System.DateTime RecLastUpdatedDate { get; set; }
        public int RecLastUpdatedBy { get; set; }
        public short StatusId { get; set; }
        public string Classes { get; set; }
        public int StatusLevelId { get; set; }
        public string Response { get; set; }
        public Nullable<decimal> TransportCost { get; set; }
        public int CampusId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> BusSupplierId { get; set; }
        public string ContactNumber { get; set; }
        public Nullable<bool> StudentFunded { get; set; }
        public Nullable<short> SelectionType { get; set; }
        public Nullable<bool> TeacherPaidFor { get; set; }
    
        public virtual ICollection<ATT_Staff_Attendance> ATT_Staff_Attendance { get; set; }
        public virtual Config_Statuses Config_Statuses { get; set; }
        public virtual ICollection<TR_IncursionExcursionClasses> TR_IncursionExcursionClasses { get; set; }
        public virtual TR_Teachers TR_Teachers { get; set; }
        public virtual ICollection<TR_Teachers> TR_Teachers1 { get; set; }
    }
}
