using System;
using static System.Math;

// This class contains an implementation of CDF for standard normal distribution. I found this code at
// https://sites.google.com/site/softwareincidentanalysis/Downhome/statistics-1/ccdfnormaldistribution

namespace KonSchool.Models
{
    public static class Stat
    {
        public static double NORMDIST(double x, double mean, double std, bool cumulative)
            => cumulative ? Phi(x, mean, std)
                : Exp(-0.5 * Pow((x - mean) / std, 2)) / (Sqrt(2 * PI) * std);
        
        static double erf(double z)
        {
            double t = 1.0 / (1.0 + 0.5 * Abs(z));
            double ans = 1 - t * Exp(- z * z - 1.26551223 + t * (1.00002368 + t * (0.37409196 + t * (0.09678418 +
            t * (-0.18628806 + t * (0.27886807 + t * (-1.13520398 + t * (1.48851587 + t * (-0.82215223 + t * ( 0.17087277))))))))));
            if (z >= 0) return ans;
            else return -ans;
        }

        static double Phi(double z)
            => 0.5 * (1.0 + erf(z / (Math.Sqrt(2.0))));
        
        static double Phi(double z, double mu, double sigma)
            => Phi((z - mu) / sigma);
        
        internal static void ScalarMultiply (  // scalar multiplication of two 3D vectors
            ref ValueTuple<double, double, double> t1,
            ValueTuple<double, double, double> t2
        ) => t1 = (t1.Item1 * t2.Item1, t1.Item2 * t2.Item2, t1.Item3 * t2.Item3);
    }
}