using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface INewsAPI
{
    Task<string> getNews( string LanguageIntCode, int? amountNews);

    //ACA SE DEFINEN METODOS DE LA API QUE SON RESUELTOS EN EL HANDLER
}
