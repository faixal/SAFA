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
    
    public partial class SR_StudentEarlyLeaveLog
    {
        public int LogId { get; set; }
        public int StudentId { get; set; }
        public Nullable<System.DateTime> EarlyLeaveDate { get; set; }
        public Nullable<int> TeacherId { get; set; }
    }
}
