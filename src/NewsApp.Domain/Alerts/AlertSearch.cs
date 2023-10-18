using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Searchs;

namespace NewsApp.Alerts
{
    public class AlertSearch : Alert
    {
        public Search Search { get; set; }
        public Guid SearchOfAlertId { get; set; }
    }
}
