using NewsApp.News;
using System;
using System.Threading.Tasks;
using Xunit;

namespace NewsApp.Tests.News
{
    public class NewsApiServiceTests
    {
        [Fact]
        public async Task GetNewsAsync_ValidQuery_ReturnsNews()
        {
            // Arrange
            var newsApiService = new NewsApiService();

            // Act
            var result = await newsApiService.GetNewsAsync("validquery");

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetNewsAsync_EmptyQuery_ThrowsException()
        {
            // Arrange
            var newsApiService = new NewsApiService();

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() => newsApiService.GetNewsAsync(null));
        }

        [Fact]
        public async Task GetNewsAsync_ApiError_ThrowsException()
        {
            // Arrange
            var newsApiService = new NewsApiService();

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() => newsApiService.GetNewsAsync("invalidquery"));
        }
    }
}
