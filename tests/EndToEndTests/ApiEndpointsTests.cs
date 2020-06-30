using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using System.Net;

namespace KonSchool.Tests.EndToEndTests
{

    public class ApiEndpointsTests
        : IClassFixture<WebApplicationFactory<KonSchool.Startup>>
    {
        private readonly WebApplicationFactory<KonSchool.Startup> factory;

        public ApiEndpointsTests(WebApplicationFactory<KonSchool.Startup> factory) =>
            this.factory = factory;

        [Theory(Skip="Failing due to an unknown issue")]
        [InlineData("/api/schools/100005")]
        [InlineData("/api/schools/dis/BOGRA")]
        [InlineData("/api/fahp/0,0,0,0,0")]
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
