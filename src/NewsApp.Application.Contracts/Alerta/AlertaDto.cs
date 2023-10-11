using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Alertas
{
    public class AlertaDto : EntityDto<Guid>
    {
            public bool Activa { get; set; }
            public DateTime Fecha_creada { get; set; }
            public string Texto_busqueda { get; set; }
    }
}
