﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Themes;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Articles // Clase componente del patrón composite
{
    public abstract class ArticleOrTheme : Entity<Guid>
    {
        public Theme? Theme { get; set; } // Tema al que pertenece la noticia o tema
        public Guid ThemeOfArticleOrThemeId { get; set; }
    }
}
