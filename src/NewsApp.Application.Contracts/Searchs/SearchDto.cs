using System;
using System.Collections.Generic;
using NewsApp.Errors;
using System.Text;
using Volo.Abp.Application.Dtos;
using Abp.Authorization.Users;

namespace NewsApp.Searchs
{
    public class SearchDto : EntityDto<Guid>
    {
        public string SearchString { get; set; }
        public DateTime StartDateTime { get; set; }
        public int ResultsAmount { get; set; }
        public DateTime EndDateTime { get; set; }
        public ErrorDto? Error { get; set; }
        public AbpUserBase User { get; set; }
    }
}
