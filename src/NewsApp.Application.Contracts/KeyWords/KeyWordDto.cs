using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NewsApp.KeyWords
{
    public class KeyWordDto : EntityDto<Guid>
    {
        public string Keyword { get; set; }
        public Guid ThemeId { get; set; }
        public Guid ArticleId { get; set; }
        public KeyWordDto(string keyword)
        {
            Keyword = keyword;
        }
    }
}
