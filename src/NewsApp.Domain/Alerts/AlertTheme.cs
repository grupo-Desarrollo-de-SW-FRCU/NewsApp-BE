using System;
using Microsoft.AspNetCore.Identity;
using NewsApp.Notifications;
using NewsApp.Themes;

namespace NewsApp.Alerts
{
    public class AlertTheme : Alert
    {
       

        public Theme Theme { get; set; }
        public Guid ThemeOfAlertId { get; set; }

        public AlertTheme(bool active, DateTime createdDate, Volo.Abp.Identity.IdentityUser user, Notification notification) : base(active, createdDate, user, notification)
        {
        }

        public static implicit operator AlertTheme?(AlertSearch? v)
        {
            throw new NotImplementedException();
        }
        //constructor de alert theme¿?


    }






}
