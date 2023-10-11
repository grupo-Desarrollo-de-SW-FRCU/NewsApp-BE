using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Errors;

public interface IErrorAppService :
    ICrudAppService< //Defines CRUD methods
        ErrorDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateErrorDto> //Used to create/update a book
        {

        }
