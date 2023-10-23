using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Alerts
{
    public class AlertAppService : CrudAppService<Alert, AlertDto, Guid>, IAlertAppService
    {
        public AlertAppService(IRepository<Alert, Guid> repository)
            : base(repository)
        {

        }
    }
}
