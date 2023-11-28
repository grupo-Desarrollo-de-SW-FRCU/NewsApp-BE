using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NewsApp.Searches;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.APIStatistics
{
    public class APIStatisticsAppService : NewsAppAppService, IAPIStatisticAppService
    {
        private readonly IRepository<Search, int> _searchRepository;
        private readonly UserManager<Volo.Abp.Identity.IdentityUser> _userManager;
        public APIStatisticsAppService(IRepository<Search, int> searchRepository, UserManager<Volo.Abp.Identity.IdentityUser> userManager)
        {
            _searchRepository = searchRepository;
            _userManager = userManager;
        }

        public async Task<double> GetAverageAPIAccessTimeAsync()
        {
            var searches = await _searchRepository.GetListAsync();

            var sum = 0.0;

            foreach (var search in searches)
            {
                var searchTime = search.EndDateTime - search.StartDateTime;
                sum += searchTime.TotalSeconds;
            }

            var average = sum / searches.Count;
            return average;
        }

        public async Task<APIStatisticDto> GetAPIStatisticsAsync()
        {
            var average = await GetAverageAPIAccessTimeAsync();
            // llamar al resto de métodos de métricas aquí y agregarlos en el constructor
            var apiStatistic = new APIStatisticDto { AverageAccessTime = average };
            return apiStatistic;
        }

    }
}
