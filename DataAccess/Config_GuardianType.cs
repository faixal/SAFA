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
    
    public partial class Config_GuardianType
    {
        public Config_GuardianType()
        {
            this.ST_GuardianInformation = new HashSet<ST_GuardianInformation>();
        }
    
        public int GuardianTypeId { get; set; }
        public string Name { get; set; }
        public int GuardianTypeKey { get; set; }
    
        public virtual ICollection<ST_GuardianInformation> ST_GuardianInformation { get; set; }
    }
}