using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Users
{
    public class AppUser
    {
        public Language Language { get; set; }

        public int LanguageId { get; set; } = UsersConst.LanguagePropertyDefaultValue; // Representa el ingles en el enum.

    }
}
