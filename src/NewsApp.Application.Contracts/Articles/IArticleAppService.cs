using System;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Articles;

/* ARTICULOS PARA GUARDAR EN LA BD   */
public interface IArticleAppService :
    ICrudAppService< //Defines CRUD methods
        ArticleDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateArticleDto> //Used to create/update a book
{

}