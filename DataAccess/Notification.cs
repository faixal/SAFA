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
    
    public partial class Notification
    {
        public int NotificationId { get; set; }
        public int NotificationConfigId { get; set; }
        public int NotifyToType { get; set; }
        public int NotifyTo { get; set; }
    
        public virtual Notification_Configuration Notification_Configuration { get; set; }
    }
}