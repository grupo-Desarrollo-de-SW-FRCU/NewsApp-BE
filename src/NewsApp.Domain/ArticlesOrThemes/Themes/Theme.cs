using System;
using System.Collections.Generic;
using Abp;
using Abp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using NewsApp.Alerts;
using NewsApp.ArticlesOrThemes;

namespace NewsApp.Themes
{
    public class Theme : Entity<Guid>
    {
        public string Name { get; set; }
        public AlertTheme? AlertTheme { get; set; }
        public ICollection<string> KeyWords { get; set; }
        public IdentityUser User { get; set; }
        public ICollection<ArticleOrTheme> ArticlesOrThemes { get; set; } // modelar la composición
    
        public Theme(
            string name,
            AlertTheme? alertTheme,
            ICollection<string> keyWords,
            IdentityUser user,
            ICollection<ArticleOrTheme> articlesOrThemes
            )
        {
            Name = Check.NotNull(name,nameof(name));
            AlertTheme = alertTheme;
            KeyWords = keyWords;
            User = user;
            ArticlesOrThemes = articlesOrThemes;
        }
    }
}

