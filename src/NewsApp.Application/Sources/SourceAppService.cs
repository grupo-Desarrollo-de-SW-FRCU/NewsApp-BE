using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Sources
{
    public class SourceAppService : CrudAppService<Source, SourceDto, Guid>, ISourceAppService
    {
        public SourceAppService(IRepository<Source,Guid> repository) : base(repository)
        { }
    }
}
