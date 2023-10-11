using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsApp.NotificationsApp
{
    public class CreateUpdateNotificationAppDto
    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string? UrlToImage { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }
    }
}
