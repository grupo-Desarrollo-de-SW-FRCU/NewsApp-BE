using System;
using NewsApp.Notifications;
using NewsApp.Notifications.NotificationsApp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.NotificationsApp
{
    public class NotificacionAppAppService :
    CrudAppService<
        NotificationMail, //The Book entity
        NotificationAppDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateNotificationAppDto>, //Used to create/update a book
    INotificationAppAppService //implement the IBookAppService
    {
        public NotificacionAppAppService(IRepository<NotificationMail, Guid> repository)
            : base(repository)
        {

        }
    }
}
