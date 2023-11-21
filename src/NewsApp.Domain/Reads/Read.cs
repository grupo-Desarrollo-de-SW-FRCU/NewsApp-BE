using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Microsoft.AspNetCore.Identity;
using NewsApp.Articles;
using Volo.Abp.Domain.Entities;

namespace NewsApp.Reads
{
    public class Read : Entity<int>
    {
        public DateTime ReadDateTime { get; set; }
        public bool Liked { get; set; }
        public required IdentityUser User { get; set; }
        public Article Article { get; set; }

    }
}

