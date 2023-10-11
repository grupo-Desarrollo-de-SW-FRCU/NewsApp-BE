using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Reads
{
    public class Read : Entity<Guid>
    { //Fecha y hora lectura, likeada, 
        public DateTime FechaHora {get; set;}
        public bool Likeada { get; set; }
      
    }
}

