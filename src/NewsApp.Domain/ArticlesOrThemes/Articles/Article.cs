﻿using NewsApp.ArticlesOrThemes;
using NewsApp.Sources;
using NewsApp.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Articles 
{
    public class Article : ArticleOrTheme
    {
        public Source Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string? UrlToImage { get; set; }
        public Language? Language { get; set; }
        public DateTime PublishedAt {get; set; }
        public string Content { get; set; }
    }
}


