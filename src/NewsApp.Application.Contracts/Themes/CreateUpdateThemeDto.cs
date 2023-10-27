﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NewsApp.Alerts.AlertsThemes;
using NewsApp.Articles;

namespace NewsApp.Themes
{
    public class CreateUpdateThemeDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        public ICollection<string> KeyWords { get; set; } // palabras clave relacionadas al tema

        // relaciones
        public ICollection<ThemeDto>? Themes { get; set; } // Lista de temas guardados en este tema
        public ICollection<ArticleDto>? Articles { get; set; } // Lista de noticias guardadas en este tema
        public ThemeDto? ParentTheme { get; set; } // Tema padre al cual este tema pertenece
        public AlertThemeDto? AlertTheme { get; set; }
        public Guid UserId { get; set; }
    }
}
