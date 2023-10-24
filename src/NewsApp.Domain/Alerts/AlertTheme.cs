using System;
using NewsApp.Themes;

namespace NewsApp.Alerts
{
    public class AlertTheme : Alert
    {
        public Theme Theme { get; set; }
        public Guid ThemeOfAlertId { get; set; }
    }
}
