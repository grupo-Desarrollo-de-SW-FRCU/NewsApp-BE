using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Reads
{
    public class ReadDto : EntityDto<Guid>
    {
        public DateTime ReadDateTime { get; set; }
        public bool Liked { get; set; }
    }
}
