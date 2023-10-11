using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Fuentes;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Noticias
{

    public class NoticiaAppService : CrudAppService<Noticia, NoticiaDto, Guid>, INoticiaAppService
    {
        public NoticiaAppService(IRepository<Noticia, Guid> repository) : base(repository)
        { }
    }
}