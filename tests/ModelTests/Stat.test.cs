using Xunit;

using static KonSchool.Models.Stat;

namespace KonSchool.Tests.ModelTests
{
    public class StatTests
    {
        [Fact]
        public void Can_Normalize_BySum()
        {
            double[] dummy = new double[] { 1, 2, 3, 4, 5 };
            NormalizeBySum(ref dummy);
            Assert.Equal(0.2, dummy[2]);
        }

        [Theory]
		[InlineData(0.5, 1.0, 2.0, 3.0, 4.0, 5.0)] // ascending
		[InlineData(0.5, 5.0, 4.0, 3.0, 2.0, 1.0)] // descending
        public void Can_Normalize_ByLimits(double value, params double[] numbers)
        {
            double[] dummy = numbers;
            NormalizeByLimits(ref dummy);
            Assert.Equal(value, dummy[2]);
        }

        [Fact]
        public void Can_StdDev()
        {
            double[] dummy = new double[] { 1, 2, 3, 4, 5 };
            double sd = StdDev(dummy);
            Assert.Equal(1.5811388300841898, sd, 6);
        }

        [Fact]
        public void Can_NormDist()
        {
            double[] dummy = new double[] { 1, 2, 3, 4, 5 };
            double nd = NORMDIST(5, 3, 1.5811388300841898, false);
            Assert.Equal(0.11337165224497912, nd, 6);
            nd = NORMDIST(5, 3, 1.5811388300841898, true);
            Assert.Equal(0.897048388225841, nd, 6);
        }
    }
}
