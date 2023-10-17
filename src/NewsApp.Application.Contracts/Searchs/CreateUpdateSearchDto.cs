using Abp.Authorization.Users;
using System;
using System.ComponentModel.DataAnnotations;
using NewsApp.Articles;
using NewsApp.Alerts;
using NewsApp.Failures;
using System.Collections.Generic;

namespace NewsApp.Searchs
{
    public class CreateUpdateAlertDto
    {

        [Required]
        public string SearchString { get; set; }
        [Required]
        public DateTime StartDateTime { get; set; }
        [Required]
        public int ResultsAmount { get; set; }
        [Required]
        public DateTime EndDateTime { get; set; }
        [Required]
        public FailureDto? Failure { get; set; }
        [Required]

        public AlertDto? Alert { get; set; }
        [Required]

        public AbpUserBase User { get; set; }
        [Required]

        public ICollection<ArticleDto> Articles { get; set; }

    }
}