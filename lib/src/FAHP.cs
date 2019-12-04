using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using static System.Math;
using static KonSchool.Lib.Stat;

namespace KonSchool.Lib
{
    public class FAHP
    {
        public readonly int CriteriaCount;

        private double[] criteriaWeights;
        public double[] CriteriaWeights
        {
            get => criteriaWeights ?? (ValidMatrix ? RunFAHP() : null);
            set => criteriaWeights = value;
        }

        public bool ValidMatrix { get; set; }

        public (double, double, double)[,] ComparisonMatrix;

        public static (double, double, double)[] TFNs;

        public FAHP((double, double, double)[,] ComparisonMatrix)
        {
            CriteriaCount = ComparisonMatrix.GetLength(0);
            this.ComparisonMatrix = ComparisonMatrix;
            ValidMatrix = IsValid();
            if (ValidMatrix) RunFAHP();
        }

        private bool IsValid()
        {
            for (int i = 0; i < CriteriaCount; i++)
            {
                if (!ComparisonMatrix[i, i].Equals((1.0, 1.0, 1.0)))
                    return false;
            }
            return true;
        }

        private double[] RunFAHP()
        {
            (double, double, double) temp;

            // Step 1 : Geometric Mean
            double[] weights = new double[CriteriaCount];
            double power = 1.0 / 6.0;
            (double, double, double)[] geomean = new (double, double, double)[CriteriaCount];
            for (int i = 0; i < CriteriaCount; i++)
            {
                temp = (1.0, 1.0, 1.0);
                for (int j = 0; j < CriteriaCount; j++)
                    temp = temp.ScalarMultiply(ComparisonMatrix[i, j]);
                geomean[i] = (Pow(temp.Item1, power), Pow(temp.Item2, power), Pow(temp.Item3, power));
            }

            // Step 2 : Multiplying with Inverse Vector
            double L = 0, M = 0, U = 0;
            for (int i = 0; i < CriteriaCount; i++)
            {
                L += geomean[i].Item1;
                M += geomean[i].Item2;
                U += geomean[i].Item3;
            }

            for (int i = 0; i < CriteriaCount; i++)
            {
                var now = geomean[i];
                now = (now.Item1 / U, now.Item2 / M, now.Item3 / L);
                weights[i] = (now.Item1 + now.Item2 + now.Item3) / 3;
            }

            // Step 5: Normalization
            NormalizeBySum(ref weights);

            return weights;
        }
    }
}
