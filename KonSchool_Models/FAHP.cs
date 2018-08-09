using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using static System.IO.File;
using static KonSchool_Models.Stat;

namespace KonSchool_Models
{
    public class FAHP
    {
        public readonly int CriteriaCount;
        private double[] criteriaWeights;
        public double[] CriteriaWeights
        {
            get => criteriaWeights == null ? RunFAHP() : criteriaWeights;
            set => criteriaWeights = value;
        }
        
        public ValueTuple<double, double, double>[,] ComparisonMatrix;

        public static ValueTuple<double, double, double>[] TFNs;
        public List<ValueTuple<double, double, double>[,]> ComparisonMatrices;

        public FAHP(ValueTuple<double, double, double>[,] ComparisonMatrix)
        {
            CriteriaCount = ComparisonMatrix.GetLength(0);
            this.ComparisonMatrix = ComparisonMatrix;         
        }

        private void Validate()
        {
            
            if (CriteriaCount != ComparisonMatrix.GetLength(1))
                throw new InvalidDataException("Must be a square matrix.");
            
            if (ComparisonMatrix.GetLength(0) != CriteriaCount)
                throw new InvalidDataException("Must have as many column/row as number of criteria.");

            double a, b, c, d, e, f;

            for (int i = 0; i < CriteriaCount; i++)
            {
                if (!ComparisonMatrix[i, i].Equals((1.0, 1.0, 1.0)))
                    throw new InvalidDataException("Each criterion must have equal importance TFN compared to itself.");
                for (int j = i + 1; j < CriteriaCount; j++)
                {
                    (a, b, c) = ComparisonMatrix[i, j];
                    if (a > b || b > c)
                        throw new InvalidDataException($"Invalid TFN at position {i}, {j}.");
                    (d, e, f) = ComparisonMatrix[j, i];
                    double threshold = 1E-3;
                    if (Math.Abs(d - 1 / c) > threshold || Math.Abs(e - 1 / b) > threshold || Math.Abs(f - 1 / a) > threshold)
                        throw new InvalidDataException($"TFN({i}, {j}) = [{a}, {b}, {c}] must be inverse of TFN({j}, {i})  = [{d}, {e}, {f}].");
                }
            }
        }

        private double[] RunFAHP()
        {
            Validate();
            ValueTuple<double, double, double> temp;

            // Step 1 : Geometric Mean
            double[] weights = new double[CriteriaCount];
            double power = 1 / (double)CriteriaCount;
            double x, y, z;
            ValueTuple<double, double, double>[] geomean = new ValueTuple<double, double, double>[CriteriaCount];
            for (int i = 0; i < CriteriaCount; i++)
            {
                temp = (1.0, 1.0, 1.0);
                for (int j = 0; j < CriteriaCount; j++)
                    ScalarMultiply(ref temp, ComparisonMatrix[i, j]);
                x = Math.Pow(temp.Item1, power);
                y = Math.Pow(temp.Item2, power);
                z = Math.Pow(temp.Item3, power);
                geomean[i] = new ValueTuple<double, double, double>(x, y, z);

            }

            // Step 2 : Multiplying with Inverse Vector
            double L = 0, M = 0, U = 0;
            for (int i = 0; i < CriteriaCount; i++)
                (L, M, U) = (L + geomean[i].Item1, M + geomean[i].Item2, U + geomean[i].Item3);
            
            for (int i = 0; i < CriteriaCount; i++)
            {
                var now = geomean[i];
                now = (now.Item1 / U, now.Item2 / M, now.Item3 / L);
                weights[i] = (now.Item1 + now.Item2 + now.Item3) / 3;
            }

            // Step 5: Normalization
            Normalize(ref weights);

            return weights;
        }        

        internal static double[] Normalize(ref double[] numbers)
        {
            int max = numbers.Length;
            double sum = 0;
            for (int i = 0; i < max; i++)
                sum += numbers[i];
            for (int i = 0; i < max; i++)
                numbers[i] /= sum;
            return numbers;
        }

        internal static double[] Normalize(ref double[] numbers, double lower, double upper)
        {
            int length = numbers.Length;
            double min = numbers[0], max = numbers[0];
            for (int i = 1; i < length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
            }

            double dx = max - min;
            double diff = upper - lower;
            for (int i = 0; i < length; i++)
                numbers[i] = lower + (numbers[i] - min) * diff / dx;

            return numbers;
        }
    }
}