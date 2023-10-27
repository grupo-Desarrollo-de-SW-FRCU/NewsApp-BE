using System;
using NewsApp.Themes;

namespace NewsApp.Alerts.AlertsThemes
{
    public class AlertThemeDto : AlertDto
    {
        public ThemeDto Theme { get; set; }
        public Guid ThemeOfAlertId { get; set; }
    }
}
