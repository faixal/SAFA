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
    
    public partial class MSG_Template
    {
        public int TemplateId { get; set; }
        public int TemplateType { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> AttendanceStatusId { get; set; }
    }
}