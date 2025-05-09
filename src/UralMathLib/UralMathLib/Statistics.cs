#region

using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

#endregion

namespace Libraries.UralMathLib;

public static partial class UralMathLib
{
    public static class Statistics
    {
        public static dynamic Mean(int [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<int, double>(0, func: (current, t) => current + ((t - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic Mean(double [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<double, double>(0, func: (current, t) => current + ((t - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic Mean(natch16 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<natch16, double>(0, func: (current, t) => current + (((double)t.value - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic Mean(natch32 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<natch32, double>(0, func: (current, t) => current + (((double)t.value - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic Mean(natch64 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<natch64, double>(0, func: (current, t) => current + (((double)t.value - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic Mean(celch16 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<celch16, double>(0, func: (current, t) => current + (((double)t.value - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic Mean(celch32 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<celch32, double>(0, func: (current, t) => current + (((double)t.value - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic Mean(celch64 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<celch64, double>(0, func: (current, t) => current + (((double)t.value - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic Mean(drobch16 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<drobch16, double>(0, func: (current, t) => current + (((double)t.value - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic Mean(drobch32 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<drobch32, double>(0, func: (current, t) => current + (((double)t.value - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic Mean(drobch64 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<drobch64, double>(0, func: (current, t) => current + (((double)t.value - current) / ++m));

            return new drobch64(mean);
        }

        public static dynamic GeometricMean(int [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic GeometricMean(double [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic GeometricMean(natch16 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic GeometricMean(natch32 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic GeometricMean(natch64 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic GeometricMean(celch16 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic GeometricMean(celch32 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic GeometricMean(celch64 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic GeometricMean(drobch16 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic GeometricMean(drobch32 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic GeometricMean(drobch64 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => (double)Ln(t));

            return Exp(sum / data.Length);
        }

        public static dynamic HarmonicMean(int [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => 1.0 / t);

            return new drobch64(data.Length / sum);
        }

        public static dynamic HarmonicMean(double [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => 1.0 / t);

            return new drobch64(data.Length / sum);
        }

        public static dynamic HarmonicMean(natch16 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Sum(selector: t => 1.0 / (double)t.value);

            return new drobch64(data.Length / sum);
        }

        public static dynamic HarmonicMean(natch64 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Cast<natch16>().Sum(selector: t => 1.0 / (double)t.value);

            return new drobch64(data.Length / sum);
        }

        public static dynamic HarmonicMean(celch16 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Cast<natch16>().Sum(selector: t => 1.0 / (double)t.value);

            return new drobch64(data.Length / sum);
        }

        public static dynamic HarmonicMean(celch32 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Cast<natch16>().Sum(selector: t => 1.0 / (double)t.value);

            return new drobch64(data.Length / sum);
        }

        public static dynamic HarmonicMean(celch64 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Cast<natch16>().Sum(selector: t => 1.0 / (double)t.value);

            return new drobch64(data.Length / sum);
        }

        public static dynamic HarmonicMean(drobch16 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Cast<natch16>().Sum(selector: t => 1.0 / (double)t.value);

            return new drobch64(data.Length / sum);
        }

        public static dynamic HarmonicMean(drobch32 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Cast<natch16>().Sum(selector: t => 1.0 / (double)t.value);

            return new drobch64(data.Length / sum);
        }

        public static dynamic HarmonicMean(drobch64 [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double sum = data.Cast<natch16>().Sum(selector: t => 1.0 / (double)t.value);

            return new drobch64(data.Length / sum);
        }

        public static dynamic Variance(int [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0];
            for (int i = 1; i < samples.Length; i++)
            {
                t += samples[i];
                double diff = ((i + 1) * samples[i]) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic Variance(double [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0];
            for (int i = 1; i < samples.Length; i++)
            {
                t += samples[i];
                double diff = ((i + 1) * samples[i]) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic Variance(natch16 [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0].value;
            for (int i = 1; i < samples.Length; i++)
            {
                t += (double)samples[i].value;
                double diff = ((i + 1) * samples[i]) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic Variance(natch32 [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0].value;
            for (int i = 1; i < samples.Length; i++)
            {
                t += (double)samples[i].value;
                double diff = ((i + 1) * samples[i]) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic Variance(natch64 [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0].value;
            for (int i = 1; i < samples.Length; i++)
            {
                t += (double)samples[i].value;
                double diff = ((i + 1) * (double)samples[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic Variance(celch16 [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0].value;
            for (int i = 1; i < samples.Length; i++)
            {
                t += (double)samples[i].value;
                double diff = ((i + 1) * (double)samples[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic Variance(celch32 [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0].value;
            for (int i = 1; i < samples.Length; i++)
            {
                t += (double)samples[i].value;
                double diff = ((i + 1) * (double)samples[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic Variance(celch64 [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0].value;
            for (int i = 1; i < samples.Length; i++)
            {
                t += (double)samples[i].value;
                double diff = ((i + 1) * (double)samples[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic Variance(drobch16 [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0].value;
            for (int i = 1; i < samples.Length; i++)
            {
                t += (double)samples[i].value;
                double diff = ((i + 1) * (double)samples[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic Variance(drobch32 [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0].value;
            for (int i = 1; i < samples.Length; i++)
            {
                t += (double)samples[i].value;
                double diff = ((i + 1) * (double)samples[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic Variance(drobch64 [] samples)
        {
            if (samples.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = samples[0].value;
            for (int i = 1; i < samples.Length; i++)
            {
                t += (double)samples[i].value;
                double diff = ((i + 1) * (double)samples[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / (samples.Length - 1));
        }

        public static dynamic PopulationVariance(int [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0];
            for (int i = 1; i < population.Length; i++)
            {
                t += population[i];
                double diff = ((i + 1) * population[i]) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static dynamic PopulationVariance(double [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0];
            for (int i = 1; i < population.Length; i++)
            {
                t += population[i];
                double diff = ((i + 1) * population[i]) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static dynamic PopulationVariance(natch16 [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0].value;
            for (int i = 1; i < population.Length; i++)
            {
                t += (double)population[i].value;
                double diff = ((i + 1) * population[i]) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static dynamic PopulationVariance(natch32 [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0].value;
            for (int i = 1; i < population.Length; i++)
            {
                t += (double)population[i].value;
                double diff = ((i + 1) * population[i]) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static dynamic PopulationVariance(natch64 [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0].value;
            for (int i = 1; i < population.Length; i++)
            {
                t += (double)population[i].value;
                double diff = ((i + 1) * (double)population[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static dynamic PopulationVariance(celch16 [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0].value;
            for (int i = 1; i < population.Length; i++)
            {
                t += (double)population[i].value;
                double diff = ((i + 1) * (double)population[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static dynamic PopulationVariance(celch32 [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0].value;
            for (int i = 1; i < population.Length; i++)
            {
                t += (double)population[i].value;
                double diff = ((i + 1) * (double)population[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static dynamic PopulationVariance(celch64 [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0].value;
            for (int i = 1; i < population.Length; i++)
            {
                t += (double)population[i].value;
                double diff = ((i + 1) * (double)population[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static dynamic PopulationVariance(drobch16 [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0].value;
            for (int i = 1; i < population.Length; i++)
            {
                t += (double)population[i].value;
                double diff = ((i + 1) * (double)population[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static dynamic PopulationVariance(drobch32 [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0].value;
            for (int i = 1; i < population.Length; i++)
            {
                t += (double)population[i].value;
                double diff = ((i + 1) * (double)population[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static dynamic PopulationVariance(drobch64 [] population)
        {
            if (population.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double variance = 0;
            double t = population[0].value;
            for (int i = 1; i < population.Length; i++)
            {
                t += (double)population[i].value;
                double diff = ((i + 1) * (double)population[i].value) - t;
                variance += diff * diff / ((i + 1.0) * i);
            }

            return new drobch64(variance / population.Length);
        }

        public static drobch64 StandardDeviation(int [] samples) => Sqrt(Variance(samples));

        public static drobch64 StandardDeviation(double [] samples) => Sqrt(Variance(samples));

        public static drobch64 StandardDeviation(natch16 [] samples) => Sqrt(Variance(samples));

        public static drobch64 StandardDeviation(natch32 [] samples) => Sqrt(Variance(samples));

        public static drobch64 StandardDeviation(natch64 [] samples) => Sqrt(Variance(samples));

        public static drobch64 StandardDeviation(celch16 [] samples) => Sqrt(Variance(samples));

        public static drobch64 StandardDeviation(celch32 [] samples) => Sqrt(Variance(samples));

        public static drobch64 StandardDeviation(celch64 [] samples) => Sqrt(Variance(samples));

        public static drobch64 StandardDeviation(drobch16 [] samples) => Sqrt(Variance(samples));

        public static drobch64 StandardDeviation(drobch32 [] samples) => Sqrt(Variance(samples));

        public static drobch64 StandardDeviation(drobch64 [] samples) => Sqrt(Variance(samples));

        public static dynamic Covariance(double [] samples1, double [] samples2)
        {
            if (samples1.Length != samples2.Length)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            if (samples1.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double mean1 = samples1.AsQueryable().Average();
            double mean2 = samples2.AsQueryable().Average();
            double covariance = samples1.Select(selector: (t, i) => (t - mean1) * (samples2[i] - mean2)).Sum();

            return covariance / (samples1.Length - 1);
        }

        public static dynamic RootMeanSquare(double [] data)
        {
            if (data.Length == 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            ulong m = 0;
            double mean = data.Aggregate<double, double>(0, func: (current, t) => current + (((t * t) - current) / ++m));

            return (double)Sqrt(mean);
        }

        public static dynamic Variations(int n, int k)
        {
            if (!((k < 0) | (n < 0) | (k > n)))
            {
                return Math.Floor(
                    0.5 + Math.Exp(Factorial(n) - Factorial(n - k)));
            }

            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        private static double Erf(double x)
        {
            Func<double, double> t1 = x => 1.0 / (1.0 + (0.5 * Math.Abs(x)));

            Func<double, double> t2 = t => t * Math.Exp(-Math.Pow(t, 2) - 1.26551223 + (1.00002368 * t)
                                                                                     + (0.37409196 * Math.Pow(t, 2)) + (0.09678418 * Math.Pow(t, 3))
                - (0.18628806 * Math.Pow(t, 4)) + (0.27886807 * Math.Pow(t, 5))
                - (1.13520398 * Math.Pow(t, 6)) + (1.48851587 * Math.Pow(t, 7))
                - (0.82215223 * Math.Pow(t, 8)) + (0.17087277 * Math.Pow(t, 9)));

            double t = t2(t1(x));
            return x >= 0 ? 1 - t : t - 1;
        }

        public static celch16 Erf(celch16 c) => new celch16(Erf((double)c));

        public static celch32 Erf(celch32 c) => new celch32(Erf((double)c));

        public static celch64 Erf(celch64 c) => new celch64(Erf((double)c));

        public static drobch16 Erf(drobch16 c) => new drobch16(Erf((double)c));

        public static drobch32 Erf(drobch32 c) => new drobch32(Erf((double)c));

        public static drobch64 Erf(drobch64 c) => new drobch64(Erf((double)c));

        private static double Erfc(double x)
        {
            double Erfc_c(double t) =>
                0.56418958354775629 / (t + 2.06955023132914151)
                * ((Math.Pow(t, 2) + (2.71078540045147805 * t) + 5.80755613130301624) /
                   (Math.Pow(t, 2) + (3.47954057099518960 * t) + 12.06166887286239555))
                * ((Math.Pow(t, 2) + (3.47469513777439592 * t) + 12.07402036406381411) /
                   (Math.Pow(t, 2) + (3.72068443960225092 * t) + 8.44319781003968454))
                * ((Math.Pow(t, 2) + (4.00561509202259545 * t) + 9.30596659485887898) /
                   (Math.Pow(t, 2) + (3.90225704029924078 * t) + 6.36161630953880464))
                * ((Math.Pow(t, 2) + (5.16722705817812584 * t) + 9.12661617673673262) /
                   (Math.Pow(t, 2) + (4.03296893109262491 * t) + 5.13578530585681539))
                * ((Math.Pow(t, 2) + (5.95908795446633271 * t) + 9.19435612886969243) /
                   (Math.Pow(t, 2) + (4.11240942957450885 * t) + 4.48640329523408675))
                * Math.Exp(-1 * Math.Pow(t, 2));

            return x >= 0 ? Erfc_c(x) : 2 - Erfc_c(-1 * x);
        }

        public static celch16 Erfc(celch16 c) => new celch16(Erfc((double)c));

        public static celch32 Erfc(celch32 c) => new celch32(Erfc((double)c));

        public static celch64 Erfc(celch64 c) => new celch64(Erfc((double)c));

        public static drobch16 Erfc(drobch16 c) => new drobch16(Erfc((double)c));

        public static drobch32 Erfc(drobch32 c) => new drobch32(Erfc((double)c));

        public static drobch64 Erfc(drobch64 c) => new drobch64(Erfc((double)c));

        // Calculate the combination Cm(n, i) = n! / (i! * (n-i)!)
        public static double Cm(int n, int i) => Pm(n, i) / (double)Factorial(i).value;

        public static double Pm(int n, int i) => (double)Factorial(n).value / (double)Factorial(n - i).value;

        public static List<dynamic> Pms(dynamic [] iterable, int r)
        {
            dynamic [] pool = (dynamic [])iterable.Clone();
            int n = pool.Length;
            if (r > n)
            {
                r = pool.Length;
            }

            int [] indices = Enumerable.Range(0, n).ToArray();
            int [] cycles = Enumerable.Range(0, r).Select(selector: i => n - i).ToArray();
            List<dynamic> result = new List<dynamic>(indices.Take(r).Select(selector: x => pool[x]));

            bool flag = true;
            while (flag)
            {
                int i;
                for (i = r - 1; i >= 0; i--)
                {
                    cycles[i]--;
                    if (cycles[i] == 0)
                    {
                        Array.Copy(indices, i + 1, indices, i, n - i - 1);
                        indices[n - 1] = i;
                        cycles[i] = n - i;
                    }
                    else
                    {
                        int j = cycles[i];
                        (indices[i], indices[n - j]) = (indices[n - j], indices[i]);
                        result.AddRange(indices.Take(r).Select(selector: x => pool[x]));
                        break;
                    }
                }

                if (i < 0)
                {
                    flag = false;
                }
            }

            return result;
        }

        public static List<dynamic> Pms(dynamic [] iterable) => Pms(iterable, iterable.Length);

        public static dynamic Binomial(int n, int k)
        {
            if ((k < 0) | (n < 0) | (k > n))
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return Math.Floor(0.5 + Math.Exp(Factorial(n) - Factorial(k) -
                                             Factorial(n - k)));
        }

        public static celch16 SummaPath(massiv<massiv<celch16>> mtx)
        {
            celch16 [] [] grid = VOID.Array2List_2D(mtx.value);

            int rows = grid.Length;
            int cols = grid[0].Length;

            int [] minPathSum = new int[cols];
            minPathSum[0] = (int)grid[0][0];

            Enumerable.Range(1, cols - 1).Aggregate(0, func: (acc, col) => minPathSum[col] = grid[0][col] + minPathSum[col - 1]);

            for (int row = 1; row < rows; row++)
                minPathSum = minPathSum.Select(selector: (value, col) =>
                    (int)(col > 0 ? grid[row][col] + Math.Min(minPathSum[col - 1], value) : value + grid[row][col])).ToArray();

            return new celch16(minPathSum[cols - 1]);
        }

        public static celch32 SummaPath(massiv<massiv<celch32>> mtx)
        {
            celch32 [] [] grid = VOID.Array2List_2D(mtx.value);

            int rows = grid.Length;
            int cols = grid[0].Length;

            int [] minPathSum = new int[cols];
            minPathSum[0] = (int)grid[0][0];

            Enumerable.Range(1, cols - 1).Aggregate(0, func: (acc, col) => minPathSum[col] = grid[0][col] + minPathSum[col - 1]);

            for (int row = 1; row < rows; row++)
                minPathSum = minPathSum.Select(selector: (value, col) =>
                    (int)(col > 0 ? grid[row][col] + Math.Min(minPathSum[col - 1], value) : value + grid[row][col])).ToArray();

            return new celch32(minPathSum[cols - 1]);
        }

        public static celch64 SummaPath(massiv<massiv<celch64>> mtx)
        {
            celch64 [] [] grid = VOID.Array2List_2D(mtx.value);

            int rows = grid.Length;
            int cols = grid[0].Length;

            long [] minPathSum = new long[cols];
            minPathSum[0] = (long)grid[0][0];

            minPathSum = Enumerable.Range(1, cols - 1)
                .Aggregate(new [] { (long)grid[0][0] }, func: (acc, col) =>
                {
                    acc = acc.Concat(new long [] { acc.Last() + grid[0][col] }).ToArray();
                    return acc;
                });

            for (int row = 1; row < rows; row++)
                minPathSum = minPathSum.Select(selector: (value, col) =>
                    (long)(col > 0 ? grid[row][col] + Math.Min(minPathSum[col - 1], value) : value + grid[row][col])).ToArray();

            return new celch64(minPathSum[cols - 1]);
        }

        public static dynamic Fit(double [] x, double [] y)
        {
            if (x.Length != y.Length)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            if (x.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double mx = 0.0;
            double my = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                mx += x[i];
                my += y[i];
            }

            mx /= x.Length;
            my /= y.Length;
            double covariance = 0.0;
            double variance = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                double diff = x[i] - mx;
                covariance += diff * (y[i] - my);
                variance += diff * diff;
            }

            double b = covariance / variance;
            return new [] { my - (b * mx), b };
        }

        public static dynamic FitThroughOrigin(double [] x, double [] y)
        {
            if (x.Length != y.Length)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            if (x.Length <= 1)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            double mxy = 0.0;
            double mxx = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                mxx += x[i] * x[i];
                mxy += x[i] * y[i];
            }

            return mxy / mxx;
        }
    }
}