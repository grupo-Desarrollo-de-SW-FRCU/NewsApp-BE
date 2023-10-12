using System;
using System.Collections.Generic;
using NewsApp.Errors;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Searchs
{
    public class SearchDto : EntityDto<Guid>
    {
        public string SearchString { get; set; }
        public string UserName { get; set; } // Para que está?
        public DateTime StartDateTime { get; set; }
        public int ResultsAmount { get; set; }
        public DateTime EndDateTime { get; set; }
        public ErrorDto? Error { get; set; }
    }
}
