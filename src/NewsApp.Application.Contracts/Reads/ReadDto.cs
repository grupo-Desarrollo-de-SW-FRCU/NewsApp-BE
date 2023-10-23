using System;
using System.Collections.Generic;
using System.Text;
using Abp.Authorization.Users;
using NewsApp.Articles;
using NewsApp.ArticlesOrThemes;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Reads
{
    public class ReadDto : EntityDto<Guid>
    {
        public DateTime ReadDateTime { get; set; }
        public bool Liked { get; set; }
        public AbpUserBase User { get; set; }
        public ArticleDto Article { get; set; }
    }
}
