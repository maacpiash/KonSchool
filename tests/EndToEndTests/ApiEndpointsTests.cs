using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using System.Text.Json;

namespace KonSchool.Tests.EndToEndTests
{

    public class ApiEndpointsTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;
		private static string responseType = "application/json; charset=utf-8";

        public ApiEndpointsTests(WebApplicationFactory<Startup> factory) => this.factory = factory;

        [Theory]
        [InlineData("/api/schools/1212", 1, false, "")]
        [InlineData("/api/schools/div/Dhaka", 4, true, "division")]
        [InlineData("/api/schools/dis/Dhaka", 1, true, "district")]
        public async Task Get_SchoolsEndpoint_ReturnsSuccessAndCorrectContentType(string url, int expectedCount, bool isArray, string field)
        {
            // Arrange
            var client = factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(responseType, response.Content.Headers.ContentType.ToString());

			string msg = await response.Content.ReadAsStringAsync();
			using (JsonDocument document = JsonDocument.Parse(msg))
			{
				if (isArray)
				{
					int actualCount = 0;
					JsonElement root = document.RootElement;
					foreach (JsonElement school in root.EnumerateArray())
					{
						string value = school.GetProperty(field).GetString();
						Assert.Equal("Dhaka", value);
						actualCount++;
					}
					Assert.Equal(expectedCount, actualCount);
				}
				else
				{
					int eiin = document.RootElement.GetProperty("eiin").GetInt32();
					Assert.Equal(1212, eiin);
				}
			}
        }

        [Theory]
        [InlineData("/api/fahp/0,0,0,0,0", 1.0)] // all are equal
        [InlineData("/api/fahp/1,2,3,4,5", 2.0)] // exponentially increasing
        [InlineData("/api/fahp/-5,-4,-3,-2,-1", 3.0)] // exponentially decreasing
        public async Task Get_FAHPEndpoint_ReturnsSuccessAndCorrectContentType(string url, double situation)
        {
            // Arrange
            var client = factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(responseType, response.Content.Headers.ContentType.ToString());

			string msg = await response.Content.ReadAsStringAsync();
			double[] values = JsonSerializer.Deserialize<double[]>(msg);

			switch (situation)
			{
				case 1.0: // all are equal
					for (int i = 0; i < 5; i++)
						Assert.Equal(1.0, values[i] / values[i + 1], 6);
					break;
				case 2.0: // exponentially increasing
					for (int i = 0; i < 5; i++)
						Assert.True(values[i] <= values[i + 1]);
					break;
				case 3.0: // exponentially decreasing
					for (int i = 0; i < 5; i++)
						Assert.True(values[i] >= values[i + 1]);
					break;
				default:
					break;
			}
        }
    }
}
