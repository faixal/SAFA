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
    
    public partial class StudentClassCode
    {
        public int StudentClassId { get; set; }
        public int TeacherClassCodeId { get; set; }
        public int StudentId { get; set; }
    
        public virtual SR_Students SR_Students { get; set; }
        public virtual TeacherClassCode TeacherClassCode { get; set; }
        public virtual StudentClassCode StudentClassCodes1 { get; set; }
        public virtual StudentClassCode StudentClassCode1 { get; set; }
    }
}