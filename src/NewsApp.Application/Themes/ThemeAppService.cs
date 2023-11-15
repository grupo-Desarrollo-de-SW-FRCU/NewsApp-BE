using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //var queryable = await _themeRepository.WithDetailsAsync(x => x.UserId);

            //var query = queryable.Where(x => x.Id == id);

            //var theme = await AsyncExecuter.FirstOrDefaultAsync(query);

            var theme = await _themeRepository.FindAsync(id);

            return ObjectMapper.Map<Theme, ThemeDto>(theme);
        }

        public async Task<ThemeDto> CreateThemeAsync(CreateUpdateThemeDto input)
        {
            var theme = new Theme
            {
                Name = input.Name,
                KeyWords = input.KeyWordsToAdd,    
                UserId = input.UserId,
            };

            theme = await _themeRepository.InsertAsync(theme);

            return ObjectMapper.Map<Theme, ThemeDto>(theme);
        }

        public async Task<ThemeDto> UpdateThemeAsync(Guid id, CreateUpdateThemeDto input)
        {
            var themeToUpdate = await _themeRepository.GetAsync(id);

            if (themeToUpdate != null)
            {
                // Actualizar el nombre del tema
                themeToUpdate.Name = input.Name;

                // Agregar nuevas palabras clave a la lista existente
                foreach (var keywordToAdd in input.KeyWordsToAdd)
                {
                    themeToUpdate.KeyWords.Add(keywordToAdd);
                }

                // Eliminar palabras clave que aparecen en la lista de palabras clave a eliminar
                foreach (var keywordToRemove in input.KeyWordsToRemove)
                {
                    themeToUpdate.KeyWords.Remove(keywordToRemove);
                }

                await _themeRepository.UpdateAsync(themeToUpdate);

                return ObjectMapper.Map<Theme, ThemeDto>(themeToUpdate);
            }
            else
            {
                // Manejar el caso en que el tema no se encuentre
                throw new ArgumentException($"Theme with id {id} not found.");
            }
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