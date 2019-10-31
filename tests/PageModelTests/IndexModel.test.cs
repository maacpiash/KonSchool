using Xunit;
using Microsoft.AspNetCore.Mvc;
using KonSchool.Pages;
using KonSchool.Models;

namespace KonSchool.Tests.PageModelTests
{
    public class IndexModelTests
    {
        const int NUMBER_OF_CLASSES = 5;
        const int NUMBER_OF_OCCUPATIONS = 15;

        [Fact]
        public void Can_OnGet()
        {
            var indexPage = new IndexModel();
            indexPage.OnGet();
            Assert.Equal(NUMBER_OF_CLASSES, indexPage.Classes.Count);
            Assert.Equal(NUMBER_OF_OCCUPATIONS, indexPage.Occupations.Count);
        }

        [Fact(Skip="Usage of HttpContext.Session")]
        public void Can_RedirectTo_InputsPage_OnPost()
        {
            var indexPage = new IndexModel()
            {
                Class = "6",
                Division = "Dhaka",
                District = "Faridpur",
                Thana = "Kamarkhand",
                UW = "Raydoulotpur [Chowbari]",
                Occupation = "Farmer"
            };
            Assert.True(indexPage.ModelState.IsValid);
            var response_on_submit = indexPage.OnPost() as RedirectToPageResult;
            Assert.IsType<RedirectToPageResult>(response_on_submit);
            Assert.Equal("/Inputs", response_on_submit.PageName);
        }
    }
}