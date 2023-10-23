using System;
using System.Collections.Generic;
using Abp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using NewsApp.Alerts;
using NewsApp.ArticlesOrThemes;

namespace NewsApp.Themes
{
    public class Theme : ArticleOrTheme
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public AlertTheme? AlertTheme { get; set; }
        public ICollection<string> KeyWords { get; set; }
        public IdentityUser User { get; set; }
        public ICollection<ArticleOrTheme> ArticlesOrThemes { get; set; } // modelar la composición

        public bool IsTransient()
        {
            throw new NotImplementedException();
        }
    }
}

    