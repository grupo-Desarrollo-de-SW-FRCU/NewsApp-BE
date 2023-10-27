using Abp.Domain.Entities;
using NewsApp.Sources;
using NewsApp.Themes;
using NewsApp.Users;
using System;

namespace NewsApp.Articles
{
    public class Article : Entity<Guid>
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string? UrlToImage { get; set; }
        public Language? Language { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }

        // relaciones
        public Source? Source { get; set; }
        public Theme Theme { get; set; } // Tema en el cual el articulo fue guardado

        // constructor
        public Article(
            string author
            , string title
            , string description
            , string url
            , string? urlToImage
            , Language? language
            , DateTime publishedAt
            , string content
            , Source source
            )
        {
            Author = author;
            Title = title;
            Description = description;
            Url = url;
            UrlToImage = urlToImage;
            Language = language;
            PublishedAt = publishedAt;
            Content = content;
            Source = source;
        }
    }
}


