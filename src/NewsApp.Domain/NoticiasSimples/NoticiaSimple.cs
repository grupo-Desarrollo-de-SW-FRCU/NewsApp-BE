using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.NoticiasSimples
{
    internal class NoticiaSimple : Entity<Guid>
    {
        public string idioma {  get; set; }
    }
}
