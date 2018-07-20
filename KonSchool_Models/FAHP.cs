using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using static System.IO.File;

namespace KonSchool_Models
{
    public class FAHP
    {
        private string[] criteria;
        public string[] Criteria { get => criteria; set => criteria = value; }

        public readonly int CriteriaCount;

        private double[] criteriaWeights;
        public double[] CriteriaWeights
        {
            get => criteriaWeights == null ? RunAHP_on(ComparisonMatrix) : criteriaWeights;
            set => criteriaWeights = value;
        }

        private double[][] altSpecificWeights;
        public double[][] AltSpecificWeights { get => altSpecificWeights; set => altSpecificWeights = value; }

        public int AltCount;

        public ValueTuple<double, double, double>[,] ComparisonMatrix;

        public double[] altScores;
        
        
        public static ValueTuple<double, double, double>[] TFNs;
        public List<ValueTuple<double, double, double>[,]> ComparisonMatrices;

        public FAHP(ValueTuple<double, double, double>[,] ComparisonMatrix)
        {
            CriteriaCount = ComparisonMatrix.GetLength(0);
            altScores = new double[AltCount];
            ComparisonMatrices = new List<ValueTuple<double, double, double>[,]>();
            this.ComparisonMatrix = ComparisonMatrix;         
        }

        public double[] Finalize()
        {
            criteriaWeights = RunAHP_on(ComparisonMatrix);
            for (int i = 0; i < AltCount; i++)
                altSpecificWeights[i] = RunAHP_on(ComparisonMatrices[i]);
            
            double[] scores = new double[AltCount];
            for (int i = 0; i < AltCount; i++)
            {
                for (int j = 0; j < CriteriaCount; j++)
                {
                    scores[i] += criteriaWeights[j] * altSpecificWeights[i][j];
                }
            }
            return scores;
        }

        private double[] RunAHP_on(ValueTuple<double, double, double>[,] ComparisonMatrix)
        {
            int max = ComparisonMatrix.GetLength(0);
            
            if (max != ComparisonMatrix.GetLength(1))
                throw new InvalidDataException("Must be a square matrix");
            
            if (ComparisonMatrix.GetLength(0) != CriteriaCount)
                throw new InvalidDataException("Must have as many column/row as number of criteria");

            ValueTuple<double, double, double> temp;
            double a, b, c, d, e, f;

            for (int i = 0; i < max; i++)
            {
                if (!ComparisonMatrix[i, i].Equals((1, 1, 1)))
                    throw new InvalidDataException("Each criterion must have equal importance TFN compared to itself");
                for (int j = i + 1; j < max; j++)
                {
                    (a, b, c) = ComparisonMatrix[i, j];
                    if (a > b || b > c)
                        throw new InvalidDataException("Invalid TFN");
                    (d, e, f) = ComparisonMatrix[j, i];
                    double threshold = 1E-3;
                    if (Math.Abs(d - 1 / c) > threshold || Math.Abs(e - 1 / b) > threshold || Math.Abs(f - 1 / a) > threshold)
                        throw new InvalidDataException("TFN(i, j) must be inverse of TFN(j, i) for all i, j <= CriteriaCount");
                }
            }

            // Step 1 : Geometric Mean
            double[] weights = new double[max];
            double power = 1 / (double)max;
            double x, y, z;
            ValueTuple<double, double, double>[] geomean = new ValueTuple<double, double, double>[max];
            for (int i = 0; i < max; i++)
            {
                temp = (1.0, 1.0, 1.0);
                for (int j = 0; j < max; j++)
                    ScalarMultiply(ref temp, ComparisonMatrix[i, j]);
                x = Math.Pow(temp.Item1, power);
                y = Math.Pow(temp.Item2, power);
                z = Math.Pow(temp.Item3, power);
                geomean[i] = new ValueTuple<double, double, double>(x, y, z);

            }

            // Step 2 : Multiplying with Inverse Vector
            double L = 0, M = 0, U = 0;
            for (int i = 0; i < max; i++)
                (L, M, U) = (L + geomean[i].Item1, M + geomean[i].Item2, U + geomean[i].Item3);
            
            for (int i = 0; i < max; i++)
            {
                var now = geomean[i];
                now = (now.Item1 / U, now.Item2 / M, now.Item3 / L);
                weights[i] = (now.Item1 + now.Item2 + now.Item3) / 3;
            }

            return weights;
        }

        private static void ScalarMultiply (  // scalar multiplication of two 3D vectors
            ref ValueTuple<double, double, double> t1,
            ValueTuple<double, double, double> t2
        ) => t1 = (t1.Item1 * t2.Item1, t1.Item2 * t2.Item2, t1.Item3 * t2.Item3);
    }
}