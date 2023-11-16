using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NewsApp.Alerts.AlertsThemes;
using NewsApp.Articles;
using NewsApp.KeyWords;

namespace NewsApp.Themes
{
    public class CreateUpdateThemeDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        //public ICollection<string> KeyWordsToAdd { get; set; } // palabras clave a añadir al tema
        //public ICollection<string> KeyWordsToRemove { get; set; } // palabras clave para eliminar del tema

        // relaciones
        public ICollection<KeyWordDto>? KeyWords { get; set; } // palabras clave
        public ICollection<ThemeDto>? Themes { get; set; } // Lista de temas guardados en este tema
        public ICollection<ArticleDto>? Articles { get; set; } // Lista de noticias guardadas en este tema
        public ThemeDto? ParentTheme { get; set; } // Tema padre al cual este tema pertenece
        public AlertThemeDto? AlertTheme { get; set; }
        public Guid UserId { get; set; }
    }
}
