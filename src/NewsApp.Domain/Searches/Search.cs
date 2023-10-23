﻿using System;
using System.Collections.Generic;
using NewsApp.Alerts;
using NewsApp.Articles;
using NewsApp.Failures;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;

namespace NewsApp.Searchs
{
    public class Search : Entity<Guid>
    {
        public string SearchString {  get; set; }
        public DateTime StartDateTime {  get; set; }
        public int ResultsAmount { get; set; }
        public DateTime EndDateTime {  get; set; }
        public Failure? Failure { get; set; }
        public AlertSearch? AlertSearch { get; set; }
        public required IdentityUser User { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
