using System;
using System.Linq;

namespace KonSchool.FAHP;

public static class Inference
{
	public static (double, double, double)[,] ComparisonMatrix(int[] values)
	{
		int i;

		#region Validation
		if (values.Length < 5)
			throw new ArgumentException("At least 5 integers between -9 and +9 (inclusive) are expected");

		if (values.Any(v => v < -9 || v > 9))
			throw new ArgumentException("Fuzzy input must be between -9 and +9 (inclusive)");
		#endregion

		(double, double, double)[] TFNs =
		{
			(1, 1, 1), (1, 2, 3), (2, 3, 4),
			(3, 4, 5), (4, 5, 6), (5, 6, 7),
			(6, 7, 8), (7, 8, 9), (9, 9, 9)
		};


		(double, double, double)[,] CompMat = new (double, double, double)[6, 6];

		// First, equality

		for (int j = 0; j <= 5; j++)
			CompMat[j, j] = (1.0, 1.0, 1.0);

		// Then, setting the values from the 'values' array

		for (i = 0; i < 5; i++)
		{
			if (values[i] < 0)
				CompMat[i, i + 1] = TFNs[-1 - values[i]];
			else if (values[i] > 0)
				CompMat[i, i + 1] = TFNs[-1 + values[i]].Inverse();
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
		var (Left, Right) = GetMinMax(Items);
		double Middle = a.Item2 * b.Item2;
		return (Left, Middle, Right);
	}

	public static (double, double, double) Inverse(this (double, double, double) a)
		=> (1.0 / a.Item3, 1.0 / a.Item2, 1.0 / a.Item1);

	public static (double, double) GetMinMax(double[] values)
	{
		double min = values[0], max = values[0];
		for (int i = 1; i < values.Length; i++)
		{
			if (values[i] < min)
				min = values[i];
			if (values[i] > max)
				max = values[i];
		}
		return (min, max);
	}
}
