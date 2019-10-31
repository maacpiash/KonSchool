using Xunit;
using Microsoft.AspNetCore.Mvc;

using KonSchool.Pages;
using KonSchool.Models;

namespace KonSchool.Tests.PageModelTests
{
    public class InputsModelTests
    {
        [Fact]
        public void Can_OnGet()
        {
            var inputsModel = new InputsModel();
            inputsModel.OnGet();
            Assert.NotNull(inputsModel.Values);
        }

        [Fact(Skip="Usage of HttpContext.Session")]
        public void Can_RedirectTo_OutputsPage_OnPost()
        {
            var inputsModel = new InputsModel();
            inputsModel.OnGet();
            Assert.True(inputsModel.ModelState.IsValid);
            var response_on_submit = inputsModel.OnPost() as RedirectToPageResult;
            Assert.IsType<RedirectToPageResult>(response_on_submit);
            Assert.Equal("/Outputs", response_on_submit.PageName);
        }
    }
}