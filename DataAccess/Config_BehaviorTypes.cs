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
    
    public partial class Config_BehaviorTypes
    {
        public Config_BehaviorTypes()
        {
            this.Rpt_BehaviorReports = new HashSet<Rpt_BehaviorReports>();
        }
    
        public short BehaviorTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short TypeKey { get; set; }
        public short Points { get; set; }
        public int CampusId { get; set; }
        public int ClassLevelId { get; set; }
    
        public virtual ICollection<Rpt_BehaviorReports> Rpt_BehaviorReports { get; set; }
    }
}