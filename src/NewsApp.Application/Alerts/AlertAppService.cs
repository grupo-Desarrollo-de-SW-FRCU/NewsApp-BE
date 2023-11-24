using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

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
