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
    
    public partial class TeacherClassCode
    {
        public TeacherClassCode()
        {
            this.ATT_Schedule = new HashSet<ATT_Schedule>();
            this.StudentClassCodes = new HashSet<StudentClassCode>();
            this.TR_IncursionExcursionClasses = new HashSet<TR_IncursionExcursionClasses>();
        }
    
        public int TeacherClassCodeId { get; set; }
        public int ClassCodeId { get; set; }
        public int TeacherId { get; set; }
        public int TermId { get; set; }
    
        public virtual ICollection<ATT_Schedule> ATT_Schedule { get; set; }
        public virtual ClassCode ClassCode { get; set; }
        public virtual Config_Terms Config_Terms { get; set; }
        public virtual ICollection<StudentClassCode> StudentClassCodes { get; set; }
        public virtual TR_Teachers TR_Teachers { get; set; }
        public virtual ICollection<TR_IncursionExcursionClasses> TR_IncursionExcursionClasses { get; set; }
    }
}
