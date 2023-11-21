using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Searches;
public class SearchAppService :
    CrudAppService<
        Search, //The Book entity
        SearchDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateSearchDto>, //Used to create/update a book
    ISearchAppService //implement the IBookAppService
{
    public SearchAppService(IRepository<Search, int> repository)
        : base(repository)
    {

    }
}
