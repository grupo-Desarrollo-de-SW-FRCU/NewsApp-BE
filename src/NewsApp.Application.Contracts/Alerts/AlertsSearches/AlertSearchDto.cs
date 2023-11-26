using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using NewsApp.Notifications;
using NewsApp.Searches;
using NewsApp.Users;

namespace NewsApp.Alerts.AlertsSearches
{
    public class AlertSearchDto : EntityDto<int>
    {
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        //public string SearchText { get; set; }
        public ICollection<NotificationDto> Notification { get; set; }
        public UserDto User { get; set; }
        public SearchDto Search { get; set; }
        public Guid SearchOfAlertId { get; set; }
    }
}
