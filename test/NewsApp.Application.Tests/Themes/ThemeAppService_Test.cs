using Volo.Abp.Domain.Repositories;
using NewsApp.Themes;
using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;
using NSubstitute;
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
            // Arrange
            var themeCount = 3;
            var createdThemes = new List<ThemeDto>();

            for (int i = 0; i < themeCount; i++)
            {
                var themeToAdd = new CreateUpdateThemeDto
                {
                    // Set the properties of the theme as needed
                    Name = $"Theme{i + 1}",
                    KeyWordsToAdd = new List<string> { $"Keyword{i + 1}_1", $"Keyword{i + 1}_2" },
                    UserId = Guid.NewGuid() // or set the user ID as needed
                };

                var addedTheme = await _themeAppService.CreateThemeAsync(themeToAdd);
                createdThemes.Add(addedTheme);
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
                // Initialize the theme properties as needed
                // For example, Name, Description, etc.
            };

            var addedTheme = await _themeAppService.CreateThemeAsync(themeToAdd);

            // Act
            await _themeAppService.DeleteThemeAsync(addedTheme.Id);

            // Assert
            // Verify that the theme has been deleted from the repository
            var deletedTheme = await _themeAppService.GetThemesAsync(addedTheme.Id);
            deletedTheme.ShouldBeNull();
        }
    }
}