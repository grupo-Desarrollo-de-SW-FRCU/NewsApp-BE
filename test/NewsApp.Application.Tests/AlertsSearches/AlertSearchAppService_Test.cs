using System;
using System.Linq;
using System.Threading.Tasks;
using NewsApp.Searches;
using Shouldly;
using Xunit;

namespace NewsApp.AlertsSearches
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
            var searchId = 3;

            //Act
            var alert = await _alertSearchAppService.CreateAlertAsync(searchId);

            //Assert
            alert.ShouldNotBeNull();
            alert.Search.Id.ShouldBe(searchId);
        }

        [Fact]
        public async Task Should_Notify_User_Of_New_Results()
        {
            //Arrange

            //Act
            var notificationDtos = await _alertSearchAppService.NotifyUserOfNewResultsAsync();

            //Assert
            notificationDtos.ShouldNotBeNull();
        }
    }
}
