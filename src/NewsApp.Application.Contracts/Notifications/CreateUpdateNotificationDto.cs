using Abp.Domain.Entities;
using NewsApp.Alerts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsApp.Notifications
{
    public class CreateUpdateNotificationsDto
    {

        [Required]
            public  string Title { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
            public AlertDto Alert { get; set; }


        }
    }