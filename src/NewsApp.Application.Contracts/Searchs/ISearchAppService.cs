using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Searchs
{
    public interface ISearchAppService : ICrudAppService<SearchDto,Guid>
    {

    }
}
