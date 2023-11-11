﻿using System;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Articles;

public interface IArticleAppService :
    ICrudAppService< //Defines CRUD methods
        ArticleDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateArticleDto> //Used to create/update a book
{

}