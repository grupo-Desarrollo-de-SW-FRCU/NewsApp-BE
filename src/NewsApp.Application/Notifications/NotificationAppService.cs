using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Notifications
{
    public class NotificacionAppService :
    CrudAppService<
        Notification, //The Book entity
        NotificationDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateNotificationDto>, //Used to create/update a book
    INotificationAppService //implement the IBookAppService
    {
        public NotificacionAppService(IRepository<Notification, int> repository)
            : base(repository)
        {

        }
    }
}
