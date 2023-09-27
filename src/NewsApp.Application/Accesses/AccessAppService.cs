using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Accesses;

public class AccessAppService :
    CrudAppService<
        Access, //The Access entity
        AccessDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateAccessDto>, //Used to create/update a book
    IAccessAppService //implement the IBookAppService
{
    public AccessAppService(IRepository<Access, Guid> repository)
        : base(repository)
    {

    }

    Task<AccessDto> ICreateAppService<AccessDto, CreateUpdateAccessDto>.CreateAsync(CreateUpdateAccessDto input)
    {
        throw new NotImplementedException();
    }

    Task<AccessDto> IReadOnlyAppService<AccessDto, AccessDto, Guid, PagedAndSortedResultRequestDto>.GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<PagedResultDto<AccessDto>> IReadOnlyAppService<AccessDto, AccessDto, Guid, PagedAndSortedResultRequestDto>.GetListAsync(PagedAndSortedResultRequestDto input)
    {
        throw new NotImplementedException();
    }

    Task<AccessDto> IUpdateAppService<AccessDto, Guid, CreateUpdateAccessDto>.UpdateAsync(Guid id, CreateUpdateAccessDto input)
    {
        throw new NotImplementedException();
    }
}
