using Xunit;
using KonSchool.Models;

namespace KonSchool.Tests
{
    public class SchoolTests
    {
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
    }
}
