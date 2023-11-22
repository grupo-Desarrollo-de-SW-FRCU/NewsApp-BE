using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Articles;

/* ARTICULOS PARA GUARDAR EN LA BD   */
public interface IArticleAppService : IApplicationService
{
    Task<ArticleDto> SaveArticleAsync(CreateUpdateNewsDto input, int themeId);
}