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
    
    public partial class Allotments_SalaryLevels
    {
        public Allotments_SalaryLevels()
        {
            this.Allotments_TeacherSalaries = new HashSet<Allotments_TeacherSalaries>();
            this.Allotments_TeacherResponsibilities = new HashSet<Allotments_TeacherResponsibilities>();
        }
    
        public int SalaryLevelId { get; set; }
        public int LevelTypeId { get; set; }
        public string Level { get; set; }
        public int Year { get; set; }
        public decimal Salary { get; set; }
    
        public virtual Allotments_LevelTypes Allotments_LevelTypes { get; set; }
        public virtual ICollection<Allotments_TeacherSalaries> Allotments_TeacherSalaries { get; set; }
        public virtual ICollection<Allotments_TeacherResponsibilities> Allotments_TeacherResponsibilities { get; set; }
    }
}
