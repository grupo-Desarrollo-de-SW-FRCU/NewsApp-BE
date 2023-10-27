using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NewsApp.Searches;

namespace NewsApp.Alerts.AlertsSearches
{
    public class CreateUpdateAlertSearchDto : CreateUpdateAlertDto
    {
        [Required]
        public SearchDto Search { get; set; }
        [Required]
        public Guid SearchOfAlertId { get; set; }
    }
}
