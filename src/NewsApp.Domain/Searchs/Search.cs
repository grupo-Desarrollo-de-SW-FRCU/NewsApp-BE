using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewsApp.Searchs
{
    public class Search : Entity<Guid>
    {
        public string Cadena_Buscada {  get; set; }
        public string Nombre_Usuario { get; set; }
        public DateTime Fecha_Inicio {  get; set; }
        public int Cantidad_Resultados { get; set; }
        public DateTime Fecha_Fin {  get; set; }

        public Error? Error { get; set; }
    }
}
