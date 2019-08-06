// using System;
using System.Collections.Generic;
using Xunit;

using static KonSchool.Models.Inference;

namespace KonSchool.Tests.ModelTests
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

        [Fact]
        public void WontFAHP_forInvalidDiagonalTuple()
        {
            var ComparisonMatrix = new (double, double, double)[,]
            {
                { (1.0, 5.0, 1.0), (2.0, 2.0, 2.0) },
                { (2.0, 2.0, 2.0), (1.0, 1.0, 1.0) }
            };
            var FAHP = new KonSchool.Models.FAHP(ComparisonMatrix);
            
            Assert.Null(FAHP.CriteriaWeights);
        }
    }
}
