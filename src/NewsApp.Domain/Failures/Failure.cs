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
    public class Failure : Entity<int>
    {
        public DateTime ErrorDateTime { get; set; }
        public Search Search { get; set; }

        public int FailureOfSearchId { get; set; }
    }
}
