using System;
using Abp.Application.Services;
using Abp.Domain.Repositories;
namespace NewsApp.Articles;

public class ArticleAppService : NewslifyAppService, INewsAppService
{

    public ArticleAppService()
    {
    }

    public async Task<string> GetNewsAsync(string LanguageIntCode, int amountNews)
    {
        var newsAPI = new HandlerNewsAPI();
        string newsInJSON = await newsAPI.getNews(LanguageIntCode.ToUpper(), amountNews);// metodo que se conecte a la API y traiga las noticias

        return newsInJSON;
    }
}
}
