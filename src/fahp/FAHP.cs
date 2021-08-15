using static System.Math;
using static KonSchool.Shared.Stat;

namespace KonSchool.FAHP;

public class FAHP
{
	public readonly int CriteriaCount;
	public double[] CriteriaWeights { get; set; }
	public (double, double, double)[,] ComparisonMatrix;

	public FAHP((double, double, double)[,] ComparisonMatrix)
	{
		CriteriaCount = ComparisonMatrix.GetLength(0);
		this.ComparisonMatrix = ComparisonMatrix;
		CriteriaWeights = IsValid() ? RunFAHP() : new double[CriteriaCount];
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
