using Abp.Authorization.Users;
using NewsApp.Alerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Notifications
{
    public class NotificationApp : Notification
    {
        public bool Active { get; set; }
        public string? UrlToImage { get; set; }

        // REVISAR CONSTRUCTORES DE NOTIFICACIONES
       /* public NotificationApp(
                   string title,
                   DateTime dateTime,
                   Alert alert,
                   AbpUserBase user
                   ) : base(title, dateTime, alert, user) 
        {
            Active = true;
            UrlToImage = "";
        }*/


    }
}
