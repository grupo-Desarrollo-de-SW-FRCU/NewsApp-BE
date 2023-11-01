using System.Threading.Tasks;

namespace NewsApp.Articles
{
    //definir metodos para Articulo DTO
    public interface IArticleAppService
    {
        Task<string> GetArticleAsync(string stringSearch,string Language, string orderFilter, int amountNews); //define metodo que debe resolver la implementacion 
        //La tarea devuelve una coleccion de ArticleDto
        // async: asincronico -> termina de ejecutarse y devuelven el control al subproceso




    }
}
