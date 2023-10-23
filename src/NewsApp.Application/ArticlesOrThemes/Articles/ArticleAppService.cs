using System;
using NewsApp.Articles;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.ArticlesOrThemes.Articles;

public class ArticleAppService : ArticleOrThemeAppService
{
    public ArticleAppService(IRepository<Article, Guid> repository)
        : base(repository)
    {

    }
}