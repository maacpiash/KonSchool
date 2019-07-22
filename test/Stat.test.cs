using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using KonSchool.Models;
using static KonSchool.Models.Stat;

namespace KonSchool.Tests
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

        [Fact]
        public void Can_Normalize_ByLimits()
        {
            double[] dummy = new double[] { 1, 2, 3, 4, 5 };
            NormalizeByLimits(ref dummy);
            Assert.Equal(0.5, dummy[2]);
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
        }
    }
}
