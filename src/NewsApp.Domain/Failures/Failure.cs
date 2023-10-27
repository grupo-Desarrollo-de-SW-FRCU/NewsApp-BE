using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Searches;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Failures
{
    public class Failure : Entity<Guid>
    {
        public DateTime ErrorDateTime { get; set; }
        public Exception Exception { get; set; }
        public Search Search { get; set; }
        public Guid SearchOfFailureId { get; set; }
    }
}
