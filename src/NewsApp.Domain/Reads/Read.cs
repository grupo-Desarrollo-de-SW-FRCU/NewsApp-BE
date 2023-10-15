using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Reads
{
    public class Read : Entity<Guid>
    {
        public DateTime ReadDateTime { get; set; }
        public bool Liked { get; set; }

    }
}

