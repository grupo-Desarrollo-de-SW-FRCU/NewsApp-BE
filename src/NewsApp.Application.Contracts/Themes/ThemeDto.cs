using System;
using System.Collections.Generic;
using System.Text;
using Abp.Authorization.Users;
using NewsApp.Alerts;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Themes
{
    public class ThemeDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public AlertDto? Alert { get; set; }
        public AbpUserBase User { get; set; }
        // public ICollection<ArticleOrTheme> ArticlesOrThemes { get; set; } // hay que crear ArticleOrThemeDto
    }
}