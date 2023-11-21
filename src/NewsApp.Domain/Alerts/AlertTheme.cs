using System;
using Microsoft.AspNetCore.Identity;
using NewsApp.Notifications;
using NewsApp.Themes;

namespace NewsApp.Alerts
{
    public class AlertTheme : Alert
    {
        public Theme Theme { get; set; }

        public int AlertOfThemeId { get; set; }

        /*public AlertTheme(
            Theme theme,
            Guid themeOfAlertId,
            bool active, 
            DateTime createdDate, 
            Volo.Abp.Identity.IdentityUser user, 
            Notification notification)
            : base(
                  active, 
                  createdDate, 
                  user, 
                  notification)
        {
           Theme = theme; 
           ThemeOfAlertId = themeOfAlertId;
        }*/

    }






}
