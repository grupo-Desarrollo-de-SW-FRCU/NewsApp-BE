using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Articles;

public class ArticleAppService :
    CrudAppService<
        Article, //The Book entity
        ArticleDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateArticleDto>, //Used to create/update a book
    IArticleAppService //implement the IBookAppService
{
    public ArticleAppService(IRepository<Article, Guid> repository)
        : base(repository)
    {

    }
}