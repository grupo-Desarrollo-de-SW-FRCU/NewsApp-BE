using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NewsApp.Articles
{
    public class ArticleAppService_Test : NewsAppApplicationTestBase
    {
        private readonly IArticleAppService _articleAppService;

        public ArticleAppService_Test()
        {
            _articleAppService = GetRequiredService<IArticleAppService>();
        }

        [Fact]
        public async Task Should_Search_Articles()
        {
            //Arrange
            var query = "Apple";

            //Act
            var articles = await _articleAppService.Search(query);

            //Assert
            articles.ShouldNotBeNull();
            articles.Count.ShouldBeGreaterThan(1);
        }
    }
}