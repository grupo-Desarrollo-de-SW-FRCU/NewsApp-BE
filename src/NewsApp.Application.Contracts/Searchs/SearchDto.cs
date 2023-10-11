using System;
using System.Collections.Generic;
using NewsApp.Errors;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Searchs
{
    public class SearchDto : EntityDto<Guid>
    {
        public string Cadena_Buscada { get; set; }
        public string Nombre_Usuario { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public int Cantidad_Resultados { get; set; }
        public DateTime Fecha_Fin { get; set; }

       // public Error Error { get; set; }
    }
}
