﻿using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;
using Volo.Abp.Domain.Repositories;
using NewsApp.KeyWords;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace NewsApp.Themes
{
    public class ThemeAppService_Test : NewsAppApplicationTestBase
    {
        private readonly IThemeAppService _themeAppService;
        private readonly IRepository<Theme, Guid> _themeRepository;

        public ThemeAppService_Test()
        {
            _themeAppService = GetRequiredService<IThemeAppService>();
            _themeRepository = GetRequiredService<IRepository<Theme, Guid>>();
        }

        [Fact]
        public async Task Should_Get_All_Themes()
        {
            // Arrange
            var themeCount = 3;

            for (int i = 0; i < themeCount; i++)
            {
                var keyword1 = new KeyWordDto($"Keyword{i + 1}_1");
                var keyword2 = new KeyWordDto($"Keyword{i + 1}_2");

                var themeToAdd = new CreateUpdateThemeDto
                {
                    Name = $"Theme{i + 1}",
                    KeyWords = new List<KeyWordDto> { keyword1, keyword2},
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
            var keyword1 = new KeyWordDto("Keyword_1");
            var keyword2 = new KeyWordDto("Keyword_2");

            var themeToAdd = new CreateUpdateThemeDto // debería crear un ThemeDto y luego convertirlo a CreateUpdateThemeDto?, el problema es que me da error al hacerlo
            {
                Name = "Theme",
                KeyWords = new List<KeyWordDto> { keyword1, keyword2 },
                UserId = Guid.NewGuid()
            };

            var addedTheme = await _themeAppService.CreateThemeAsync(themeToAdd);

            // Act
            await _themeAppService.DeleteThemeAsync(addedTheme.Id);

            // Assert
            // Verify that the theme has been deleted from the repository
            var deletedTheme = await _themeAppService.GetThemeAsync(addedTheme.Id);
            deletedTheme.ShouldBeNull();
        }

        [Fact]
        public async Task Should_Create_New_Theme()
        {
            // Arrange
            var keyword1 = new KeyWordDto("Keyword_1");
            var keyword2 = new KeyWordDto("Keyword_2");

            var input = new CreateUpdateThemeDto
            {
                Name = "TestTheme",
                KeyWords = new List<KeyWordDto> { keyword1, keyword2 },
                UserId = Guid.NewGuid()
            };

            // Act
            var createdTheme = await _themeAppService.CreateThemeAsync(input);

            // Assert
            createdTheme.ShouldNotBeNull();
            createdTheme.Name.ShouldBe("TestTheme");
            createdTheme.KeyWords.ShouldContain(kw => kw.Keyword == "Keyword_1");
            createdTheme.KeyWords.ShouldContain(kw => kw.Keyword == "Keyword_2");

            // Verify that the theme has been added to the repository
            var retrievedTheme = await _themeRepository.GetAsync(createdTheme.Id); // includeDetails: true
            retrievedTheme.ShouldNotBeNull();
            retrievedTheme.Name.ShouldBe("TestTheme");
            retrievedTheme.KeyWords.ShouldContain(kw => kw.Keyword == "Keyword_1");
            retrievedTheme.KeyWords.ShouldContain(kw => kw.Keyword == "Keyword_2");
        }
    }
}