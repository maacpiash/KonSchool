using System.Linq;
using static System.Math;

namespace KonSchool.Shared
{
	public static class FAHP
	{
		// TODO: Use this method for testing
		// public static bool IsValid((double, double, double)[,] comparisonMatrix, int criteriaCount)
		// {
		// 	for (int i = 0; i < criteriaCount; i++)
		// 	{
		// 		if (!comparisonMatrix[i, i].Equals((1.0, 1.0, 1.0)))
		// 			return false;
		// 	}
		// 	return true;
		// }

		public static double[] RunFAHP(this (double, double, double)[,] comparisonMatrix)
		{
			(double, double, double) temp;
			int criteriaCount = comparisonMatrix.GetLength(0);

			// Step 1 : Geometric Mean
			double[] weights = new double[criteriaCount];
			double power = 1.0 / 6.0;
			(double, double, double)[] geomean = new (double, double, double)[criteriaCount];
			for (int i = 0; i < criteriaCount; i++)
			{
				temp = (1.0, 1.0, 1.0);
				for (int j = 0; j < criteriaCount; j++)
					temp = temp.ScalarMultiply(comparisonMatrix[i, j]);
				geomean[i] = (Pow(temp.Item1, power), Pow(temp.Item2, power), Pow(temp.Item3, power));
			}

			// Step 2 : Multiplying with Inverse Vector
			double L = 0, M = 0, U = 0;
			for (int i = 0; i < criteriaCount; i++)
			{
				L += geomean[i].Item1;
				M += geomean[i].Item2;
				U += geomean[i].Item3;
			}

			for (int i = 0; i < criteriaCount; i++)
			{
				var now = geomean[i];
				now = (now.Item1 / U, now.Item2 / M, now.Item3 / L);
				weights[i] = (now.Item1 + now.Item2 + now.Item3) / 3;
			}

			// Step 5: Normalization
			NormalizeBySum(ref weights);

			return weights;
		}

		public static double[] NormalizeBySum(ref double[] numbers)
		{
			int max = numbers.Length;
			double sum = numbers.Sum();
			for (int i = 0; i < max; i++)
				numbers[i] /= sum;
			return numbers;
		}
	}
}
