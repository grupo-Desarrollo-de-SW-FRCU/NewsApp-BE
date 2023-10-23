using System;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Services;
using NewsApp.Themes;
using NewsApp.Articles;

namespace NewsApp.ArticlesOrThemes.Themes;

public class ThemeAppService : CrudAppService<Theme,ThemeDto, Guid>, IThemeAppService
{
    public ThemeAppService(IRepository<Theme, Guid> repository)
        : base(repository)
    {

    }
}

