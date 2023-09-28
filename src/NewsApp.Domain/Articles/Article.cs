using NewsApp.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Articles
{
    public class Article
    {//autor titulo descripcion url urltoimage publishedat content
        public string ArticleId {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public IdiomEnum Idiom { get; set; } //no reconoce la clase
    }
}


