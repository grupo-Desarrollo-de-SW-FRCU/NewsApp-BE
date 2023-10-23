using NewsApp.Sources;
using NewsApp.Users;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.ArticlesOrThemes.Articles
{
    public class ArticleDto : ArticleOrThemeDto
    {
        public SourceDto Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string? UrlToImage { get; set; }
        public Language? Language { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
    }
}
