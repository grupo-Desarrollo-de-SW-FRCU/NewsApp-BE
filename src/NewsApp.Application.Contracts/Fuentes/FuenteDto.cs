﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Fuentes
{
    public class FuenteDto : EntityDto<Guid>
    {
        public string Nombre {  get; set; }
    }
}
