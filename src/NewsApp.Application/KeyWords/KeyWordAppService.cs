using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.KeyWords
{
    public class KeyWordAppService : NewsAppAppService, IKeyWordAppService
    {
        private readonly IRepository<KeyWord, Guid> _keyWordrepository;

        public KeyWordAppService(IRepository<KeyWord, Guid> keyWordrepository)
        {
            _keyWordrepository = keyWordrepository;
        }

        public async Task<ICollection<KeyWordDto>> GetKeywordsAsync(Guid themeId)
        {
            var keywords = await _keyWordrepository
                .GetListAsync(keyWord => keyWord.Theme.Id == themeId);

            return ObjectMapper.Map<ICollection<KeyWord>, ICollection<KeyWordDto>>(keywords);
        }

    }
}