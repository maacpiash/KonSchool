using System;
using Xunit;

using static KonSchool.Models.Inference;

namespace KonSchool.Tests
{
    public class FAHPTests
    {
        [Fact]
        public void Can_GiveEqualWeightsForAllOnes()
        {
            int[] values = new int[] { 1, 1, 1, 1, 1 };
            var FAHP = new KonSchool.Models.FAHP(ComparisonMatrix(values));
            var compMat = FAHP.CriteriaWeights;
            for (int i = 0; i < 5; i++)
                Assert.Equal(0.1666667, compMat[i], 6);
        }
    }
}
