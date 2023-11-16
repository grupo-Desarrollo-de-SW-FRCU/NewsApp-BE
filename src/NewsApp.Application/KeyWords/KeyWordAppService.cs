using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Internal.Mappers;
using Volo.Abp.Domain.Repositories;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace NewsApp.KeyWords
{
    public class KeyWordAppService : NewsAppAppService, IKeyWordAppService
    {
        private readonly IRepository<KeyWord, Guid> _keyWordrepository;

        public KeyWordAppService(IRepository<KeyWord, Guid> keyWordrepository)
        {
            _keyWordrepository = keyWordrepository;
        }

        public async Task<ICollection<KeyWordDto>> GetKeywordsAsync()
        {
            var keywords = await _keyWordrepository.GetListAsync();

            return ObjectMapper.Map<ICollection<KeyWord>, ICollection<KeyWordDto>>(keywords);
        }

    }
}