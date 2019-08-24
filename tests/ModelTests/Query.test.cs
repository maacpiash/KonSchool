using System.Collections.Generic;
using KonSchool.Models;
using KonSchool.Tests.Mocks;
using Xunit;

namespace KonSchool.Tests.ModelTests
{
    public class QueryTests
    {
        [Fact]
        public void CtorTest()
        {
            Query query = new Query()
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
                LimitByDivision = false,
                _SchoolService = new SchoolServiceMock()
            };

            Assert.Equal(6, query.Alternatives.Count);
            Assert.Equal("Other", query.Occupation);
        }

        [Fact]
        public void Can_SetLocation()
        {
            Query query = new Query()
            {
                _SchoolService = new SchoolServiceMock()
            };
            query.SetLocation("Dhaka", "Dhaka", "Rampura", "Ward no. 1");
            Assert.Equal("Dhaka", query.Division);
            Assert.Equal("Dhaka", query.District);
            Assert.Equal("Rampura", query.Thana);
            Assert.Equal("Ward no. 1", query.Union_Ward);
        }

        [Fact]
        public void Can_CheckEligibility_Female()
        {
            Query query = new Query()
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
                District = "Dhaka",
                _SchoolService = new SchoolServiceMock()
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
            Query query = new Query()
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
                LimitByDivision = false,
                _SchoolService = new SchoolServiceMock()
            };

            query.SetValues();
            
            Assert.Equal(4, query.Alternatives.Count);

            query.Division = "Dhaka";
            query.LimitByDivision = true;

            query.SetValues();

            Assert.Equal(2, query.Alternatives.Count);
        }
    }
}
