using Abp.Authorization.Users;
using NewsApp.Searchs;
using NewsApp.Notifications;
using System;
using System.ComponentModel.DataAnnotations;
using NewsApp.Ntofications;

namespace NewsApp.Alerts
{ 
public class CreateUpdateAlertDto
{

        [Required]
        public bool Active { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }


        //[Required]
        //[StringLength(200)]
        // public string SearchText { get; set; }
        

        //No me deja hacer la relacion por ser una interface
        [Required]        
        public NotificationDto? Notification { get; set; }  


        [Required]
        public AbpUserBase User { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
}
}