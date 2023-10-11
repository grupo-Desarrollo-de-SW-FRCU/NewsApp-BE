using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.NotificationsMail
{
    public class NotificationMailDto : EntityDto<Guid>
    {
        public string Message { get; set; }
    }
}
