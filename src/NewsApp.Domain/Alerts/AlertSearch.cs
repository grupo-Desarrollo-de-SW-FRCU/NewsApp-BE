using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Notifications;
using NewsApp.Searches;

namespace NewsApp.Alerts
{
    public class AlertSearch : Alert
    {
        // relaciones
        public Search Search { get; set; }
        public Guid SearchOfAlertId { get; set; }

       /* public AlertSearch(
            Search search,
            Guid searchOfAlertId,
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
            Search = search; // no me deja porque tengo un campo dentro de search como required
            SearchOfAlertId = searchOfAlertId;
        }*/

        //constructor de alert search¿?

    }
}
