using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Themes
{
    public class ThemeDto : EntityDto<Guid>
    {
        public int Name { get; set; }
    }
}