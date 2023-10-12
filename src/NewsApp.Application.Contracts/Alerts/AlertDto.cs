using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Alerts
{
    public class AlertDto : EntityDto<Guid>
    {
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SearchText { get; set; }
    }
}
