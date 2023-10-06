using NewsApp.Users;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Articles
{
    public class ArticleDto : AuditedEntityDto<Guid>
    {
        public string Title {get; set; }   
        public string Description {get; set; }
        public string Content {get; set; } 
        public string Url {get; set; }
        public string UrlToImage { get; set; }
        public IdiomEnum Idiom {  get; set; }

    }
}
