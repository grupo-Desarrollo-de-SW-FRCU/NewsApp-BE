using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using NewsApp.Alerts.AlertsThemes;
using NewsApp.ArticlesOrThemes;

namespace NewsApp.Themes
{
    public class ThemeDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public AlertThemeDto? AlertTheme { get; set; }
        public ICollection<string> KeyWords { get; set; }
        public Guid UserId { get; set; }
        public ICollection<ArticleOrThemeDto> ArticlesOrThemes { get; set; }
    }
}