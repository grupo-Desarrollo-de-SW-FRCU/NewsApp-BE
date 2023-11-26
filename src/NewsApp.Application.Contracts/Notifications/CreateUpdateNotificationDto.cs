using Abp.Domain.Entities;
using NewsApp.Alerts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsApp.Notifications
{
    public class CreateUpdateNotificationDto
    {
        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }

        [Required]
        public int AlertId { get; set; }
        }
    }