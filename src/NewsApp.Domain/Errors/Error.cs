﻿using System;
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
 
        public string Name { get; set; }
        public string Description { get; set; }
        public string ErrorCode { get; set; }
        public DateTime Time { get; set; }
        public string ExceptionName { get; set; }
    }
}
