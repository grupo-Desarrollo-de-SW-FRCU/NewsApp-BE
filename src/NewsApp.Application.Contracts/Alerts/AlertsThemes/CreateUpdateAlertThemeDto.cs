﻿using System;
using System.ComponentModel.DataAnnotations;
using NewsApp.Themes;

namespace NewsApp.Alerts.AlertsThemes
{
    public class CreateUpdateAlertThemeDto : CreateUpdateAlertDto
    {
        [Required]
        public ThemeDto Theme { get; set; }
        [Required]
        public Guid ThemeOfAlertId { get; set; }
    }
}
