﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Notifications;
using NewsApp.Searchs;

namespace NewsApp.Alerts
{
    public class AlertSearch : Alert
    {
        public Search Search { get; set; }
        public Guid SearchOfAlertId { get; set; }



        public AlertSearch(bool active, DateTime createdDate, Volo.Abp.Identity.IdentityUser user, Notification notification) : base(active, createdDate, user, notification)
        {
        }

        //constructor de alert search¿?

    }
}
