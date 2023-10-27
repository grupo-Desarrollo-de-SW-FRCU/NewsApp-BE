using System;
using System.Collections.Generic;
using NewsApp.Failures;
using Volo.Abp.Application.Dtos;
using Abp.Authorization.Users;
using NewsApp.Alerts;
using NewsApp.Articles;

namespace NewsApp.Searchs
{
    public class SearchDto : EntityDto<Guid>
    {
        public string SearchString {  get; set; }
        public DateTime StartDateTime {  get; set; }
        public int ResultsAmount { get; set; }
        public DateTime EndDateTime {  get; set; }
        public FailureDto? Failure { get; set; }
        public AlertDto? Alert { get; set; }
        public AbpUserBase User { get; set; }
        public ICollection<ArticleDto> Articles { get; set; }
    }
}
