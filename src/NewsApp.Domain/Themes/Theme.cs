using System;
using System.Collections.Generic;
using Abp;
using Abp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using NewsApp.Alerts;
using NewsApp.Articles;

namespace NewsApp.Themes
{
    public class Theme : Entity<Guid>
    {
        public string Name { get; set; }
        public ICollection<string> KeyWords { get; set; } // palabras clave relacionadas al tema

        // relaciones
        public ICollection<Theme>? Themes { get; set; } // Lista de temas guardados en este tema
        public ICollection<Article>? Articles { get; set; } // Lista de noticias guardadas en este tema
        public Theme? ParentTheme { get; set; } // Tema padre al cual este tema pertenece
        public AlertTheme? AlertTheme { get; set; }
        public IdentityUser User { get; set; }

        // constructor
       /* public Theme(
            string name,
            AlertTheme? alertTheme,
            ICollection<string> keyWords,
            IdentityUser user,
            ICollection<Theme>? themes,
            ICollection<Article>? articles,
            Theme? parentTheme
            )
        {
            Name = Check.NotNull(name, nameof(name));
            AlertTheme = alertTheme;
            KeyWords = keyWords;
            User = user;
            Themes = new List<Theme>();
            Articles = new List<Article>();
            ParentTheme = parentTheme;
        }*/
    }
}

