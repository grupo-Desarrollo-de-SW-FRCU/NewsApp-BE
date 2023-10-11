using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Notifications;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.NotificationsMail
{
    public class NotificacionMailAppService :
    CrudAppService<
        NotificationMail, //The Book entity
        NotificationMailDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateNotificationMailDto>, //Used to create/update a book
    INotificationMailAppService //implement the IBookAppService
    {
        public NotificacionMailAppService(IRepository<NotificationMail, Guid> repository)
            : base(repository)
        {

        }
    }
}
