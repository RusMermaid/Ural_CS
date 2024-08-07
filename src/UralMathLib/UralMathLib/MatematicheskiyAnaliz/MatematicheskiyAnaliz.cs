#region

using static Libraries.UralMathLib.UralMathLib.Statistics;

#endregion

namespace Libraries.UralMathLib;

public static partial class UralMathLib
{
    public static partial class MatematicheskiyAnaliz
    {
        public static double RiemannLiouville_Differintegral(int n, double a, double b, Func<double, double> f)
        {
            // Define the differintegral using the formula
            // I^n_a^b = 1/Gamma(n+1) * integral(f(x) * (x-a)^n, x, a, b)
            return 1.0 / Gamma((double)n + 1) * Integracia.SigmaSumma(a, b, f: i => f(i) * Math.Pow(i - a, n - 1));
        }

        public static double GrunwaldLetnikov_Differintegral(int n, double x, Func<double, double> f)
        {
            // Define the Grunwald-Letnikov differintegral using the formula
            // I^n_a^b = 1/h^n * sum((-1)^(k-1) * C(n,k-1) * f(x-kh), k, 1, n)
            // with a constant step size h = 1.0e-14
            double h = 1.0e-14;
            return 1.0 / Math.Pow(h, n) * Integracia.SigmaSumma(1, n, f: k => -1 * Cm(n, k - 1) * f(x - (k * h)));
        }

        public static double DoubleExponential(double n, double x, Func<double, double> f)
        {
            // see https://en.wikipedia.org/wiki/Differintegral

            if (Math.Abs(n) < double.Epsilon)
            {
                return f(x);
            }

            if ((n > 0) && (Math.Abs(n - (int)n) < double.Epsilon))
            {
                return (double)Differenciaciya.NProizvodnaya((uint)n, x, f);
            }

            int m = (int)Math.Ceiling(n) + 1;
            if (m < 1)
            {
                m = 1;
            }

            double r = m - n - 1;
            Func<double, double> g = v =>
                DoubleExponential(v, 0, f: t => Math.Pow(v - t, r) * f(t));
            double numerator = (double)Differenciaciya.NProizvodnaya((ulong)m, x, g);
            double denominator = Gamma(m - n);
            return numerator / denominator;
        }
    }
}