using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Articles
{
    public interface IArticleAppService
    {
        Task<ICollection<ArticleDto>> Search(string query);
    }
}