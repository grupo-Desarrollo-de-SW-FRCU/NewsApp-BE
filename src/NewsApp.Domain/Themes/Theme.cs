using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Microsoft.AspNetCore.Identity;
using NewsApp.Alerts;
using NewsApp.Articles;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Themes
{
    public class Theme : ArticleOrTheme
    {
        public string Name { get; set; }
        public Alert? Alert { get; set; }
        public required IdentityUser User { get; set; }
        public ICollection<ArticleOrTheme> ArticlesOrThemes { get; set; } // modelar la composición
    }
}

    