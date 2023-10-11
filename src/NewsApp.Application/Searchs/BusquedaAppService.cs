using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Searchs
{
    public class BusquedaAppService : CrudAppService<Search,SearchDto,Guid>,ISearchAppService 
    {
        public BusquedaAppService(IRepository<Search, Guid> repository) //hola
            : base(repository) 
        {

        }
    }
}
