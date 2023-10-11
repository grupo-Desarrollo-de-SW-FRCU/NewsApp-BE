using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Fuentes
{
    public class FuenteAppService : CrudAppService<Fuente, FuenteDto, Guid>, IFuenteAppService
    {
        public FuenteAppService(IRepository<Fuente,Guid> repository) : base(repository)
        { }
    }
}
