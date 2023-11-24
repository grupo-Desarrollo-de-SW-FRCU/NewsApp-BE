﻿using NewsApp.Articles;
using NewsApp.Searches;
using NewsApp.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.News
{
    public class NewsAppService : NewsAppAppService, INewsAppService
    {
        private readonly ISearchAppService _searchAppService;
        private readonly INewsService _newsService;

        public NewsAppService(INewsService newsService, ISearchAppService searchAppService)
        {
            _newsService = newsService;
            _searchAppService = searchAppService;
        }
        public async Task<ICollection<NewsDto>> Search(string query)
        {
            //TODO: falta registrar los tiempos de acceso de la API
            var start = DateTime.Now;

            var news = await _newsService.GetNewsAsync(query);

            var end = DateTime.Now;

            var count = news.Count();

            await _searchAppService.SaveSearchAsync(query, start, end, count);
            
            return ObjectMapper.Map<ICollection<ArticleDto>, ICollection<NewsDto>>(news);
        }
    }
}