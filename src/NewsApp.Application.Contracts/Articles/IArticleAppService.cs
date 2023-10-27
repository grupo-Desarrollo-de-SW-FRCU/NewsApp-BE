using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewsApp.ArticlesOrThemes;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Articles
{
    //definir metodos para Articulo DTO
    public interface IArticleAppService
    {
        Task<string> GetArticleAsync(string Language, int amountNews); //define metodo que debe resolver la implementacion 
        //La tarea devuelve una coleccion de ArticleDto
        // async: asincronico -> termina de ejecutarse y devuelven el control al subproceso




    }
}
