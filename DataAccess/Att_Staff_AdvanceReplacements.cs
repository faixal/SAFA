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
    
    public partial class Att_Staff_AdvanceReplacements
    {
        public int ReplacementId { get; set; }
        public int TeacherId { get; set; }
        public int ReplacingTeacherId { get; set; }
        public System.DateTime RecCreatedDate { get; set; }
        public System.DateTime RecLastUpdatedDate { get; set; }
        public System.DateTime ReplacementDate { get; set; }
        public int ScheduleId { get; set; }
    
        public virtual ATT_Schedule ATT_Schedule { get; set; }
        public virtual TR_Teachers TR_Teachers { get; set; }
        public virtual TR_Teachers TR_Teachers1 { get; set; }
    }
}
