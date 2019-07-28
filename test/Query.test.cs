using Xunit;
using KonSchool.Models;
using KonSchool.Services;
using System.Collections.Generic;

namespace KonSchool.Tests
{
   public class QueryTests
   {
       public static TestSchoolService schoolService;

       [Fact]
       public void CtorTest()
       {
           schoolService = new TestSchoolService();
           Query query = new Query(schoolService)
           {
               Class = 10,
               Social = 10.0,
               IsMale = false,
               Age = 16,
               Division = "Dhaka",
               District = "Dhaka",
               Thana = "Rampura",
               Union_Ward = "Ward no. 1",
               Occupation = "Expatriate",
               CompMat = new (double, double, double)[,]
               {
                   { (1.0, 1.0, 1.0), (1.0, 3.0, 5.0) },
                   { (1.0, 3.0, 5.0), (1.0, 1.0, 1.0) },
               },
               Weights = new double[] { 0.1667, 0.1667, 0.1667, 0.1667, 0.1667, 0.1667 }
           };
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