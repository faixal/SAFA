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
    
    public partial class Config_Period
    {
        public Config_Period()
        {
            this.ATT_Schedule = new HashSet<ATT_Schedule>();
        }
    
        public int PeriodId { get; set; }
        public Nullable<int> PeriodNo { get; set; }
        public string PeriodName { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> FinishTime { get; set; }
        public Nullable<int> ClassLevelId { get; set; }
        public Nullable<int> CampusId { get; set; }
    
        public virtual ICollection<ATT_Schedule> ATT_Schedule { get; set; }
    }
}