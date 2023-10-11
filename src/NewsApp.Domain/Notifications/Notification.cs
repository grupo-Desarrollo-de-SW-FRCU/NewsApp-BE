using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Notifications
{
    public abstract class Notification : Entity<Guid>
    {
        public required string Title { get; set; }
        public DateTime DateTime { get; set; }
    }
}
