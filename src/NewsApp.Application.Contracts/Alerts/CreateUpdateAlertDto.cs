using Abp.Authorization.Users;
using NewsApp.Searchs;
using System;
using System.ComponentModel.DataAnnotations;

namespace NewsApp.Alerts
{ 
public class CreateUpdateAlertDto
{

        [Required]
        public bool Active { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string SearchText { get; set; }
        [Required]
        public AbpUserBase User { get; set; }
        [Required]
        public SearchDto Search { get; set; }
        [Required]
        public Guid SearchOfAlertId { get; set; }
        [Required]
        public string Name { get; set; }
}
}