using System.Collections.Generic;
using KonSchool.Models;
using KonSchool.Tests.Mocks;
using Xunit;
using Moq;

namespace KonSchool.Tests.ModelTests
{
    public class QueryTests
    {
        [Fact]
        public void CtorTest()
        {
			var compMat = new (double, double, double)[,]
			{
				{ (1.0, 1.0, 1.0), (1.0, 3.0, 5.0) },
				{ (1.0, 3.0, 5.0), (1.0, 1.0, 1.0) },
			};
            Query query = new Query(new MockSchoolService())
            {
                Class = 10,
                Social = 10.0,
                IsMale = false,
                Age = 16,
                Occupation = "Soidi",
                CompMat = compMat,
                Weights = new double[] { 0.1667, 0.1667, 0.1667, 0.1667, 0.1667, 0.1667 },
                LimitByDistrict = false,
                LimitByDivision = false
            };

            Assert.Equal(6, query.Alternatives.Count);
            Assert.Equal("Other", query.Occupation);
			Assert.Equal(compMat, query.CompMat);
        }

		[Theory]
		[InlineData(null, "Other")]
		[InlineData("Superman", "Other")]
		[InlineData("Worker", "Worker")]
		public void Can_SetOccupation(string providedValue, string setValue)
		{
			Query query = new Query(new MockSchoolService());
			query.Occupation = providedValue;
			Assert.Equal(setValue, query.Occupation);
		}


        [Fact]
        public void Can_SetLocation()
        {
            Query query = new Query(new MockSchoolService());
            query.SetLocation("Dhaka", "Dhaka", "Rampura", "Ward no. 1");
            Assert.Equal("Dhaka", query.Division);
            Assert.Equal("Dhaka", query.District);
            Assert.Equal("Rampura", query.Thana);
            Assert.Equal("Ward no. 1", query.Union_Ward);
        }

		[Theory]
		[InlineData("Dhaka", "Dhaka", "Rampura", "Ward no. 1", 1.0)]
		[InlineData("Dhaka", "Dhaka", "Rampura", "Ward no. 2", 0.9)]
		[InlineData("Dhaka", "Dhaka", "Banani", "Ward no. 1", 0.7)]
		[InlineData("Dhaka", "Gazipur", "Rampura", "Ward no. 1", 0.4)]
		[InlineData("Comilla", "Dhaka", "Rampura", "Ward no. 1", 0.0)]
		public void Can_SetLOC(string div, string dis, string thana, string uw, double loc)
		{
			var schoolService = new Mock<KonSchool.Services.ISchoolService>();
			schoolService.Setup(ss => ss.GetSchools()).Returns(new List<School>
			{
				new School(1212121)
				{
					Division = "Dhaka",
					District = "Dhaka",
					Thana = "Rampura",
					Union_Ward = "Ward no. 1"
				}
			});
            Query query = new Query(schoolService.Object);
            query.SetLocation(div, dis, thana, uw);
			query.SetValues();
			Assert.Equal(loc, query.Alternatives[0].LOC);
		}

        [Fact]
        public void Can_CheckEligibility_Female()
        {
            Query query = new Query(new MockSchoolService())
            {
                Class = 10,
                Social = 10.0,
                IsMale = false,
                Age = 16,
                Occupation = "Soidi",
                CompMat = new (double, double, double)[,]
                {
                    { (1.0, 1.0, 1.0), (1.0, 3.0, 5.0) },
                    { (1.0, 3.0, 5.0), (1.0, 1.0, 1.0) },
                },
                Weights = new double[] { 0.1667, 0.1667, 0.1667, 0.1667, 0.1667, 0.1667 },
                LimitByDistrict = false,
                LimitByDivision = true,
                Division = "Dhaka",
                District = "Dhaka"
            };

            query.SetValues();

            Assert.Equal(2, query.Alternatives.Count);

            query.LimitByDistrict = true;
            query.SetValues();

            Assert.Single(query.Alternatives);
        }

        [Fact]
        public void Can_CheckEligibility_Male()
        {
            Query query = new Query(new MockSchoolService())
            {
                Class = 7,
                Social = 10.0,
                IsMale = true,
                Age = 13,
                Occupation = "Govt. job",
                CompMat = new (double, double, double)[,]
                {
                    { (1.0, 1.0, 1.0), (1.0, 3.0, 5.0) },
                    { (1.0, 3.0, 5.0), (1.0, 1.0, 1.0) },
                },
                Weights = new double[] { 0.1667, 0.1667, 0.1667, 0.1667, 0.1667, 0.1667 },
                LimitByDistrict = false,
                LimitByDivision = false
            };

            query.SetValues();

            Assert.Equal(4, query.Alternatives.Count);

            query.Division = "Dhaka";
            query.LimitByDivision = true;

            query.SetValues();

            Assert.Equal(2, query.Alternatives.Count);
        }

		[Fact]
		public void Can_CheckEligibility_JunSec()
		{
			School s = new School(1212121) { Level = "Junior Secondary" };
            Query query = new Query(new MockSchoolService()) { Class = 9 };
			Assert.False(query.IsEligible(s));
		}
    }
}
