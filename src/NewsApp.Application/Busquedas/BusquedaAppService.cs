using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Busquedas
{
    public class BusquedaAppService : CrudAppService<Busqueda,BusquedaDto,Guid>,IBusquedaAppService 
    {
        public BusquedaAppService(IRepository<Busqueda, Guid> repository) //hola
            : base(repository) 
        {

        }
    }
}
