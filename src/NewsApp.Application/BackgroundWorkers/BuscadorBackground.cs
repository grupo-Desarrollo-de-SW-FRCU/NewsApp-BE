using Volo.Abp.BackgroundWorkers;
using Volo.Abp.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewsApp.News;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using Abp.Threading.Timers;
/*
public class BuscadorBackground : AsyncPeriodicBackgroundWorkerBase
{

    private List<string> _palabrasClaves;
    private INewsService _newsService;
    

    public BuscadorBackground(
    Volo.Abp.Threading.AbpAsyncTimer timer,
    IServiceScopeFactory serviceScopeFactory,
    List<string> palabrasClave,
    INewsService newsService) : base(
        timer,
        serviceScopeFactory)
{
    Timer.Period = 600000; // 10 minutos

    
}


    protected override async Task DoWorkAsync(PeriodicBackgroundWorkerContext workerContext)
    {
        foreach (var palabraClave in _palabrasClaves)
        {
            await ConsultarApiAsync(palabraClave);

        }
    }

        private async Task ConsultarApiAsync(string palabraClave)
        {
            try
            {
                
                var resultadoBusqueda = await _newsService.GetNewsAsync(palabraClave);            

                if (resultadoBusqueda.Count == 0)
                {
                     
                    Console.WriteLine($"Palabra clave '{palabraClave}' - Resultado: Not Found.");
                }
                else { Console.WriteLine($"Palabra clave '{palabraClave}' - Resultado: {resultadoBusqueda.Count} noticias encontradas."); }
                 
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error en la consulta a la API para la palabra clave '{palabraClave}': {ex.Message}");
            }
        }

    }*/
