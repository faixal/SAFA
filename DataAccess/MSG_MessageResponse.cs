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
    
    public partial class MSG_MessageResponse
    {
        public int MessageResponseId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> AttendanceStatusId { get; set; }
        public string ReplyId { get; set; }
        public string MessageReply { get; set; }
        public Nullable<System.DateTime> ReplyDate { get; set; }
        public string SourceMobileNumber { get; set; }
        public string DestinationMobileNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<bool> ActionPerformed { get; set; }
        public string MessageId { get; set; }
        public Nullable<System.DateTime> SendingDateTime { get; set; }
        public Nullable<System.DateTime> ActionDate { get; set; }
    }
}
