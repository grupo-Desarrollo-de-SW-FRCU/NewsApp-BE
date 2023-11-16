using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsApp.KeyWords;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;
using static OpenIddict.Abstractions.OpenIddictConstants;

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

            // Create new instances of KeyWord for each KeyWordDto
            theme.KeyWords = input.KeyWords.Select(kwDto => new KeyWord(kwDto.Keyword)).ToList();

            theme = await _themeRepository.InsertAsync(theme);

            return ObjectMapper.Map<Theme, ThemeDto>(theme);
        }

        public async Task<ThemeDto> UpdateThemeAsync(Guid id, CreateUpdateThemeDto input)
        {
            // Get the existing theme from the repository
            var themeToUpdate = await _themeRepository.GetAsync(id);

            // Check if the theme exists
            if (themeToUpdate == null)
            {
                throw new ArgumentNullException(nameof(themeToUpdate));
            }

            // Update the properties of the existing theme
            themeToUpdate.Name = input.Name;

            // Remove existing KeyWords that are not in the updated list
            var keywordsToRemove = themeToUpdate.KeyWords
                .Where(existingKeyword => input.KeyWords.All(updatedKeyword => updatedKeyword.Keyword != existingKeyword.Keyword))
                .ToList();

            foreach (var keywordToRemove in keywordsToRemove)
            {
                themeToUpdate.KeyWords.Remove(keywordToRemove);
            }

            // Add new KeyWords that are not already in the existing list
            var keywordsToAdd = input.KeyWords
                .Where(updatedKeyword => themeToUpdate.KeyWords.All(existingKeyword => existingKeyword.Keyword != updatedKeyword.Keyword))
                .Select(updatedKeyword => new KeyWord(updatedKeyword.Keyword)) // Pass the keyword to the constructor
                .ToList();

            foreach (var keywordToAdd in keywordsToAdd)
            {
                // Ensure that you're adding new instances of KeyWord to avoid tracking issues
                themeToUpdate.KeyWords.Add(new KeyWord(keywordToAdd.Keyword));
            }

            // Save the changes to the repository
            await _themeRepository.UpdateAsync(themeToUpdate);

            // Map the updated theme to a ThemeDto and return it
            var updatedThemeDto = ObjectMapper.Map<Theme, ThemeDto>(themeToUpdate);
            return updatedThemeDto;
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
                throw new ArgumentException($"Theme with id {themeId} not found.");
            }
        }

    }
}