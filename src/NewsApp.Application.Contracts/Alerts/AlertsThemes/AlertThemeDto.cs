using System;
using System.Collections.Generic;
using System.Text;
using NewsApp.ArticlesOrThemes;
using NewsApp.Themes;

namespace NewsApp.Alerts.AlertsThemes
{
    public class AlertThemeDto : AlertDto
    {
        public ThemeDto Theme { get; set; }
        public Guid ThemeOfAlertId { get; set; }
    }
}
