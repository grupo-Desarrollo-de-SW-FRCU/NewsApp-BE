using System;
using Abp.Application.Services;
using Abp.Domain.Repositories;
namespace NewsApp.Articles;

public class ArticleAppService : CrudAppService<Article, ArticleDto, Guid>, IArticleAppService
{
    public ArticleAppService(IRepository<Article, Guid> repository)
        : base(repository)
    {

    }
}