using System.Linq;

using static System.Math;

namespace KonSchool.Models
{
    public static class Stat
    {
        public static double[] NormalizeBySum(ref double[] numbers)
        {
            int max = numbers.Length;
            double sum = numbers.Sum();
            for (int i = 0; i < max; i++)
                numbers[i] /= sum;
            return numbers;
        }

        public static double[] NormalizeByLimits(ref double[] numbers, double lower = 0.0, double upper = 1.0)
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

        public static (double, double, double) ScalarMultiply
        (this (double, double, double) a, (double, double, double) b)
            => (a.Item1 * b.Item1, a.Item2 * b.Item2, a.Item3 * b.Item3);

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
