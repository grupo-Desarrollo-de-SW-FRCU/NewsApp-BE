using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;
using Volo.Abp.Domain.Repositories;
using NewsApp.KeyWords;
using Volo.Abp.EntityFrameworkCore;
using NewsApp.EntityFrameworkCore;
using Volo.Abp.Uow;


namespace NewsApp.Themes
{
    public class ThemeAppService_Test : NewsAppApplicationTestBase
    {
        private readonly IThemeAppService _themeAppService;
        private readonly IRepository<Theme, Guid> _themeRepository;
        private readonly IRepository<KeyWord, Guid> _keyWordRepository;
        private readonly IDbContextProvider<NewsAppDbContext> _dbContextProvider;
        private readonly IUnitOfWorkManager _unitOfWorkManager;


        public ThemeAppService_Test()
        {
            _themeAppService = GetRequiredService<IThemeAppService>();
            _themeRepository = GetRequiredService<IRepository<Theme, Guid>>();
            _keyWordRepository = GetRequiredService<IRepository<KeyWord, Guid>>();
            _dbContextProvider = GetRequiredService<IDbContextProvider<NewsAppDbContext>>();
            _unitOfWorkManager = GetRequiredService<IUnitOfWorkManager>();
        }

        [Fact]
        public async Task Should_Get_All_Themes()
        {
            // Arrange
            var themeCount = 3;

            for (int i = 0; i < themeCount; i++)
            {
                var name = $"Theme{i + 1}";
                var userId = Guid.NewGuid();
                var themeToAdd = new Theme(userId, name, null);

                var keyword1 = new KeyWord($"Keyword{i + 1}_1", themeToAdd.Id); // como asocio una KeyWord a un Tema?
                var keyword2 = new KeyWord($"Keyword{i + 1}_2", themeToAdd.Id);

                await _keyWordRepository.InsertAsync(keyword1);
                await _keyWordRepository.InsertAsync(keyword2);

                await _themeRepository.InsertAsync(themeToAdd);
            }

            // Act
            var themes = await _themeAppService.GetThemesAsync();

            // Assert
            themes.ShouldNotBeNull();
            themes.Count.ShouldBe(themeCount);
        }

        [Fact]
        public async Task Should_Delete_A_Theme()
        {

            var name = "Theme";
            var userId = Guid.NewGuid();
            var themeToAdd = new Theme(userId, name, null); // debería crear un CreateUpdateThemeDto y luego convertirlo a Theme?

            var keyword1 = new KeyWord("Keyword_1", themeToAdd.Id);
            var keyword2 = new KeyWord("Keyword_2", themeToAdd.Id);

            await _keyWordRepository.InsertAsync(keyword1); // como asocio una KeyWord a un Tema?
            await _keyWordRepository.InsertAsync(keyword2);

            await _themeRepository.InsertAsync(themeToAdd);

            var addedTheme = await _themeRepository.InsertAsync(themeToAdd);

            // Act
            await _themeAppService.DeleteThemeAsync(addedTheme.Id);

            // Assert
            // Verify that the theme has been deleted from the repository
            var deletedTheme = await _themeAppService.GetThemeAsync(addedTheme.Id);
            deletedTheme.ShouldBeNull();
        }
        
        [Fact]
        public async Task Should_Create_Theme()
        {
            // Arrange
            var input = new CreateUpdateThemeDto
            {
                Name = "Test Theme",
                UserId = Guid.NewGuid(),
                KeyWords = new List<KeyWordDto>
            {
                new KeyWordDto("Keyword1"),
                new KeyWordDto("Keyword2")
            }
            };

            // Act
            using (var uow = _unitOfWorkManager.Begin())
            {
                var dbContext = await _dbContextProvider.GetDbContextAsync();
                var themeDto = await _themeAppService.CreateThemeAsync(input);

                // Assert
                themeDto.ShouldNotBeNull();
                themeDto.Name.ShouldBe(input.Name);
                themeDto.UserId.ShouldBe(input.UserId);
                themeDto.KeyWords.ShouldNotBeNull();
                themeDto.KeyWords.Count.ShouldBe(input.KeyWords.Count);

                // Additional assertions based on your application logic
                // ...

                await uow.CompleteAsync();
            }
        }
    }
}