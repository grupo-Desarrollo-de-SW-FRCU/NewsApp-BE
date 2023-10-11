using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Sources
{
    public class SourceDto : EntityDto<Guid>
    {
        public string Name {  get; set; }
    }
}
