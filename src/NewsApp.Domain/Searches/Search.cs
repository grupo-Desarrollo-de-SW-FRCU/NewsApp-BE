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
    public class Search : Entity<Guid>
    {
        public string SearchString {  get; set; }
        public DateTime StartDateTime {  get; set; }
        public int ResultsAmount { get; set; }
        public DateTime EndDateTime {  get; set; }
        public Failure? Failure { get; set; }
        public AlertSearch? AlertSearch { get; set; }
        public IdentityUser User { get; set; }
        public ICollection<Article> Articles { get; set; }


       /* public Search(
           string searchString,
           DateTime startDateTime,
           int resultsAmount,
           DateTime endDateTime,
           Failure? failure,    
           AlertSearch? alertSearch,
           IdentityUser user,
           ICollection<Article> articles
           
           
           )
        {
            SearchString = Check.NotNull(SearchString, nameof(SearchString));
            StartDateTime = startDateTime;
            ResultsAmount = resultsAmount;
            EndDateTime = endDateTime;
            Failure = failure;
            AlertSearch = alertSearch;
            User = user;
            Articles = new List<Article>();

        }
       */
       
    }


}
