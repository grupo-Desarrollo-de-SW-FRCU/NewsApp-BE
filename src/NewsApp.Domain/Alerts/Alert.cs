using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Alerts
{
    public class Alert : Entity<Guid>
    {
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SearchText { get; set; }
        public AbpUserBase User { get; set; }
    }
}
