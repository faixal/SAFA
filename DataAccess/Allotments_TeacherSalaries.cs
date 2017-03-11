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
    
    public partial class Allotments_TeacherSalaries
    {
        public Allotments_TeacherSalaries()
        {
            this.Allotments_StaffSchedule = new HashSet<Allotments_StaffSchedule>();
            this.Allotments_TeacherResponsibilities = new HashSet<Allotments_TeacherResponsibilities>();
        }
    
        public int TeacherSalaryId { get; set; }
        public int TeacherId { get; set; }
        public int SalaryLevelId { get; set; }
        public string Position { get; set; }
        public int CampusId { get; set; }
        public int WorkLoadId { get; set; }
        public int Year { get; set; }
        public Nullable<System.DateTime> LevelIncrementDate { get; set; }
        public string Notes { get; set; }
        public string ManagementNotes { get; set; }
    
        public virtual Allotments_SalaryLevels Allotments_SalaryLevels { get; set; }
        public virtual ICollection<Allotments_StaffSchedule> Allotments_StaffSchedule { get; set; }
        public virtual ICollection<Allotments_TeacherResponsibilities> Allotments_TeacherResponsibilities { get; set; }
        public virtual Config_Campus Config_Campus { get; set; }
        public virtual Config_StaffWorkLoad Config_StaffWorkLoad { get; set; }
        public virtual TR_Teachers TR_Teachers { get; set; }
    }
}