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
    
    public partial class Rpt_IncidentParties
    {
        public int IncidentPartyId { get; set; }
        public int IncidentId { get; set; }
        public Nullable<int> TeacherId { get; set; }
        public int StudentId { get; set; }
    
        public virtual SR_Students SR_Students { get; set; }
        public virtual Rpt_Incidents Rpt_Incidents { get; set; }
    }
}
