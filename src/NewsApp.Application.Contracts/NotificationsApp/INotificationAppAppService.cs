using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.NotificationsApp
{
    public interface INotificationAppAppService:
    ICrudAppService< //Defines CRUD methods
        NotificationAppDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateNotificationAppDto> //Used to create/update a book
    {

    }
}
