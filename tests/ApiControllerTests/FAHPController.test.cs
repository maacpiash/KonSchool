using Xunit;
using Microsoft.AspNetCore.Mvc;
using KonSchool.ApiControllers;

namespace KonSchool.Tests.ApiControllerTests
{
    public class FAHPControllerTests
    {
        [Fact]
        public void Can_BadReq_OnInvalidParams()
        {
            string not_really_numbers = "abcde";
            var ctrlr = new FAHPController();
            var result = ctrlr.Get(not_really_numbers);
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }

        [Fact]
        public void Can_BadReq_OnNotEnoughNumbers()
        {
            string not_enough_numbers = "1,2";
            var ctrlr = new FAHPController();
            var result = ctrlr.Get(not_enough_numbers);
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }

        [Theory]
        [InlineData("100,1,1,1,1")]
        [InlineData("-20,1,1,1,1")]
        public void Can_BadReq_OnOutOfRangeNumbers(string weird_numbers)
        {
            var ctrlr = new FAHPController();
            var result = ctrlr.Get(weird_numbers);
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }

        [Fact]
        public void Can_Ok_OnValidParams()
        {
            string numbers = "1,2,3,4,5";
            var ctrlr = new FAHPController();
            var result = ctrlr.Get(numbers);
            Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}