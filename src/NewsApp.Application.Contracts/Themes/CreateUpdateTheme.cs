using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsApp.Themes
{
    internal class CreateUpdateTheme
    {

        [Required]
        [StringLength(100)]
        public string name { get; set; }
    }
}
