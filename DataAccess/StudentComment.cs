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
    
    public partial class StudentComment
    {
        public int StudCommId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> ClassCodeId { get; set; }
        public Nullable<int> TermId { get; set; }
        public Nullable<int> TeacherClassCodeId { get; set; }
        public string Comments { get; set; }
    }
}
