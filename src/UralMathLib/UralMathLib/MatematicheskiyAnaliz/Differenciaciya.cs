#region

using MathNet.Numerics;

#endregion

namespace Libraries.UralMathLib;

public static partial class UralMathLib
{
    public static partial class MatematicheskiyAnaliz
    {
        public static class Differenciaciya
        {
            public static drobch64 Proizvodnaya(celch16 x, Func<double, double> f) => new drobch64(Differentiate.FirstDerivative(f, (double)x.value));

            public static drobch64 Proizvodnaya(celch32 x, Func<double, double> f) => new drobch64(Differentiate.FirstDerivative(f, (double)x.value));

            public static drobch64 Proizvodnaya(celch64 x, Func<double, double> f) => new drobch64(Differentiate.FirstDerivative(f, (double)x.value));

            public static drobch64 Proizvodnaya(drobch16 x, Func<double, double> f) => new drobch64(Differentiate.FirstDerivative(f, (double)x.value));

            public static drobch64 Proizvodnaya(drobch32 x, Func<double, double> f) => new drobch64(Differentiate.FirstDerivative(f, (double)x.value));

            public static drobch64 Proizvodnaya(drobch64 x, Func<double, double> f) => new drobch64(Differentiate.FirstDerivative(f, (double)x.value));

            public static drobch64 VtorayaProizvodnaya(celch16 x, Func<double, double> f) => new drobch64(Differentiate.SecondDerivative(f, (double)x.value));

            public static drobch64 VtorayaProizvodnaya(celch32 x, Func<double, double> f) => new drobch64(Differentiate.SecondDerivative(f, (double)x.value));

            public static drobch64 VtorayaProizvodnaya(celch64 x, Func<double, double> f) => new drobch64(Differentiate.SecondDerivative(f, (double)x.value));

            public static drobch64 VtorayaProizvodnaya(drobch16 x, Func<double, double> f) => new drobch64(Differentiate.SecondDerivative(f, (double)x.value));

            public static drobch64 VtorayaProizvodnaya(drobch32 x, Func<double, double> f) => new drobch64(Differentiate.SecondDerivative(f, (double)x.value));

            public static drobch64 VtorayaProizvodnaya(drobch64 x, Func<double, double> f) => new drobch64(Differentiate.SecondDerivative(f, (double)x.value));

            public static drobch64 TretyaProizvodnaya(celch16 x, Func<double, double> f) => new drobch64(Differentiate.Derivative(f, (double)x.value, 3));

            public static drobch64 TretyaProizvodnaya(celch32 x, Func<double, double> f) => new drobch64(Differentiate.Derivative(f, (double)x.value, 3));

            public static drobch64 TretyaProizvodnaya(celch64 x, Func<double, double> f) => new drobch64(Differentiate.Derivative(f, (double)x.value, 3));

            public static drobch64 TretyaProizvodnaya(drobch16 x, Func<double, double> f) => new drobch64(Differentiate.Derivative(f, (double)x.value, 3));

            public static drobch64 TretyaProizvodnaya(drobch32 x, Func<double, double> f) => new drobch64(Differentiate.Derivative(f, (double)x.value, 3));

            public static drobch64 TretyaProizvodnaya(drobch64 x, Func<double, double> f) => new drobch64(Differentiate.Derivative(f, (double)x.value, 3));

            public static drobch64 NProizvodnaya(ushort n, double x, Func<double, double> f) => new drobch64(Differentiate.Derivative(f, x, n));

            /*
            public static drobch64 NProizvodnaya2(ushort n, double x, Func<double, double> f)
            {
                const double dx = 1.0e-15;

                double func_sum = 0;
                for (ushort i = 0; i <= n; i++)
                {
                    func_sum += Math.Pow(-1, i + n) * (double)UralMathLib.Statistics.Cm(n, i) * f((double)x + (double)i * dx);
                }

                return new drobch64(func_sum / Math.Pow(dx, n));
            }*/

            public static drobch64 NProizvodnaya(uint n, double x, Func<double, double> f) => new drobch64(Differentiate.Derivative(f, x, (int)n));

            public static drobch64 NProizvodnaya(ulong n, double x, Func<double, double> f) => new drobch64(Differentiate.Derivative(f, x, (int)n));

            public static drobch64 NProizvodnaya(natch16 n, drobch16 x, Func<double, double> f) => new drobch64(NProizvodnaya((ulong)n.value, (double)x.value, f));

            public static drobch64 NProizvodnaya(natch16 n, drobch32 x, Func<double, double> f) => new drobch64(NProizvodnaya((ulong)n.value, (double)x.value, f));

            public static drobch64 NProizvodnaya(natch16 n, drobch64 x, Func<double, double> f) => new drobch64(NProizvodnaya((ulong)n.value, (double)x.value, f));

            public static drobch64 NProizvodnaya(natch32 n, drobch16 x, Func<double, double> f) => new drobch64(NProizvodnaya((ulong)n.value, (double)x.value, f));

            public static drobch64 NProizvodnaya(natch32 n, drobch32 x, Func<double, double> f) => new drobch64(NProizvodnaya((ulong)n.value, (double)x.value, f));

            public static drobch64 NProizvodnaya(natch32 n, drobch64 x, Func<double, double> f) => new drobch64(NProizvodnaya((ulong)n.value, (double)x.value, f));

            public static drobch64 NProizvodnaya(natch64 n, drobch16 x, Func<double, double> f) => new drobch64(NProizvodnaya((ulong)n.value, (double)x.value, f));

            public static drobch64 NProizvodnaya(natch64 n, drobch32 x, Func<double, double> f) => new drobch64(NProizvodnaya((ulong)n.value, (double)x.value, f));

            public static drobch64 NProizvodnaya(natch64 n, drobch64 x, Func<double, double> f) => new drobch64(NProizvodnaya((ulong)n.value, (double)x.value, f));
        }
    }
}