using System;
using NewsApp.Notifications;
using NewsApp.Ntofications;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Alerts
{
    public class AlertDto : EntityDto<Guid>
    {
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        //public string SearchText { get; set; }
        
        public NotificationDto Notification { get; set; }
        public Guid UserId { get; set; }
    }
}
