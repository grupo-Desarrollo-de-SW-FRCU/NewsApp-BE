using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Reads
{
    public class ReadDto : AuditedEntityDto<Guid>
    {
        public DateTime FechaHora {get; set; }
        public bool Likeada {get; set; }
    }
}
