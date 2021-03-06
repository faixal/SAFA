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
    
    public partial class TR_PurchaseOrderRequests
    {
        public TR_PurchaseOrderRequests()
        {
            this.TR_PurchaseOrderRequestLines = new HashSet<TR_PurchaseOrderRequestLines>();
        }
    
        public int PurchaseOrderRequestId { get; set; }
        public string SupplierName { get; set; }
        public string Domain { get; set; }
        public string AdditionalInformation { get; set; }
        public int TeacherId { get; set; }
        public short StatusId { get; set; }
        public int RecCreatedBy { get; set; }
        public System.DateTime RecCreatedDate { get; set; }
        public int RecLastUpdatedBy { get; set; }
        public System.DateTime RecLastUpdatedDate { get; set; }
        public Nullable<decimal> Delivery { get; set; }
        public int StatusLevelId { get; set; }
        public string Response { get; set; }
        public int SubjectId { get; set; }
        public string FileName { get; set; }
        public Nullable<System.DateTime> FileUploadedDate { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public int CampusId { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual Config_Campus Config_Campus { get; set; }
        public virtual Config_Statuses Config_Statuses { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<TR_PurchaseOrderRequestLines> TR_PurchaseOrderRequestLines { get; set; }
        public virtual TR_Teachers TR_Teachers { get; set; }
    }
}
