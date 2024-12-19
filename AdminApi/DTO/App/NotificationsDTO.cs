using System;

namespace AdminApi.DTO.App
{
    public class NotificationsDTO
    {
        public string NotificationName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdateNotificationsDTO
    {
        public int NotificationsId { get; set; }
        public string NotificationName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
