using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using NewsApp.Alerts;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Themes
{
    public class Theme : Entity<Guid>
    {
        public string Name { get; set; }
        public Alert? Alert { get; set; }
        public AbpUserBase User { get; set; }
        // public ICollection<IArticle> ThemesOrArticles { get; set; } // modelar la composición
    }
}

    