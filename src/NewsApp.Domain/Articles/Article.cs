using NewsApp.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Articles 
{
    public class Article : Entity<Guid>
    {//autor titulo descripcion url urltoimage publishedat content
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public IdiomEnum Idiom { get; set; } //no reconoce la clase
    }
}


