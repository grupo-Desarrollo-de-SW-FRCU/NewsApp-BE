using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Searchs;
using NewsApp.Sources;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Noticias //CLASE COMPONENT COMPOSITE
{

    public class NoticiaAppService : CrudAppService<Search, NoticiaDto, Guid>, INoticiaAppService
    {
        public NoticiaAppService(IRepository<Search, Guid> repository) : base(repository)
        { }
    }
}