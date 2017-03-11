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
    
    public partial class SR_Student_Classes
    {
        public SR_Student_Classes()
        {
            this.Student_ExtendedLeave = new HashSet<Student_ExtendedLeave>();
        }
    
        public int StudentClassId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> SectionId { get; set; }
        public Nullable<int> TermId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CREATED_ON { get; set; }
        public Nullable<System.DateTime> LAST_MODIFIED_DATE { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<int> LAST_MODIFIED_BY { get; set; }
        public Nullable<int> VERSION_NUMBER { get; set; }
        public Nullable<int> CampusId { get; set; }
    
        public virtual Config_Class Config_Class { get; set; }
        public virtual Config_Section Config_Section { get; set; }
        public virtual SR_Students SR_Students { get; set; }
        public virtual ICollection<Student_ExtendedLeave> Student_ExtendedLeave { get; set; }
    }
}
