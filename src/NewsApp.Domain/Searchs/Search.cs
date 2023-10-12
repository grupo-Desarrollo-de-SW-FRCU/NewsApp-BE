using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewsApp.Searchs
{
    public class Search : Entity<Guid>
    {
        public string SearchString {  get; set; }
        public string UserName { get; set; } // Para que está?
        public DateTime StartDateTime {  get; set; }
        public int ResultsAmount { get; set; }
        public DateTime EndDateTime {  get; set; }
        public Error? Error { get; set; }
    }
}
