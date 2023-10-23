using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Language
{
    public class Language : Entity<Guid>
    {
        private Language internationalCode;

        public string Name { get; set; }
        public Language InternationalCode { get => internationalCode; set => internationalCode = value; }
        //public ICollection<IdentityUser> Users { get; set; }


    }
}
