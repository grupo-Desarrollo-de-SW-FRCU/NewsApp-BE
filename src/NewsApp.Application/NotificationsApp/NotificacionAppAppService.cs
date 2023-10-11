using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Notifications;
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
