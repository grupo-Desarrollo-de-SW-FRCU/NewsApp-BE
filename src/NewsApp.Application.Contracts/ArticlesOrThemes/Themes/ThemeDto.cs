using System;
using System.Collections.Generic;
using NewsApp.Alerts.AlertsThemes;
using Volo.Abp.Application.Dtos;

namespace NewsApp.ArticlesOrThemes.Themes
{
    public class ThemeDto : ArticleOrThemeDto
    {
        public string Name { get; set; }
        public AlertThemeDto? AlertTheme { get; set; }
        public ICollection<string> KeyWords { get; set; }
        public Guid UserId { get; set; }
        public ICollection<ArticleOrThemeDto> ArticlesOrThemes { get; set; }
    }
}