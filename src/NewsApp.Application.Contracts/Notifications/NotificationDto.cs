using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.Domain.Entities;
using NewsApp.Alerts;
using System;
using System.Collections.Generic;
using System.Text;


namespace NewsApp.Ntofications
{
    public class NotificationDto : Entity<Guid>
    {
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public AlertDto Alert { get; set; }
        public AbpUserBase User { get; set; }
    }
}
