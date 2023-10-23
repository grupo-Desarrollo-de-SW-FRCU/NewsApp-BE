using System;
using System.Collections.Generic;
using System.Text;
using Abp.Authorization.Users;
using Volo.Abp.Application.Dtos;
using NewsApp.Searchs;

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
