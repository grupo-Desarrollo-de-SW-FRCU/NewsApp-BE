using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Abp;
using NewsApp.Alerts;
using NewsApp.Articles;
using NewsApp.Failures;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;

namespace NewsApp.Searches
{
    public class Search : Entity<int>
    {
        public string SearchString {  get; set; }
        public int ResultsAmount { get; set; }
        public DateTime StartDateTime {  get; set; }        
        public DateTime EndDateTime {  get; set; }

        // relaciones
        public Failure? Failure { get; set; }
        public AlertSearch? AlertSearch { get; set; }
        public IdentityUser User { get; set; }
        // public ICollection<Article> Articles { get; set; }


        public Search()
        {
            //Articles = new List<Article>();
        }             
    }


}
