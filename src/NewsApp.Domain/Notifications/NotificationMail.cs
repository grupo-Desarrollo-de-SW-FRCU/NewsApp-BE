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

        public NotificationMail(
                string message
                )
        {
            Message = message;
        }
    }
}
