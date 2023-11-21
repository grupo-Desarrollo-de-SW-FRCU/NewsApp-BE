using System;
using NewsApp.Notifications;
using NewsApp.Users;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Alerts
{
    public class AlertDto : EntityDto<int>
    {
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        //public string SearchText { get; set; }
        public NotificationDto Notification { get; set; }
        public UserDto User { get; set; }
    }
}
