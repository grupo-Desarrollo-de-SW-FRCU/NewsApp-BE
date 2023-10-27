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

     public NotificationApp(
                bool active,
                string urlToImage
                )
        {
            Active = active;
            UrlToImage = urlToImage;
        }
    }
}
