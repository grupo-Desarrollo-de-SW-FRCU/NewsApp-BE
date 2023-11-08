using Abp.Authorization.Users;
using JetBrains.Annotations;
using NewsApp.Alerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Notifications
{
    public class NotificationMail : Notification
    {
        public string Message { get; set; }

        //REVISAR CONSTRUCTORES DE NOTIFICACIONES
/*
        public NotificationMail(
                   string title,
                   DateTime dateTime,
                   Alert alert,
                   AbpUserBase user
                   ) : base(title, dateTime, alert, user)
        {
            Message = "";
         
        }*/
    }
}
