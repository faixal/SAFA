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
    
    public partial class SR_Student_MedicalCards
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int MedicalCardTypeId { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public System.DateTime ExpiryDate { get; set; }
    
        public virtual Config_MedicalCardTypes Config_MedicalCardTypes { get; set; }
    }
}
