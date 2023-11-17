using Abp.Authorization.Users;
using NewsApp.Alerts;
using System;
using Volo.Abp.Application.Dtos;


namespace NewsApp.Notifications
{
    public class NotificationDto : EntityDto<Guid>
    {
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public AlertDto Alert { get; set; }
        public AbpUserBase User { get; set; }
    }
}
