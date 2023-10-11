using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Fuentes
{
    public class Fuente : Entity<Guid>
    {
        public string Nombre { get; set; }
    } //aaaaa
}
