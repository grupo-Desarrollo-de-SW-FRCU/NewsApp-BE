using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Failures;

public class FailureAppService :
    CrudAppService<
        Failure, //The Book entity
        FailureDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateFailureDto>, //Used to create/update a book
    IFailureAppService //implement the IBookAppService
{
    public FailureAppService(IRepository<Failure, int> repository)
        : base(repository)
    {

    }
}