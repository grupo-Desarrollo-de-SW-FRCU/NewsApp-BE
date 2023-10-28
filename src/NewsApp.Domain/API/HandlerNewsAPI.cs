using System;
using System.Text.Json;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System.Threading.Tasks;

public class HandlerNewsAPI : INewsAPI
{
    NewsApiClient newsApiClient;

    public HandlerNewsAPI()
    {
        newsApiClient = new NewsApiClient("34223fc9494d461385d9098b1bcf960a"); //APIKEY
    }

    public async Task<string> getNews(string stringSearch, string LanguageIntCode, string orderFilter, int? amountNews)
    {
        if (Enum.TryParse(LanguageIntCode, out Languages selectedLanguage))
        {
            if (Enum.TryParse(orderFilter, out SortBys selectedFilter))
            {

                var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
                {
                    Q = stringSearch ?? "news", // CADENA DE BUSQUEDA
                    SortBy = selectedFilter,//IDEM SELECTED LENGUAGE PERO CON LA CLASE SORTBYS
                    Language = selectedLanguage, // PARA SABER QUE INT CORRESPONDE IR A LA CLASE LENGUAGES DEJAR EL MOUSE SOBRE EL LENGUAJE DESEADO Y LEER EL CODIGO
                    From = GetDateMonthAgoFromNow(), // deberia obtener un DateTime un mes atras cada vez
                    Page = 1,
                    PageSize = amountNews ?? 20 // SI ES NULL -> VALOR DEFAUL
                });

                if (articlesResponse.Status == Statuses.Ok)
                {
                    return JsonSerializer.Serialize(articlesResponse.Articles);
                }

                throw new Exception("La solicitud de la API no fue exitosa. Status: " + articlesResponse.Status);
            }
            else
            { throw new Exception($"El criterio de orden no es valido ({orderFilter})"); }
        }
        else 
        { throw new Exception($"El lenguaje seleccionado no es valido ({LanguageIntCode}) ."); }

    }

    // un metodo que devuelva una fecha  de 1 mes hcia atras desde el dia actual
    private DateTime GetDateMonthAgoFromNow()
    {
        DateTime date = DateTime.Now;
        date = date.AddMonths(-1);
        return date;
    }
}