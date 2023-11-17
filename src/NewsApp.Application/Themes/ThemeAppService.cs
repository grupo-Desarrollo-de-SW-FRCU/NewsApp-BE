using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsApp.KeyWords;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Themes
{
    public class ThemeAppService : NewsAppAppService, IThemeAppService
    {
        private readonly IRepository<Theme, Guid> _themeRepository;

        public ThemeAppService(IRepository<Theme, Guid> themeRepository)
        {
            _themeRepository = themeRepository;
        }

        public async Task<ICollection<ThemeDto>> GetThemesAsync()
        {
            var themes = await _themeRepository.GetListAsync();

            return ObjectMapper.Map<ICollection<Theme>, ICollection<ThemeDto>>(themes);
        }

        public async Task<ThemeDto> GetThemeAsync(Guid id)
        {
            var queryable = await _themeRepository.WithDetailsAsync(x => x.UserId, y => y.KeyWords);

            var query = queryable.Where(x => x.Id == id);

            var theme = await AsyncExecuter.FirstOrDefaultAsync(query);

            // var theme = await _themeRepository.FindAsync(id);

            return ObjectMapper.Map<Theme, ThemeDto>(theme);
        }

        public async Task<ThemeDto> CreateThemeAsync(CreateUpdateThemeDto input)
        {
            var theme = new Theme
            {
                Name = input.Name,
                UserId = input.UserId,
            };

            theme = await _themeRepository.InsertAsync(theme);

            return ObjectMapper.Map<Theme, ThemeDto>(theme);
        }

        public async Task<ThemeDto> UpdateThemeNameAsync(Guid id, string newName)
        {
            // Get the existing theme from the repository
            var themeToUpdate = await _themeRepository.GetAsync(id);

            // Check if the theme exists
            if (themeToUpdate == null)
            {
                throw new ArgumentNullException(nameof(themeToUpdate));
            }

            // Update the properties of the existing theme
            themeToUpdate.Name = newName;

            // Save the changes to the repository
            await _themeRepository.UpdateAsync(themeToUpdate);

            // Map the updated theme to a ThemeDto and return it
            var updatedThemeDto = ObjectMapper.Map<Theme, ThemeDto>(themeToUpdate);
            return updatedThemeDto;
        }

        public async Task<ThemeDto> AddKeywordsAsync(Guid id, ICollection<string> newKeywords)
        {

            var themeToUpdate = await _themeRepository.GetAsync(id);
            if (themeToUpdate == null)
            {
                 throw new ArgumentNullException(nameof(themeToUpdate));
            }

            // Habria que ver que otros parametros recibe y hacer cosas de acuerdo a eso
            // Modificaciones....
            foreach (string keyword in newKeywords)
            {
                // await _repository.
                themeToUpdate.KeyWords.Add(new KeyWord(keyword));
            }

            var response = await _themeRepository.UpdateAsync(themeToUpdate);
            return ObjectMapper.Map<Theme, ThemeDto>(response);
        }

        public async Task DeleteThemeAsync(Guid themeId)
        {
            var theme = await _themeRepository.GetAsync(themeId);

            if (theme != null)
            {
                // Realizar lógica adicional antes de eliminar, si es necesario
                await _themeRepository.DeleteAsync(themeId);
            }
            else
            {
                throw new ArgumentException($"No se encontró un tema con id {themeId}.");
            }
        }

    }
}