using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using NewsApp.Alerts.AlertsThemes;
using NewsApp.Articles;
using NewsApp.KeyWords;


namespace NewsApp.Themes
{
    public class ThemeDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        // relaciones
        public ICollection<KeyWordDto>? KeyWords { get; set; } // palabras clave relacionadas al tema
        public ICollection<ThemeDto>? Themes { get; set; } // Lista de temas guardados en este tema
        public ICollection<ArticleDto>? Articles { get; set; } // Lista de noticias guardadas en este tema
        public ThemeDto? ParentTheme { get; set; } // Tema padre al cual este tema pertenece
        public AlertThemeDto? AlertTheme { get; set; }
        public Guid UserId { get; set; }
    }
}