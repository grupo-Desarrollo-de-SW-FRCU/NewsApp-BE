using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsApp.Errors
{
    public class CreateUpdateErrorDto
    {
        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        public string errorCode { get; set; }
        public string description { get; set; }
    }
}
