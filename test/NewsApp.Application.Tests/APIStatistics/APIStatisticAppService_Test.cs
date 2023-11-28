using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.EntityFrameworkCore;
using Shouldly;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Uow;
using Xunit;

namespace NewsApp.APIStatistics
{
    public class APIStatisticAppService_Test : NewsAppApplicationTestBase
    {
        private readonly IAPIStatisticAppService _apiStatisticAppService;
        private readonly IDbContextProvider<NewsAppDbContext> _dbContextProvider;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public APIStatisticAppService_Test()
        {
            _apiStatisticAppService = GetRequiredService<IAPIStatisticAppService>();
            _dbContextProvider = GetRequiredService<IDbContextProvider<NewsAppDbContext>>();
            _unitOfWorkManager = GetRequiredService<IUnitOfWorkManager>();
        }

        [Fact]
        public async Task Should_Get_Average_API_Access_Time()
        {
            //Arrange            

            //Act
            var apiStatistic = await _apiStatisticAppService.GetAverageAPIAccessTimeAsync();
            //Assert
            // Se verifican los datos devueltos por el servicio
            apiStatistic.ShouldBeGreaterThanOrEqualTo(0);
        }

        [Fact]
        public async Task Should_Get_API_Statistics()
        {
            //Arrange            

            //Act
            var apiStatistic = await _apiStatisticAppService.GetAPIStatisticsAsync();
            //Assert
            // Se verifican los datos devueltos por el servicio
            apiStatistic.ShouldNotBeNull();
            apiStatistic.AverageAccessTime.ShouldBeGreaterThanOrEqualTo(0);
        }
    }
}
