﻿using System;
using System.Collections.Generic;
using NewsApp.Failures;
using Volo.Abp.Application.Dtos;
using Abp.Authorization.Users;
using NewsApp.Alerts;
using NewsApp.Articles;
using NewsApp.News;
using NewsApp.Users;

namespace NewsApp.Searches
{
    public class SearchDto : EntityDto<int>
    {
        public string SearchString {  get; set; }
        public int ResultsAmount { get; set; }
        public DateTime StartDateTime {  get; set; }
        public DateTime EndDateTime {  get; set; }

        // relaciones
        public FailureDto? Failure { get; set; }
        public AlertDto? Alert { get; set; }
        public UserDto User { get; set; }
        // public ICollection<ArticleDto> Articles { get; set; }
    }
}
