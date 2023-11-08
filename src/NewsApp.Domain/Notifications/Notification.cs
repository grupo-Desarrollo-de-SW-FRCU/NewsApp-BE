using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using NewsApp.Alerts;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Notifications
{
    public abstract class Notification : Entity<Guid>
    {
        private bool active;
        private string urlToImage;

        public required string Title { get; set; }
        public DateTime DateTime { get; set; }
        public Alert Alert { get; set; }
        public AbpUserBase User { get; set; }

    /*public Notification(
                string title,
                DateTime dateTime,
                Alert alert,
                AbpUserBase user
                )
        {
            Title = title;
            DateTime = dateTime;
            Alert = alert;
            User = user;
        }*/
    }
}
