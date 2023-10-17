using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using NewsApp.Alerts;
using NewsApp.Articles;
using NewsApp.Failures;
using Volo.Abp.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewsApp.Searchs
{
    public class Search : Entity<Guid>
    {
        public string SearchString {  get; set; }
        public DateTime StartDateTime {  get; set; }
        public int ResultsAmount { get; set; }
        public DateTime EndDateTime {  get; set; }
        public Failure? Failure { get; set; }
        public Alert? Alert { get; set; }
        public AbpUserBase User { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
