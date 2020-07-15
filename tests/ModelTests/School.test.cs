using Xunit;
using KonSchool.Models;

namespace KonSchool.Tests.ModelTests
{
    public class SchoolTests
    {
        [Fact]
        public void Can_GetSetValues()
        {
            School school = new School(121212)
            {
                Name = "Ideal School & College",
                OLD = 0.7,
                Division = "Dhaka",
                District = "Dhaka",
                Thana = "Motijheel",
                Union_Ward = "Ward no. 10",
                StreetAddr = "Motijheel",
                MobileNum = "01212121212",
                LOC = 0.5,
                Type = "co-ed",
                Level = "hi-sec",
                ADS = 0.2,
                MFR = 1.0,
                TSR = 0.3,
                SES = 0.4,
                WeightedScores = new double[] { },
                EthnicStudents = true,
                HasBusiness = true,
                HasVocational = false
            };

            for (int i = 0; i < 5; i++)
                Assert.Equal(0.0, school.AverAge[i]);
            for (int i = 0; i < 4; i++)
                Assert.Equal(0.0, school.SEScore[i]);
        }


        [Fact]
        public void Can_SetValuesFromArray()
        {
            School school = new School(121212);
            school.AverAge = new double[] { 11.0, 12.0, 13.0, 14.0, 15.0 };
            school.SEScore = new double[] { 0.2, 0.4, 0.3, 0.1 };

            Assert.Equal(11.0, school.AverAge6);
            Assert.Equal(12.0, school.AverAge7);
            Assert.Equal(13.0, school.AverAge8);
            Assert.Equal(14.0, school.AverAge9);
            Assert.Equal(15.0, school.AverAgeX);

            Assert.Equal(0.2, school.SEScore1);
            Assert.Equal(0.4, school.SEScore2);
            Assert.Equal(0.3, school.SEScore3);
            Assert.Equal(0.1, school.SEScore4);
        }

		[Fact]
        public void Can_ThrowException_ForInvalidArrays()
        {
            School school = new School(121212);
			Assert.Throws<System.Exception>(() => school.AverAge = new double[] { 11.0, 12.0, 13.0, 14.0 });
			Assert.Throws<System.Exception>(() => school.SEScore = new double[] { 0.2, 0.4, 0.3 });
        }
    }
}
