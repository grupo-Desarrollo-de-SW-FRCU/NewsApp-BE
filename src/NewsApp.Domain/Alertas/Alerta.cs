using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Alertas
{
    public class Alerta : Entity<Guid>
    {
        public bool Activa { get; set; }
        public DateTime Fecha_creada { get; set; }
        public string Texto_busqueda { get; set; }
}
}
