using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Searchs;
using NewsApp.Themes;

namespace NewsApp.Alerts
{
    public class AlertTheme : Alert
    {
        public Theme Theme { get; set; }
        public Guid ThemeOfAlertId { get; set; }
    }
}
