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
    
    public partial class Config_WorkHabits
    {
        public Config_WorkHabits()
        {
            this.Config_StudentWorkHabit = new HashSet<Config_StudentWorkHabit>();
            this.Config_SubjectWorkHabits = new HashSet<Config_SubjectWorkHabits>();
        }
    
        public int WorkHabitId { get; set; }
        public string Description { get; set; }
        public Nullable<int> ClassLevelId { get; set; }
    
        public virtual ICollection<Config_StudentWorkHabit> Config_StudentWorkHabit { get; set; }
        public virtual ICollection<Config_SubjectWorkHabits> Config_SubjectWorkHabits { get; set; }
    }
}
