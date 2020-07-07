using Xunit;
using Microsoft.AspNetCore.Mvc;
using Moq;
using KonSchool.Pages;
using KonSchool.Tests.Mocks;
using Microsoft.AspNetCore.Http;

namespace KonSchool.Tests.PageModelTests
{
    public class InputsModelTests
    {
		private Mock<IHttpContextAccessor> httpCtxAccessor;
		private MockSession session;

		public InputsModelTests()
		{
			session = new MockSession();
			httpCtxAccessor = new Mock<IHttpContextAccessor>();
			httpCtxAccessor.Setup(hca => hca.HttpContext.Session).Returns(session);
		}

        [Fact]
        public void Can_OnGet()
        {
            var inputsModel = new InputsModel(httpCtxAccessor.Object);
            inputsModel.OnGet();
            Assert.NotNull(inputsModel.Values);
        }

        [Fact]
        public void Can_RedirectTo_OutputsPage_OnPost()
        {
			var inputsModel = new InputsModel(httpCtxAccessor.Object);
			inputsModel.OnGet();
			Assert.True(inputsModel.ModelState.IsValid);
			var response_on_submit = inputsModel.OnPost() as RedirectToPageResult;
			Assert.IsType<RedirectToPageResult>(response_on_submit);
			Assert.Equal("/Outputs", response_on_submit.PageName);
        }
    }
}
