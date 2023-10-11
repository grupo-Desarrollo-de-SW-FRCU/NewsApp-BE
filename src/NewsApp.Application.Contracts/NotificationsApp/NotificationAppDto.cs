using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.NotificationsApp
{
    public class NotificationAppDto : EntityDto<Guid>
    {
        public bool Active { get; set; }
        public string? UrlToImage { get; set; }
    }
}
