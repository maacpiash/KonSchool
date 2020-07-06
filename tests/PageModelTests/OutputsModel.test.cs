using Xunit;
using KonSchool.Models;
using KonSchool.Pages;
using KonSchool.Services;
using Microsoft.AspNetCore.Http;
using Moq;

namespace KonSchool.Tests.PageModelTests
{
    public class OutputsModelTests
    {
		private Mock<IHttpContextAccessor> httpCtxAccessor;
		private MockSession session;

		public OutputsModelTests()
		{
			session = new MockSession
			{
				session = new System.Collections.Generic.Dictionary<string, string>
				{
					{ "_Class", "10" },
					{ "_Age", "16" },
					{ "_Social", "5.0" },
					{ "_Sex", "Female" },
					{ "_Occupation", "Expatriate" },
					{ "_Division", "Dhaka" },
					{ "_District", "Dhaka" },
					{ "_Thana", "Uttara" },
					{ "_UW", "Ward no. 1" },
					{ "_ByDiv", "True" },
					{ "_ByDist", "True" }
				}
			};
			for (int i = 0; i < 6; i++)
				session.session.Add("_Weight" + i, "0.16666667");
			httpCtxAccessor = new Mock<IHttpContextAccessor>();
			httpCtxAccessor.Setup(hca => hca.HttpContext.Session).Returns(session);
		}

		[Fact]
        public void Can_OnGet()
        {
			var outputsPage = new OutputsModel(new SchoolServiceMock(), httpCtxAccessor.Object);
			outputsPage.OnGet();
			Assert.Equal(6, outputsPage.Criteria.Length);
		}

        [Fact]
        public void Can_ConvertNumbers_ToShortNumber()
        {
			var outputsPage = new OutputsModel(new SchoolServiceMock(), httpCtxAccessor.Object);
			double number = 0.031416;
			string shortNumber = outputsPage.ToShortNumber(number);
			Assert.Equal("3.14%", shortNumber);
		}
    }
}
