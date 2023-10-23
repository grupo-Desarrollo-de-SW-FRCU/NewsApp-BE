using Abp.Domain.Entities;
using NewsApp.ArticlesOrThemes;
using NewsApp.Language;
using NewsApp.Sources;
using System;

namespace NewsApp.Articles
{
    public class Article : Entity<Guid>
    {
        public Source Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string? UrlToImage { get; set; }
        public LanguageOfArticle? Language { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
    }
}


