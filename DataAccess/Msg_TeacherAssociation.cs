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
    
    public partial class Msg_TeacherAssociation
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public Nullable<int> CampusId { get; set; }
    
        public virtual Config_Campus Config_Campus { get; set; }
        public virtual Config_Class Config_Class { get; set; }
        public virtual TR_Teachers TR_Teachers { get; set; }
    }
}
