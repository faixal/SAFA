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
    
    public partial class SR_StudentAbsenceLog
    {
        public int LogId { get; set; }
        public int StudentId { get; set; }
        public int PresentPeriodNo { get; set; }
        public int AbsentPeriodNo { get; set; }
        public System.DateTime AbsenceDate { get; set; }
        public int TeacherId { get; set; }
    }
}