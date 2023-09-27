using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Accesses;

public interface IAccessAppService :
    ICrudAppService< //Defines CRUD methods
        AccessDto, //Used to show accesses
        Guid, //Primary key of the access entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateAccessDto> //Used to create/update an access
{

}
