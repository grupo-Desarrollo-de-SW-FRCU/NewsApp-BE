using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Errors
{
    public class Error : Entity<Guid>
    {
 
        public String Name { get; set; }
        public String Description { get; set; }
        public String ErrorCode { get; set; }
        public String Time { get; set; }
        public Exception ExceptionName { get; set; }
    }
}
