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


            var inputSearch = new SearchDto
            {
                SearchString = "Cryptocurrencies",
                StartDateTime = DateTime.Now,
                EndDateTime = DateTime.Now.AddSeconds(3),
                ResultsAmount = 15
            };

            //Act
            var alert = await _alertSearchAppService.CreateAlertAsync(inputSearch);

            //Assert
            alert.ShouldNotBeNull();
        }
    }
}
