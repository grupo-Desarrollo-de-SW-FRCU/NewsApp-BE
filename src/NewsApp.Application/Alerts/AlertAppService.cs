using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.Users;
using static Volo.Abp.Identity.Settings.IdentitySettingNames;

namespace NewsApp.Alerts;
public class AlertAppService :
    CrudAppService<
        Alert, //The Book entity
        AlertDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateAlertDto>, //Used to create/update a book
    IAlertAppService //implement the IBookAppService
{
    public AlertAppService(IRepository<Alert, int> repository)
        : base(repository)
    {

    }
}
