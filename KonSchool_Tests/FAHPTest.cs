using System;
using Xunit;
using KonSchool_Models;
using System.IO;
using Xunit.Abstractions;

namespace KonSchool_Tests
{
    public class FAHPTest
    {
        // private readonly ITestOutputHelper output;

        [Fact]
        public void Test1()
        {
            string csvPath = "C:/Users/maacp/Desktop/KonSchool/Dataset.csv";
            Query q = new Query(6, csvPath)
            {
                FuzzyValues = new int[]
                {
                    -1, 2, 1, -3, 1,
                    3, 1, 0, 3, 0,
                    -2, 0, -2, 0, 3
                }
            };
            string[] values = new string[6];
            q.CreateComparisonMatrix();
            ValueTuple<double, double, double> temp;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    temp = q.ComparisonMatrix[i, j];
                    values[i] += $"{temp.Item1}, {temp.Item2}, {temp.Item3}\t\t";
                }
            }

            System.IO.File.WriteAllLines("compmat.txt", values);
            Assert.True(true);
        }
    }
}
