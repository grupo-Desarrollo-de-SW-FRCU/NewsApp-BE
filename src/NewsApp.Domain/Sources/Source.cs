using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Sources
{
    public class Source : Entity<Guid>
    {
        public string Name { get; set; }
    } 
}
