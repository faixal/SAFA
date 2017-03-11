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
    
    public partial class AssessmentLink
    {
        public AssessmentLink()
        {
            this.TaskAssessments = new HashSet<TaskAssessment>();
        }
    
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int TermId { get; set; }
        public int CampusId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public Nullable<int> Weight { get; set; }
        public Nullable<int> EvaluationTypeId { get; set; }
    
        public virtual Config_Class Config_Class { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Config_Terms Config_Terms { get; set; }
        public virtual ICollection<TaskAssessment> TaskAssessments { get; set; }
    }
}
