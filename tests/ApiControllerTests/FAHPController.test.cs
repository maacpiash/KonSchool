using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using KonSchool.ApiControllers;

namespace KonSchool.Tests.ApiControllerTests
{
    public class FAHPControllerTests
    {
        [Fact]
        public void Can_BadReq_OnInvalidParams()
        {
			var mock = new Mock<ILogger<FAHPController>>();
            string not_really_numbers = "abcde";
            var ctrlr = new FAHPController(mock.Object);
            var result = ctrlr.Get(not_really_numbers);
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }

        [Fact]
        public void Can_BadReq_OnNotEnoughNumbers()
        {
			var mock = new Mock<ILogger<FAHPController>>();
            string not_enough_numbers = "1,2";
            var ctrlr = new FAHPController(mock.Object);
            var result = ctrlr.Get(not_enough_numbers);
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }

        [Theory]
        [InlineData("100,1,1,1,1")]
        [InlineData("-20,1,1,1,1")]
        public void Can_BadReq_OnOutOfRangeNumbers(string weird_numbers)
        {
			var mock = new Mock<ILogger<FAHPController>>();
            var ctrlr = new FAHPController(mock.Object);
            var result = ctrlr.Get(weird_numbers);
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }

        [Fact]
        public void Can_Ok_OnValidParams()
        {
			var mock = new Mock<ILogger<FAHPController>>();
            string numbers = "1,2,3,4,5";
            var ctrlr = new FAHPController(mock.Object);
            var result = ctrlr.Get(numbers);
            Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}
