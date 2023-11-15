using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;

namespace NewsApp.Themes
{
    public class ThemeAppService_Test : NewsAppApplicationTestBase
    {
        private readonly IThemeAppService _themeAppService;

        public ThemeAppService_Test()
        {
            _themeAppService = GetRequiredService<IThemeAppService>();
        }

        [Fact]
        public async Task Should_Get_All_Themes()
        {
            /*// Arrange
            var themeCount = 3;

            for (int i = 0; i < themeCount; i++)
            {
                var themeToAdd = new CreateUpdateThemeDto
                {
                    Name = $"Theme{i + 1}",
                    KeyWordsToAdd = new List<string> { $"Keyword{i + 1}_1", $"Keyword{i + 1}_2" },
                    UserId = Guid.NewGuid()
                };

                await _themeAppService.CreateThemeAsync(themeToAdd);
            }

            //Act
            var themes = await _themeAppService.GetThemesAsync();

            //Assert
            themes.ShouldNotBeNull();
            themes.Count.ShouldBeGreaterThan(1);
        }

        [Fact]
        public async Task Should_Delete_A_Theme()
        {
            // Arrange
            var themeToAdd = new CreateUpdateThemeDto // debería crear un ThemeDto y luego convertirlo a CreateUpdateThemeDto?, el problema es que me da error al hacerlo
            {
                Name = "Theme",
                KeyWordsToAdd = new List<string> { "Keyword_1", "Keyword_2" },
                UserId = Guid.NewGuid()
            };

            var addedTheme = await _themeAppService.CreateThemeAsync(themeToAdd);

            // Act
            await _themeAppService.DeleteThemeAsync(addedTheme.Id);

            // Assert
            // Verify that the theme has been deleted from the repository
            var deletedTheme = await _themeAppService.GetThemeAsync(addedTheme.Id);
            deletedTheme.ShouldBeNull();
        */
        }
    }
}