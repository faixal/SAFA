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
    
    public partial class UMS_Roles
    {
        public UMS_Roles()
        {
            this.UMS_Users = new HashSet<UMS_Users>();
        }
    
        public int RoleId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<UMS_Users> UMS_Users { get; set; }
    }
}
