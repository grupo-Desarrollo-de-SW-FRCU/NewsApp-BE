using System;
using System.Collections.Generic;
using System.Text;
using Abp.Authorization.Users;
using NewsApp.Alerts;
using Volo.Abp.Application.Dtos;

namespace NewsApp.NotificationsMail
{
    public class NotificationMailDto : EntityDto<Guid>
    {
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public string Message { get; set; }
        public AbpUserBase User { get; set; }
        public AlertDto Alert { get; set; }
    }
}
