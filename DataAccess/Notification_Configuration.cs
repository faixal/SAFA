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
    
    public partial class Notification_Configuration
    {
        public Notification_Configuration()
        {
            this.Notifications = new HashSet<Notification>();
        }
    
        public int NotificationConfigId { get; set; }
        public Nullable<int> CampusId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string WeekDay { get; set; }
        public Nullable<System.TimeSpan> TimeToSend { get; set; }
        public Nullable<int> GracePeriod { get; set; }
        public int NotificationType { get; set; }
        public Nullable<int> AttendanceStatusId { get; set; }
        public Nullable<int> NotificationAlertType { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual SYS_Attendance_Status SYS_Attendance_Status { get; set; }
    }
}