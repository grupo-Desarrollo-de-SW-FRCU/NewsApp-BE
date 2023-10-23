using System;
using System.Collections.Generic;
using System.Text;
using NewsApp.Searchs;

namespace NewsApp.Alerts.AlertsSearches
{
    public class AlertSearchDto : AlertDto
    {
        public SearchDto Search { get; set; }
        public Guid SearchOfAlertId { get; set; }
    }
}
