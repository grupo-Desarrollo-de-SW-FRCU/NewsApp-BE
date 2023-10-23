using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NewsApp.ArticlesOrThemes.Themes;

namespace NewsApp.Alerts.AlertsThemes
{
    internal class CreateUpdateAlertThemeDto : CreateUpdateAlertDto
    {
        [Required]
        public ThemeDto Theme { get; set; }
        [Required]
        public Guid ThemeOfAlertId { get; set; }
    }
}
