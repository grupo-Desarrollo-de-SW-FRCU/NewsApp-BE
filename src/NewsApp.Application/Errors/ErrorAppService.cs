using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Errors;

public class ErrorAppService :
    CrudAppService<
        Error, //The Book entity
        ErrorDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateErrorDto>, //Used to create/update a book
    IErrorAppService //implement the IBookAppService
{
    public ErrorAppService(IRepository<Error, Guid> repository)
        : base(repository)
    {

    }
}