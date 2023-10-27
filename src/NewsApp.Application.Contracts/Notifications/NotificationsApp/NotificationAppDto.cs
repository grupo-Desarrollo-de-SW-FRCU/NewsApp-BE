using System;
using System.Collections.Generic;
using System.Text;
using Abp.Authorization.Users;
using NewsApp.Alerts;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Notifications.NotificationsApp
{
    public class NotificationAppDto : EntityDto<Guid>
    {
        public string Title { get; set; }
        public DateTime Datetime { get; set; }
        public bool Active { get; set; }
        public string? UrlToImage { get; set; }
        public Guid UserId { get; set; }
        public AlertDto Alert { get; set; }
    }
}
