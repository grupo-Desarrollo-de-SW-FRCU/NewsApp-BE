using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsApp.Themes
{
    public class CreateUpdateThemeDto
    {

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
