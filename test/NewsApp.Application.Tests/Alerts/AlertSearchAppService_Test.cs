using System;
using System.Linq;
using System.Threading.Tasks;
using NewsApp.Alerts.AlertsSearches;
using NewsApp.Searches;
using Shouldly;
using Xunit;

namespace NewsApp.Alerts
{
    public class AlertSearchAppService_Test : NewsAppApplicationTestBase
    {
        private readonly IAlertSearchAppService _alertSearchAppService;

        public AlertSearchAppService_Test()
        {
            _alertSearchAppService = GetRequiredService<IAlertSearchAppService>();
        }

        [Fact]
        public async Task Should_Create_AlertSearch()
        {
            //Arrange
            var searchId = 1;

            //Act
            var alert = await _alertSearchAppService.CreateAlertAsync(searchId);

            //Assert
            alert.ShouldNotBeNull();
        }
    }
}
