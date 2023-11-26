using Abp.Authorization.Users;
using NewsApp.Alerts;
using NewsApp.Users;
using System;
using Volo.Abp.Application.Dtos;


namespace NewsApp.Notifications
{
    public class NotificationDto : EntityDto<int>
    {
        public bool Active { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public AlertDto Alert { get; set; }
        public int AlertId { get; set; }
        public UserDto User { get; set; }
    }
}
