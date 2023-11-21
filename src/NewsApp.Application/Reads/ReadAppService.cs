using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Reads;

public class ReadAppService :
    CrudAppService<
        Read, //The Book entity
        ReadDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateReadDto>, //Used to create/update a book
    IReadAppService //implement the IBookAppService
{
    public ReadAppService(IRepository<Read, int> repository)
        : base(repository)
    {

    }
}