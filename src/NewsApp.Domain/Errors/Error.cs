using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Errors
{
    public class Error : Entity<Guid>
    {
        public String name { get; set; }
        public String description { get; set; }
        public String errorCode { get; set; }
    }
}
