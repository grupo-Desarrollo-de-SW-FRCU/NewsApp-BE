using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using NewsApp.Searchs;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;

namespace NewsApp.Alerts
{
    public abstract class Alert : Entity<Guid>
    {
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SearchText { get; set; }
        public required IdentityUser User { get; set; }
    }
}
