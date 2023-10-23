using System;
using System.Collections.Generic;
using System.Text;
using Abp.Authorization.Users;
using NewsApp.Alerts;
using NewsApp.Alerts.AlertsThemes;
using Volo.Abp.Application.Dtos;

namespace NewsApp.ArticlesOrThemes.Themes
{
    public class ThemeDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public AlertThemeDto? AlertTheme { get; set; }
        public ICollection<string> KeyWords { get; set; }
        public required Guid UserId { get; set; }
        public ICollection<ArticleOrThemeDto> ArticlesOrThemes { get; set; }
    }
}