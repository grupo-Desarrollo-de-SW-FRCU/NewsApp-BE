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

        Task<ThemeDto> GetThemeAsync(Guid id);

        Task<ThemeDto> CreateThemeAsync(CreateUpdateThemeDto input);

        Task<ThemeDto> UpdateThemeAsync(Guid id, CreateUpdateThemeDto input);

        Task DeleteThemeAsync(Guid themeId);
    }
}
