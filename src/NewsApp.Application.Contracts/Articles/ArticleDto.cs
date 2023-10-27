using Abp.Application.Services.Dto;
using NewsApp.Themes;
using NewsApp.Users;
using System;


namespace NewsApp.Articles
{
    public class ArticleDto : EntityDto<Guid>
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string? UrlToImage { get; set; }
        public Language? Language { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }

        public string Source { get; set; }
        // relaciones

        public ThemeDto Theme { get; set; } // Tema en el cual el articulo fue guardado
    }
}
