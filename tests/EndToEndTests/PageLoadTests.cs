using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;

namespace KonSchool.Tests.EndToEndTests
{

    public class PageLoadTests : IClassFixture<WebApplicationFactory<KonSchool.Startup>>
    {
        private readonly WebApplicationFactory<KonSchool.Startup> factory;

        public PageLoadTests(WebApplicationFactory<KonSchool.Startup> factory) => this.factory = factory;

        [Theory]
        [InlineData("/")]
        [InlineData("/Index")]
        [InlineData("/Inputs")]
        [InlineData("/Outputs")]
        [InlineData("/About")]
        [InlineData("/Privacy")]
        [InlineData("/Contact")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
}
