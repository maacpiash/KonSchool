using Xunit;
using KonSchool.Models;
using KonSchool.Services;
using System.Collections.Generic;

namespace KonSchool.Tests
{
    public class QueryTests
    {
        [Fact]
        public void CtorTest()
        {
            Query query = new Query(new TestSchoolService())
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
                LimitByDivision = false
            };

            Assert.Equal(1, query.Alternatives.Count);
            Assert.Equal("Other", query.Occupation);
        }

        [Fact]
        public void Can_SetLocation()
        {
            Query query = new Query(new TestSchoolService());
            query.SetLocation("Dhaka", "Dhaka", "Rampura", "Ward no. 1");
            Assert.Equal("Dhaka", query.Division);
            Assert.Equal("Dhaka", query.District);
            Assert.Equal("Rampura", query.Thana);
            Assert.Equal("Ward no. 1", query.Union_Ward);
        }

    }

    public class TestSchoolService : ISchoolService
    {
        public List<School> Schools { get; }

        public TestSchoolService()
        {
            Schools = new List<School>
            {
                new School(1212)
            };
        }

        public IEnumerable<School> GetSchools() => Schools;

        public School Get(string eiin) => Schools.Find(school => school.EIIN.Equals(eiin));
    }
}
