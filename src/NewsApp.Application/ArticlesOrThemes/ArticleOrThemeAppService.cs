using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;

namespace NewsApp.ArticlesOrThemes
{
    public class ArticleOrThemeAppService :
    CrudAppService<
        ArticleOrTheme, //The Book entity
        ArticleOrThemeDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateArticleOrThemeDto>, //Used to create/update a book
    IArticleOrThemeAppService
    {
    }
}
