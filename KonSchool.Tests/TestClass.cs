using System;
using Xunit;
using KonSchool.Models;
using System.IO;
using System.Collections.Generic;
using Xunit.Abstractions;

using static System.IO.File;

namespace KonSchool.Tests
{
    public class TestClass
    {
        [Fact]
        public void CanReadCSV()
        {
            string csvPath = Environment.CurrentDirectory;
            for (int i = 0; i < 4; i++)
            {
                csvPath = Directory.GetParent(csvPath).FullName;
            }
            csvPath = Path.Combine(csvPath, "Dataset.csv");
            CSVreader fileReader = new CSVreader(csvPath);
            Assert.Equal(14274, fileReader.Height);
        }

        
        //[Fact]
        public void CanComputeComparisonMatrix()
        {
            string csvPath = Environment.CurrentDirectory;
            for (int i = 0; i < 4; i++)
            {
                csvPath = Directory.GetParent(csvPath).FullName;
            }
            csvPath = Path.Combine(csvPath, "Dataset.csv");

            Query q = new Query(6, csvPath)
            {
                FuzzyValues = new int[]
                {
                    -1, 2, 1, -3, 1,
                    3, 1, 0, 3, 0,
                    -2, 0, -2, 0, 3
                },
                ConfLevel = 2
            };

            q.CreateComparisonMatrix();
            
            string[] values = new string[6];
            ValueTuple<double, double, double> temp;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    temp = q.ComparisonMatrix[i, j];
                    values[i] += $"{temp.Item1} {temp.Item2} {temp.Item3},";
                }
            }

            WriteAllLines("compmat.csv", values);
        }


        //[Fact]
        public void CanComputeCriteriaWeightsviaFuzzyAHP()
        {
            var ComparisonMatrix = new ValueTuple<double, double, double>[6, 6];

            string[] values = ReadAllLines("compmat.csv");
            string[] line, numbers;
            for (int i = 0; i < 6; i++)
            {
                line = values[i].Split(',');
                for (int j = 0; j < 6; j++)
                {
                    numbers = line[j].Split(' ');
                    ComparisonMatrix[i, j].Item1 = Convert.ToDouble(numbers[0]);
                    ComparisonMatrix[i, j].Item2 = Convert.ToDouble(numbers[1]);
                    ComparisonMatrix[i, j].Item3 = Convert.ToDouble(numbers[2]);
                }
            }

            var fahp = new FAHP(ComparisonMatrix);
            double[] weights = fahp.CriteriaWeights;

            string[] whattowrite = new string[6];

            for (int i = 0; i < 6; i++)
                whattowrite[i] = $"{weights[i]}";

            WriteAllLines("weights.txt", whattowrite);
        }
        

        [Fact]
        public void CanNormalizeADS()
        {
            List<School> alternatives = new List<School>()
            {
                new School(1) { AverAge = new double[] {1, 2, 3, 4, 5} },
                new School(2) { AverAge = new double[] {6, 7, 8, 9, 10} },
                new School(3) { AverAge = new double[] {11, 12, 13, 14, 15} },
                new School(4) { AverAge = new double[] {16, 17, 18, 19, 20} },
            };

            string csvPath = Environment.CurrentDirectory;
            for (int i = 0; i < 4; i++)
            {
                csvPath = Directory.GetParent(csvPath).FullName;
            }
            csvPath = Path.Combine(csvPath, "Dataset.csv");

            Query q = new Query(6, csvPath) { Age = 12, Class = 6 };

            q.GetADS(alternatives);
            
            int lim = alternatives.Count;
            string[] whattowrite = new string[lim];
            
            for (int i = 0; i < lim; i++)
                whattowrite[i] = $"{alternatives[i].ADS}";
                
            WriteAllLines("ADS.txt", whattowrite);
        }
    }
}
