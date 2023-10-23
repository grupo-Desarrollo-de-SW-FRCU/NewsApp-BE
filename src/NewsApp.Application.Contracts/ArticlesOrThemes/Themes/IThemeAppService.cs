using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Volo.Abp.Application.Services;

namespace NewsApp.ArticlesOrThemes.Themes
{
    public interface IThemeAppService : CrudAppService<Theme, themeDto, Guid>, IArticleOrThemeAppService
    {

    }
}
