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
    
    public partial class Config_IncidentType
    {
        public Config_IncidentType()
        {
            this.Rpt_Incidents = new HashSet<Rpt_Incidents>();
        }
    
        public short IncidentTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Rpt_Incidents> Rpt_Incidents { get; set; }
    }
}
