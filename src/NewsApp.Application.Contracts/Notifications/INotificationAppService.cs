﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Notifications
{
    public interface INotificationAppService :
        ICrudAppService<
            NotificationDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateNotificationDto
            >
    {
    }
}
