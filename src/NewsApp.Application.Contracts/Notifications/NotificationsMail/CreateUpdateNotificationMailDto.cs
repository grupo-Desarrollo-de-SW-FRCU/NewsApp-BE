﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsApp.Notifications.NotificationsMail
{
    public class CreateUpdateNotificationMailDto
    {
        [Required]
        public string Message { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }
    }
}