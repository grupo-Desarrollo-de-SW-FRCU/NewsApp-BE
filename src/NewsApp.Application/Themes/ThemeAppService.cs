using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
namespace NewsApp.Themes;

public class ThemeAppService : CrudAppService<Theme, ThemeDto, Guid, CreateUpdateThemeDto>, IThemeAppService
{
    private Abp.Domain.Repositories.IRepository<Theme, Guid> _repository;

    public ThemeAppService(Abp.Domain.Repositories.IRepository<Theme, Guid> repository)
            : base(repository)
    {
        _repository = repository;
    }

    public async Task AddTheme(Guid id, Theme otherTheme)
    {
        var theme = await _repository.GetAsync(id);
        theme.Themes.Add(otherTheme);
        _ = await _repository.UpdateAsync(theme);
    }

    public async Task RemoveTheme(Guid themeId, Guid themeToRemoveId)
    {
        var theme = await _repository.GetAsync(themeId);
        if (theme.Themes != null)
        {
            var themeToRemove = theme.Themes.FirstOrDefault(t => t.Id == themeToRemoveId);
            if (themeToRemove != null)
            {
                theme.Themes.Remove(themeToRemove);
                await _repository.UpdateAsync(theme);
            }
        }
    }

    public async Task AddArticle(Guid id, Article article)
    {
        var theme = await _repository.GetAsync(id);
        theme.Articles.Add(article);
        _ = await _repository.UpdateAsync(theme);
    }

    public async Task RemoveArticle(Guid themeId, Guid articleToRemoveId)
    {
        var theme = await _repository.GetAsync(themeId);
        if (theme.Articles != null)
        {
            var articleToRemove = theme.Articles.FirstOrDefault(t => t.Id == articleToRemoveId);
            if (articleToRemove != null)
            {
                theme.Articles.Remove(articleToRemove);
                await _repository.UpdateAsync(theme);
            }
        }
    }
}

