using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewsApp.ArticlesOrThemes;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Articles
{
    //definir metodos para Articulo DTO
    public interface IArticleAppService : IArticleOrThemeAppService
    {
        Task <string> GetNewsAsync(string LanguageIntCode, int amountNews);

    }
}
