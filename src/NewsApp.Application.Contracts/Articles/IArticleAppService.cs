using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Articles
{
    //definir metodos para Articulo DTO
    public interface IArticleAppService:
    
       ICrudAppService<ArticleDto,
           Guid,
           PagedAndSortedResultRequestDto,
           CreateUpdateArticleDto>
    { 
    }
        
}
