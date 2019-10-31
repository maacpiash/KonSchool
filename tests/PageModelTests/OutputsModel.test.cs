using Xunit;
using KonSchool.Models;
using KonSchool.Pages;
using KonSchool.Services;

namespace KonSchool.Tests.PageModelTests
{
    public class OutputsModelTests
    {
        [Fact(Skip="Usage of HttpContext.Session")]
        public void Can_OnGet()
        {
            var outputsPage = new OutputsModel(new SchoolServiceMock());
            outputsPage._Query.Weights = new double[] { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 };
            outputsPage.OnGet();
            Assert.Equal(6, outputsPage.Criteria.Length);
        }

        [Fact]
        public void Can_ConvertNumbers_ToShortNumber()
        {
            var outputsPage = new OutputsModel(new SchoolServiceMock());
            double number = 0.031416;
            string shortNumber = outputsPage.ToShortNumber(number);
            Assert.Equal("3.14%", shortNumber);
        }
    }
}