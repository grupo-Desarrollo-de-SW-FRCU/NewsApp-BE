using NewsApp.Sources;
using NewsApp.Themes;
using NewsApp.Users;
using System;
using System.ComponentModel.DataAnnotations;

namespace NewsApp.ArticlesOrThemes.Articles
{
    public class CreateUpdateArticleDto
    {
        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string Url { get; set; }
        [Required]
        [StringLength(100)]
        public string? UrlToImage { get; set; }

        [Required]
        public Language? Language { get; set; }

        [Required]
        public DateTime PublishedAt { get; set; }

        [Required]
        public string Content { get; set; }

        public SourceDto Source { get; set; }

        [Required]
        public ThemeDto Theme { get; set; } // Tema en el cual el articulo fue guardado
    }
}
