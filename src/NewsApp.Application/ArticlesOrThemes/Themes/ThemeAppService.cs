using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Services;
using NewsApp.Themes;

namespace NewsApp.ArticlesOrThemes.Themes
{
    public class ThemeAppService : CrudAppService<Theme, ThemeDto, Guid>, IThemeAppService
    {
        public ThemeAppService(IRepository<Theme, Guid> repository) : base(repository) { }
    }
}
