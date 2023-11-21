using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Searches;
public interface ISearchAppService :
    ICrudAppService< //Defines CRUD methods
        SearchDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateSearchDto> //Used to create/update a book
{

}
