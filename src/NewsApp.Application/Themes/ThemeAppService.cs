using System;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using NewsApp.ArticlesOrThemes.Themes;

namespace NewsApp.Themes;

public class ThemeAppService : CrudAppService<Theme, ThemeDto, Guid>, IThemeAppService
{
    public ThemeAppService(IRepository<Theme, Guid> repository)
        : base(repository)
    {

    }
}

