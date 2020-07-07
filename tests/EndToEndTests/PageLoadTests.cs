using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using KonSchool.Services;
using KonSchool.Tests.Mocks;

namespace KonSchool.Tests.EndToEndTests
{

    public class PageLoadTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;
		private static string responseType = "text/html; charset=utf-8";

		public PageLoadTests(WebApplicationFactory<Startup> factory) => this.factory = factory;

        [Theory]
        [InlineData("/")]
        [InlineData("/Index")]
        [InlineData("/Inputs")]
        [InlineData("/Outputs")]
        [InlineData("/About")]
        [InlineData("/Privacy")]
        [InlineData("/Contact")]
        [InlineData("/Analysis")]
        [InlineData("/Error")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = factory.WithWebHostBuilder(builder =>
				builder.ConfigureServices(services => services.AddSingleton<ISchoolService, MockSchoolService>())
			)
			.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(responseType, response.Content.Headers.ContentType.ToString());
        }
    }
}
