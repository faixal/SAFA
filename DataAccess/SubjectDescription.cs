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
    
    public partial class SubjectDescription
    {
        public int SubjDescId { get; set; }
        public Nullable<int> SubjectId { get; set; }
        public string Description { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> TermId { get; set; }
        public Nullable<int> CampusId { get; set; }
    }
}
