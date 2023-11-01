using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using static NewsApp.Articles.ArticleAppService;


namespace NewsApp.Articles;



    //CONSTRUCTOR


    public class ArticleAppService : NewsAppAppService, IArticleAppService
    {

        public ArticleAppService()
        {
        }

        public async Task<string> GetArticleAsync(string stringSearch, string language, string orderFilter, int amountNews) //chequear en app service
    {

        var handler = new HandlerNewsAPI();//constructor
        var news = await handler.getNews(stringSearch, language, orderFilter, amountNews);//conexion con la api


        return news;

    }
}