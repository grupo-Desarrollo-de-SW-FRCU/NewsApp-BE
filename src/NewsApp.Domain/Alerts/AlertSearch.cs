using System;
using NewsApp.Searches;

namespace NewsApp.Alerts
{
    public class AlertSearch : Alert
    {
        // relaciones
        public Search Search { get; set; }

        public int AlertOfSearchId { get; set; }

        public AlertSearch()
        {
            base.Active = true;
        }

    }
}
