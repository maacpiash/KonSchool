using System.Linq;
using static System.Math;

namespace KonSchool.Shared
{
	public static class Stat
	{
		public static double StdDev(double[] values)
		{
			double ret = 0;
			if (values.Length > 0)
			{
				double avg = values.Average();
				double sum = values.Sum(d => Pow(d - avg, 2));
				ret = Sqrt(sum / (values.Length - 1));
			}
			return ret;
		}

		// The following is an implementation of CDF for standard normal distribution. I found this code at
		// https://sites.google.com/site/softwareincidentanalysis/Downhome/statistics-1/ccdfnormaldistribution

		public static double NORMDIST(double x, double mean, double std, bool cumulative)
			=> cumulative ? Phi(x, mean, std) : Exp(-0.5 * Pow((x - mean) / std, 2)) / (Sqrt(2 * PI) * std);

		static double erf(double z)
		{
			double t = 1.0 / (1.0 + 0.5 * Abs(z));
			double ans = 1 - t * Exp(-z * z - 1.26551223 + t * (1.00002368 + t * (0.37409196 + t * (0.09678418 +
			t * (-0.18628806 + t * (0.27886807 + t * (-1.13520398 + t * (1.48851587 + t * (-0.82215223 + t * (0.17087277))))))))));
			if (z >= 0) return ans;
			else return -ans;
		}

		static double Phi(double z) => 0.5 * (1.0 + erf(z / (Sqrt(2.0))));

		static double Phi(double z, double mu, double sigma) => Phi((z - mu) / sigma);
	}
}
