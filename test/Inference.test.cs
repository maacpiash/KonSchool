using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using KonSchool.Models;
using static KonSchool.Models.Inference;

namespace KonSchool.Tests
{
    public class Inference
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
    }
}
