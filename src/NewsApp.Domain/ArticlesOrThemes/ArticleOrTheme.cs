using System;
using NewsApp.Themes;
using Volo.Abp.Domain.Entities;

namespace NewsApp.ArticlesOrThemes // Clase componente del patrón composite
{
    public abstract class ArticleOrTheme : Entity<Guid>
    {
        public Theme? Theme { get; set; } // Tema al que pertenece la noticia o tema
        public Guid ThemeOfArticleOrThemeId { get; set; } // Id del Theme al cual el ArticleOrTheme pertenece
    }
}
