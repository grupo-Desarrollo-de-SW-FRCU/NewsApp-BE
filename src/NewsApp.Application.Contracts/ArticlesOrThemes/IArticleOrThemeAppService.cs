using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace NewsApp.ArticlesOrThemes
{
    public interface IArticleOrThemeAppService : ICrudAppService<ArticleOrThemeDto, Guid>
    {
    }
}
