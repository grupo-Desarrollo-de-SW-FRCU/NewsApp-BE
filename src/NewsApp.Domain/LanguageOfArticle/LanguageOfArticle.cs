using Abp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Language
{
    public class LanguageOfArticle : Entity<Guid>
    {
        private LanguageOfArticle internationalCode;

        public string Name { get; set; }
        public LanguageOfArticle InternationalCode { get => internationalCode; set => internationalCode = value; }
        public ICollection<IdentityUser> Users { get; set; }


    }
}
