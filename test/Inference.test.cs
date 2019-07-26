using System;
using System.Collections.Generic;
using Xunit;

using KonSchool.Models;
using static KonSchool.Models.Inference;

namespace KonSchool.Tests
{
    public class InferenceTests
    {
        [Fact]
        public void Can_FuzzyMultiply()
        {
            var tuple1 = (1.0, 2.0, 3.0);
            var tuple2 = (4.0, 5.0, 6.0);
            Assert.Equal((4.0, 10.0, 18.0), tuple1.FuzzyMultiply(tuple2));
        }

        [Fact]
        public void Can_Inverse()
        {
            var tuple = (1.0, 2.0, 4.0);
            Assert.Equal((0.25, 0.5, 1.0), tuple.Inverse());
        }

        [Fact]
        public void Can_CalculateComparisonMatrix()
        {
            int[] values = new int[] { -2, -1, 0, 1, 2};
            var compMat = ComparisonMatrix(values);
            for (int i = 0; i < 5; i++)
                Assert.Equal((1.0, 1.0, 1.0), compMat[i, i]);
        }

        [Theory]
        [InlineData("1", "2", "3", "4", "At least 5 integers are expected.")]
        [InlineData("10", "2", "3", "4", "At least 5 integers are expected.")]
        [InlineData("-10", "-9"," -8", "-7", "-6", "Error at 0 = -10: Fuzzy input must be between -9 and +9.")]
        public void ThrowsErrorForInvalidData(params string[] comparisonValues)
        {
            List<int> values = new List<int>();
            int max = comparisonValues.Length - 1;
            for (int i = 0; i < max; i++)
                values.Add(int.Parse(comparisonValues[i]));

            Exception ex = Assert.Throws<ArgumentException>(() => ComparisonMatrix(values.ToArray()));
            Assert.Equal(comparisonValues[max], ex.Message);
        }
    }
}
