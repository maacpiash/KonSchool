using System;
using System.Collections.Generic;
using System.Text;

namespace KonSchool.Models
{
    public static class Inference
    {
        public static (double, double, double)[,] ComparisonMatrix(int[] values, int ConfLevel)
        {
            int i;

            #region Validation
            if (values.Length < 5)
                throw new ArgumentException("At least 5 integers are expected.");

            for (i = 0; i < 4; i++)
                if (values[i] < -9 || values[i] > 9)
                    throw new ArgumentException($"Error at {i} = {values[i]}: Fuzzy input must be between -9 and +9.");

            if (ConfLevel < 0 || ConfLevel > 2)
                throw new ArgumentException("Confidence level must be between 1 and 3.");
            #endregion
            
            (double, double, double)[,] TFNs =
            {
                {
                    (1, 1, 1), (1, 2, 3), (2, 3, 4),
                    (3, 4, 5), (4, 5, 6), (5, 6, 7),
                    (6, 7, 8), (7, 8, 9), (9, 9, 9)
                },
                {
                    (1, 1, 1), (1.5, 2, 2.5), (2.5, 3, 3.5),
                    (3.5, 4, 4.5), (4.5, 5, 5.5), (5.5, 6, 6.5),
                    (6.5, 7, 7.5), (7.5, 8, 8.5), (9, 9, 9)
                },
                {
                    (1, 1, 1), (2, 2, 2), (3, 3, 3),
                    (4, 4, 4), (5, 5, 5), (6, 6, 6),
                    (7, 7, 7), (8, 8, 8), (9, 9, 9)
                }
            };


            (double, double, double)[,] CompMat = new (double, double, double)[6, 6];

            // First, equality

            for (int j = 0; j <= 5; j++)
                CompMat[j, j] = (1.0, 1.0, 1.0);

            // Then, setting the values from the 'values' array

            for (i = 0; i < 5; i++)
            {
                if (values[i] < 0)
                    CompMat[i, i + 1] = TFNs[ConfLevel, -1 - values[i]];
                else if (values[i] > 0)
                    CompMat[i, i + 1] = TFNs[ConfLevel, -1 + values[i]].Inverse();
                else
                    CompMat[i, i + 1] = (1, 1, 1);
            }

            // Now, inference by multiplication
            
            for (int j = 3; j >= 0; j--)
            {
                for (int k = 0; k <= j; k++)
                    CompMat[k, k + 5 - j] = CompMat[k, k + 4 - j].FuzzyMultiply(CompMat[k + 4 - j, k + 5 - j]);
            }
            
            // Finally, ij = 1 / ji

            for (int r = 1; r <= 5; r++)
                for (int c = 0; c < r; c++)
                    CompMat[r, c] = CompMat[c, r].Inverse();

            return CompMat;
        }

        public static (double, double, double) FuzzyMultiply(this (double, double, double) a, (double, double, double) b)
        {
            double[] Items = { a.Item1 * b.Item1, a.Item1 * b.Item3, a.Item3 * b.Item1, a.Item3 * b.Item3 };
                                // a1b1 a1b3 a3b1 a3b3
            double Left = Items[0], Middle = a.Item2 * b.Item2, Right = Items[0];

            for (int i = 0; i < 4; i++)
            {
                if (Items[i] < Left)
                    Left = Items[i];
                if (Items[i] > Right)
                    Right = Items[i];
            }

            return (Left, Middle, Right);
        }

        public static (double, double, double) Inverse(this (double, double, double) a)
            => (1.0 / a.Item3, 1.0 / a.Item2, 1.0 / a.Item1);
    }
}
