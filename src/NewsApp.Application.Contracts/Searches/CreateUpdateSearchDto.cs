using Abp.Authorization.Users;
using System;
using System.ComponentModel.DataAnnotations;
using NewsApp.Alerts;
using NewsApp.Failures;
using System.Collections.Generic;
using NewsApp.Articles;

namespace NewsApp.Searchs
{
    public class CreateUpdateSearchDto
    {

        [Required]
        [StringLength(200)]
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