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
    
    public partial class TR_PurchaseOrderRequestLines
    {
        public int PurchaseOrderLineId { get; set; }
        public int PurchaseOrderRequestId { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public decimal UnitCost { get; set; }
        public int Unit { get; set; }
    
        public virtual TR_PurchaseOrderRequests TR_PurchaseOrderRequests { get; set; }
    }
}
