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
    
    public partial class PreApprovedSubject
    {
        public int PreApprovedSubjectId { get; set; }
        public int SubjectId { get; set; }
        public int RequestTypeId { get; set; }
        public int CategoryId { get; set; }
        public int CampusId { get; set; }
        public int StatusId { get; set; }
    
        public virtual Subject Subject { get; set; }
    }
}
