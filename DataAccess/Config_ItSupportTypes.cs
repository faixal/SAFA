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
    
    public partial class Config_ItSupportTypes
    {
        public Config_ItSupportTypes()
        {
            this.TR_ItSupportRequests = new HashSet<TR_ItSupportRequests>();
        }
    
        public int ItSupportTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItSupportTypeKey { get; set; }
    
        public virtual ICollection<TR_ItSupportRequests> TR_ItSupportRequests { get; set; }
    }
}
