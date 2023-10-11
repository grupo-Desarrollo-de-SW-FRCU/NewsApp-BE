using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.NotificationsMail
{
    public interface INotificationMailAppService :
    ICrudAppService< //Defines CRUD methods
        NotificationMailDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateNotificationMailDto> //Used to create/update a book
    {

    }
}
