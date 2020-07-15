using Xunit;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using KonSchool.Models;
using KonSchool.ApiControllers;
using KonSchool.Tests.Mocks;

namespace KonSchool.Tests.ApiControllerTests
{
    public class SchoolControllerTests
    {
        [Fact]
        public void Can_Get_AllSchools()
        {
			var mock = new Mock<ILogger<SchoolsController>>();
            var ctrlr = new SchoolsController(new MockSchoolService(), mock.Object);
            var response = ctrlr.Get();
            Assert.IsType<OkObjectResult>(response.Result);
            var AllSchools = (response.Result as OkObjectResult).Value as IEnumerable<School>;
            Assert.Equal(6, AllSchools.ToList().Count);
        }

        [Fact]
        public void Can_Get_OneSchool_EIINwise()
        {
			var mock = new Mock<ILogger<SchoolsController>>();
            var ctrlr = new SchoolsController(new MockSchoolService(), mock.Object);
            var response = ctrlr.GetOneSchool("1212");
            Assert.IsType<OkObjectResult>(response.Result);
            var OneSchool = (response.Result as OkObjectResult).Value as School;
            Assert.Equal("Comilla", OneSchool.Division);
        }

        [Fact]
        public void Can_Get_AllSchools_DivWise()
        {
			var mock = new Mock<ILogger<SchoolsController>>();
            var ctrlr = new SchoolsController(new MockSchoolService(), mock.Object);
            var response = ctrlr.GetSchoolsByDivision("Dhaka");
            Assert.IsType<OkObjectResult>(response.Result);
            var resultValue = (response.Result as OkObjectResult).Value;
            var SchoolsInDhkDiv = (resultValue as IEnumerable<School>).ToList();
            Assert.Equal(4, SchoolsInDhkDiv.Count);
            foreach (var school in SchoolsInDhkDiv)
                Assert.Equal("Dhaka", school.Division);
        }

        [Fact]
        public void Can_Get_AllSchools_DisWise()
        {
			var mock = new Mock<ILogger<SchoolsController>>();
            var ctrlr = new SchoolsController(new MockSchoolService(), mock.Object);
            var response = ctrlr.GetSchoolsByDistrict("Faridpur");
            Assert.IsType<OkObjectResult>(response.Result);
            var OneSchoolInFaridpur = (response.Result as OkObjectResult).Value as IEnumerable<School>;
            Assert.Single(OneSchoolInFaridpur);
            Assert.Equal("Faridpur", OneSchoolInFaridpur.ToList()[0].District);
        }

        [Fact]
        public void Cannot_Get_NonexistentSchools()
        {
			var mock = new Mock<ILogger<SchoolsController>>();
            var ctrlr = new SchoolsController(new MockSchoolService(), mock.Object);

            // EIIN wise
            var response_EIIN = ctrlr.GetOneSchool("2121");
            Assert.IsType<NotFoundResult>(response_EIIN.Result);

            // Div wise
            var response_Division = ctrlr.GetSchoolsByDivision("NewYork");
            Assert.IsType<NotFoundResult>(response_Division.Result);

            // Dist wise
            var response_District = ctrlr.GetSchoolsByDistrict("Gotham");
            Assert.IsType<NotFoundResult>(response_District.Result);

        }
    }
}
