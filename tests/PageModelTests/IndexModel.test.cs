using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using KonSchool.Pages;
using KonSchool.Tests.Mocks;
using Moq;

namespace KonSchool.Tests.PageModelTests
{
    public class IndexModelTests
    {
		private Mock<IHttpContextAccessor> httpCtxAccessor;
		private MockSession session;
        const int NUMBER_OF_CLASSES = 5;
        const int NUMBER_OF_OCCUPATIONS = 15;

		public IndexModelTests()
		{
			session = new MockSession();
			httpCtxAccessor = new Mock<IHttpContextAccessor>();
			httpCtxAccessor.Setup(hca => hca.HttpContext.Session).Returns(session);
		}

        [Fact]
        public void Can_OnGet()
        {
            var indexPage = new IndexModel(httpCtxAccessor.Object);
            indexPage.OnGet();
            Assert.Equal(NUMBER_OF_CLASSES, indexPage.Classes.Count);
            Assert.Equal(NUMBER_OF_OCCUPATIONS, indexPage.Occupations.Count);
        }

		[Theory]
		[InlineData(0, "Female")]
		[InlineData(1, "Male")]
		public void Can_SetSex_OnPost(int input, string sex)
		{
			var indexPage = new IndexModel(httpCtxAccessor.Object)
			{
				Age = 13,
				ByDiv = false,
				ByDist = false,
				Class = "6",
                Division = "Dhaka",
                District = "Faridpur",
                Thana = "Kamarkhand",
                UW = "Raydoulotpur [Chowbari]",
                Occupation = "Farmer",
				Sex = input
			};
			Assert.True(indexPage.ModelState.IsValid);
			indexPage.OnPost();
			Assert.Equal(sex, httpCtxAccessor.Object.HttpContext.Session.GetString("_Sex"));
		}

		[Theory]
		[InlineData("Worker", 2.5)]
		[InlineData("Tati", 2.5)]
		[InlineData("Fisherman", 2.5)]
		[InlineData("Kamar/Kumar", 2.5)]
		[InlineData("Cultivation", 5.0)]
		[InlineData("Expatriate", 5.0)]
		[InlineData("Small business", 5.0)]
		[InlineData("Govt. job", 7.5)]
		[InlineData("Private job", 7.5)]
		[InlineData("Teacher", 7.5)]
		[InlineData("Lawyer", 10.0)]
		[InlineData("Doctor", 10.0)]
		[InlineData("Engineer", 10.0)]
		[InlineData("Businessman", 10.0)]
		[InlineData("Superman", 1.0)]
		public void Can_SetSocial_OnPost(string input, double ses)
		{
			var indexPage = new IndexModel(httpCtxAccessor.Object)
			{
				Class = "6",
                Division = "Dhaka",
                District = "Faridpur",
                Thana = "Kamarkhand",
                UW = "Raydoulotpur [Chowbari]",
				Occupation = input
			};
			Assert.True(indexPage.ModelState.IsValid);
			indexPage.OnPost();
			double.TryParse(httpCtxAccessor.Object.HttpContext.Session.GetString("_Social"), out double value);
			Assert.Equal(ses, value);
		}

        [Fact]
        public void Can_RedirectTo_InputsPage_OnPost()
        {
            var indexPage = new IndexModel(httpCtxAccessor.Object)
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
