﻿using NewsApp.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Articles
{
    public class NewsAppService : NewsAppAppService, IArticleAppService
    {
        private readonly INewsService _newsService;

        public ArticleAppService(INewsService newsService)
        {
            _newsService = newsService;
        }
        public async Task<ICollection<NewsDto>> Search(string query)
        {
            var news = await _newsService.GetNewsAsync(query);

            return ObjectMapper.Map<ICollection<ArticleDto>, ICollection<NewsDto>>(news);
        }
    }
}