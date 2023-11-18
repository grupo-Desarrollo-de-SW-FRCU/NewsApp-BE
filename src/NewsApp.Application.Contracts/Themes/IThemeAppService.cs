using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Themes
{
    public interface IThemeAppService : IApplicationService
    {
        Task<ICollection<ThemeDto>> GetThemesAsync();

        Task<ThemeDto> GetThemeAsync(int id);

        Task<ThemeDto> CreateUpdateThemeAsync(CreateUpdateThemeDto input);

        // Task<ThemeDto> AddKeywordsAsync(Guid id, ICollection<string> newKeywords);

        Task DeleteThemeAsync(int themeId);
    }
}
