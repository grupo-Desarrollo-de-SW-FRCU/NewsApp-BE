using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Noticias
{
    public class NoticiaDto : EntityDto<Guid>
    {
        public string Nombre { get; set; }
    }
}
