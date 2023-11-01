using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using NewsApp.Articles;
using static Castle.MicroKernel.ModelBuilder.Descriptors.InterceptorDescriptor;

namespace NewsApp.Themes
{
    public interface IThemeAppService :
        ICrudAppService< //Defines CRUD methods
        ThemeDto, //Used to show books
        Guid, //Primary key of the book entity
        CreateUpdateThemeDto> //Used to create/update a book
    {
        Task AddTheme(Guid id, ThemeDto otherTheme);

        Task RemoveTheme(Guid themeId, Guid themeToRemoveId);

        Task AddArticle(Guid id, ArticleDto article);

        Task RemoveArticle(Guid themeId, Guid articleToRemoveId);
    }
}
