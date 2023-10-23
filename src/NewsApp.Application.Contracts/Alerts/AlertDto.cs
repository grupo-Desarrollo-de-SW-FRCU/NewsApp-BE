using System;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Alerts
{
    public class AlertDto : EntityDto<Guid>
    {
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SearchText { get; set; }
        public Guid UserId { get; set; }
    }
}
