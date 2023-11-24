using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NewsApp.Searches;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Alerts.AlertsSearches
{
    public class AlertSearchAppService : NewsAppAppService, IAlertSearchAppService
    {
        // private readonly IRepository<Search, int> _searchRepository;
        private readonly IRepository<AlertSearch, int> _alertSearchRepository;
        private readonly UserManager<Volo.Abp.Identity.IdentityUser> _userManager;
        public AlertSearchAppService(IRepository<Search, int> searchRepository, IRepository<AlertSearch, int> alertSearchRepository, UserManager<Volo.Abp.Identity.IdentityUser> userManager)
        {
            // _searchRepository = searchRepository;
            _alertSearchRepository = alertSearchRepository;
            _userManager = userManager;
        }

        public async Task<AlertSearchDto> CreateAlertAsync(SearchDto inputSearch)
        {
            AlertSearch alert = null;

            var userGuid = CurrentUser.Id.GetValueOrDefault();

            var identityUser = await _userManager.FindByIdAsync(userGuid.ToString());

            var search = ObjectMapper.Map<SearchDto, Search>(inputSearch);

            alert = new AlertSearch
            {
                Search = search,
                CreatedDate = DateTime.Now,
                User = identityUser
            };

            alert = await _alertSearchRepository.InsertAsync(alert, autoSave: true);

            return ObjectMapper.Map<AlertSearch, AlertSearchDto>(alert);
        }
    }
}