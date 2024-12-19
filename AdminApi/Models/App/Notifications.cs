using System;

namespace AdminApi.Models.App
{
    public class Notifications
    {
        public int NotificationsId { get; set; }
        public string NotificationName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
