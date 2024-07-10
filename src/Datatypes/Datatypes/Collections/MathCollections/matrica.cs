using Errors.SyntaxInvalidError.ErrorDatatypes;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;
using Libraries.UralMathLib;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace Datatypes.Collections.MathCollections
{

    public interface Interface_UMathNumerics
    {
    }
    
    public class matrica : VOID, IEnumerable, Interface_UMathNumerics, Interface_Ural_Datatype
    {
        public ulong MaxLength = 4294967295U;
        public Interface_UMathNumerics[,] value;
        public readonly kortezh Count;

        public matrica(ushort n)
        {
            this.value = new drobch64[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    this.value[i, j] = (i == j) ? new drobch64(1.0) : new drobch64(0.0);
                }
            }

            this.Count = new kortezh(new natch16(n), new natch16(n));
        }

        public matrica(uint n)
        {
            this.value = new drobch64[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    this.value[i, j] = (i == j) ? new drobch64(1.0) : new drobch64(0.0);
                }
            }

            this.Count = new kortezh(new natch16(n), new natch16(n));
        }

        public matrica(ulong n)
        {
            this.value = new drobch64[n, n];
            for (long i = 0; i < (long)n; i++)
            {
                for (long j = 0; j < (long)n; j++)
                {
                    this.value[i, j] = (i == j) ? new drobch64(1.0) : new drobch64(0.0);
                }
            }

            this.Count = new kortezh(new natch16(n), new natch16(n));
        }

        public matrica(natch16 n)
        {
            this.value = new drobch64[(ushort)n, (ushort)n];
            for (int i = 0; i < (ushort)n; i++)
            {
                for (int j = 0; j < (ushort)n; j++)
                {
                    this.value[i, j] = (i == j) ? new drobch64(1.0) : new drobch64(0.0);
                }
            }

            this.Count = new kortezh(new natch16(n), new natch16(n));
        }

        public matrica(natch32 n)
        {
            this.value = new drobch64[(uint)n, (uint)n];
            for (int i = 0; i < (uint)n; i++)
            {
                for (int j = 0; j < (uint)n; j++)
                {
                    this.value[i, j] = (i == j) ? new drobch64(1.0) : new drobch64(0.0);
                }
            }

            this.Count = new kortezh(new natch16(n), new natch16(n));
        }

        public matrica(natch64 n)
        {
            this.value = new drobch64[(ulong)n, (ulong)n];
            for (long i = 0; i < (long)n; i++)
            {
                for (long j = 0; j < (long)n; j++)
                {
                    this.value[i, j] = (i == j) ? new drobch64(1.0) : new drobch64(0.0);
                }
            }

            this.Count = new kortezh(new natch16(n), new natch16(n));
        }

        public matrica(short[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch16(mtx.GetLength(0)), new natch16(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch16(mtx.GetLength(0)), new natch16(mtx.GetLength(1)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<short>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch16(mtx[0].Count), new natch16(mtx.Count));
            }
            else
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch16(mtx[0].Count), new natch16(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(int[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(1), mtx.GetLength(1)];
                this.Count = new kortezh(new natch32(mtx.GetLength(1)), new natch32(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(0)];
                this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(0)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<int>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx.Count));
            }
            else
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(long[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(1)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<long>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx.Count));
            }
            else
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(float[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(1)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<float>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx.Count));
            }
            else
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(double[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(1)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<double>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx.Count));
            }
            else
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(celch16[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch16(mtx.GetLength(0)), new natch16(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch16(mtx.GetLength(0)), new natch16(mtx.GetLength(1)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<celch16>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx[0].Count];
                this.Count = new kortezh(new natch16(mtx[0].Count), new natch16(mtx[0].Count));
            }
            else
            {
                this.value = new drobch64[mtx.Count, mtx.Count];
                this.Count = new kortezh(new natch16(mtx.Count), new natch16(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(celch32[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(1)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<celch32>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx.Count));
            }
            else
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(celch64[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(1)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<celch64>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx.Count));
            }
            else
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(drobch16[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch16(mtx.GetLength(0)), new natch16(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch16(mtx.GetLength(0)), new natch16(mtx.GetLength(1)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<drobch16>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch16(mtx[0].Count), new natch16(mtx.Count));
            }
            else
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch16(mtx[0].Count), new natch16(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(drobch32[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(1)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<drobch32>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx.Count));
            }
            else
            {
                this.value = new drobch64[mtx[0].Count, mtx.Count];
                this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(drobch64[,] mtx)
        {
            if (mtx.GetLength(0) >= mtx.GetLength(1))
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(1)));
            }
            else
            {
                this.value = new drobch64[mtx.GetLength(0), mtx.GetLength(1)];
                this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(1)));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public matrica(List<List<drobch64>> mtx)
        {
            if (mtx.Count >= mtx[0].Count)
            {
                this.value = new drobch64[mtx[0].Count, mtx[0].Count];
                this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx.Count));
            }
            else
            {
                this.value = new drobch64[mtx.Count, mtx.Count];
                this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx.Count));
            }

            for (int i = 0; i < (int)(this.Count[0]); i++)
            {
                for (int j = 0; j < (int)(this.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i][j]);
                }
            }
        }

        public matrica(matrica mtx)
        {
            this.value = new drobch64[mtx.value.GetLength(0), mtx.value.GetLength(1)];
            this.Count = new kortezh(new natch64(mtx.value.GetLength(0)), new natch64(mtx.value.GetLength(1)));
            for (ulong i = 0; i < (ulong)(mtx.Count[0]); i++)
            {
                for (ulong j = 0; j < (ulong)(mtx.Count[0]); j++)
                {
                    this.value[i, j] = new drobch64(mtx[i, j]);
                }
            }
        }

        public drobch64 this[ushort x, ushort y]
        {
            get => (drobch64)this.value[x, y];
            set
            {
                try
                {
                    this.value[x, y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[x, y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[uint x, uint y]
        {
            get => (drobch64)this.value[x, y];
            set
            {
                try
                {
                    this.value[x, y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[x, y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[ulong x, ulong y]
        {
            get => (drobch64)this.value[x, y];
            set
            {
                try
                {
                    this.value[x, y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[x, y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[natch16 x, natch16 y]
        {
            get => (drobch64)this.value[(ushort)x, (ushort)y];
            set
            {
                try
                {
                    this.value[x.value, y.value] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[(ushort)x, (ushort)y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[natch16 x, natch32 y]
        {
            get => (drobch64)this.value[(uint)x, (uint)y];
            set
            {
                try
                {
                    this.value[(uint)x, (uint)y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[(uint)x, (uint)y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[natch16 x, natch64 y]
        {
            get => (drobch64)this.value[(ulong)x, (ulong)y];
            set
            {
                try
                {
                    this.value[(ulong)x, (ulong)y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[(ulong)x, (ulong)y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[natch32 x, natch16 y]
        {
            get => (drobch64)this.value[(uint)x, (uint)y];
            set
            {
                ;
                try
                {
                    this.value[(uint)x, (uint)y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[(uint)x, (uint)y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[natch32 x, natch32 y]
        {
            get => (drobch64)this.value[(uint)x, (uint)y];
            set
            {
                try
                {
                    this.value[(uint)x, (uint)y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[(uint)x, (uint)y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[natch32 x, natch64 y]
        {
            get => (drobch64)this.value[(ulong)x, (ulong)y];
            set
            {
                try
                {
                    this.value[(ulong)x, (ulong)y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[(ulong)x, (ulong)y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[natch64 x, natch16 y]
        {
            get => (drobch64)this.value[(ulong)x, (ulong)y];
            set
            {
                try
                {
                    this.value[(ulong)x, (ulong)y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[(ulong)x, (ulong)y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[natch64 x, natch32 y]
        {
            get => (drobch64)this.value[(ulong)x, (ulong)y];
            set
            {
                try
                {
                    this.value[(ulong)x, (ulong)y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[(ulong)x, (ulong)y] = (drobch64)value;
                }
            }
        }

        public drobch64 this[natch64 x, natch64 y]
        {
            get => (drobch64)this.value[(ulong)x, (ulong)y];
            set
            {
                try
                {
                    this.value[(ulong)x, (ulong)y] = value;
                }
                catch (InvalidCastException)
                {
                    this.value[(ulong)x, (ulong)y] = (drobch64)value;
                }
            }
        }
        
        public static matrica operator +(matrica l, VOID r)
        {
            return l;
        }
        
        public static matrica operator +(VOID l, matrica r)
        {
            return r;
        }
        
        public static matrica operator +(matrica l, int r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r);
        }
        
        public static matrica operator +(matrica l, float r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r);
        }
        
        public static matrica operator +(matrica l, double r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r);
        }
        
        public static matrica operator +(matrica l, natch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r.value);
        }
        
        public static matrica operator +(matrica l, natch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r.value);
        }
        
        public static matrica operator +(matrica l, natch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r.value);
        }
        
        public static matrica operator +(matrica l, celch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r.value);
        }
        
        public static matrica operator +(matrica l, celch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r.value);
        }
        
        public static matrica operator +(matrica l, celch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r.value);
        }
        
        public static matrica operator +(matrica l, drobch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r.value);
        }
        
        public static matrica operator +(matrica l, drobch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r.value);
        }
        
        public static matrica operator +(matrica l, drobch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r.value);
        }
        
        public static matrica operator +(matrica l, matrica r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r);
        }
        
        public static matrica operator +(int l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(float l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(double l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(natch16 l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(natch32 l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(natch64 l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(celch16 l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(celch32 l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(celch64 l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(drobch16 l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(drobch32 l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator +(drobch64 l, matrica r)
        {
            return r + l;
        }
        
        public static matrica operator -(matrica l, VOID r)
        {
            return l;
        }
        
        public static matrica operator -(VOID l, matrica r)
        {
            return r;
        }
        
        public static matrica operator -(matrica l, int r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r);
        }
        
        public static matrica operator -(matrica l, float r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r);
        }
        
        public static matrica operator -(matrica l, double r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(r);
        }
        
        public static matrica operator -(matrica l, natch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(-r.value);
        }
        
        public static matrica operator -(matrica l, natch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(-r.value);
        }
        
        public static matrica operator -(matrica l, natch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(-r.value);
        }
        
        public static matrica operator -(matrica l, celch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(-r.value);
        }
        
        public static matrica operator -(matrica l, celch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(-r.value);
        }
        
        public static matrica operator -(matrica l, celch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(-r.value);
        }
        
        public static matrica operator -(matrica l, drobch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(-r.value);
        }
        
        public static matrica operator -(matrica l, drobch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(-r.value);
        }
        
        public static matrica operator -(matrica l, drobch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Add(-r.value);
        }
        
        public static matrica operator -(matrica l, matrica r)
        {
            matrica l2 = new matrica(l);
            matrica r2 = new matrica(r);
            
            return l2.___Add(-r2);
        }
        
        public static matrica operator -(int l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(float l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(double l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(natch16 l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(natch32 l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(natch64 l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(celch16 l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(celch32 l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(celch64 l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(drobch16 l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(drobch32 l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(drobch64 l, matrica r)
        {
            return (-r) + l;
        }
        
        public static matrica operator -(matrica l)
        {
            matrica l2 = new matrica(l);
            
            for (int i = 0; i < l2.value.GetLength(0); i++)
            {
                for (int j = 0; j < l2.value.GetLength(1); j++)
                {
                    l2[(ulong)i, (ulong)j] = (drobch64)l2[(ulong)i, (ulong)j] * -1;
                }
            }
            
            return l2;
        }
        
        public static matrica operator *(matrica l, VOID r)
        {
            return l;
        }
        
        public static matrica operator *(VOID l, matrica r)
        {
            return r;
        }
        
        public static matrica operator *(matrica l, int r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static matrica operator *(matrica l, float r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static matrica operator *(matrica l, double r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static matrica operator *(matrica l, natch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r.value);
        }
        
        public static matrica operator *(matrica l, natch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r.value);
        }
        
        public static matrica operator *(matrica l, natch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r.value);
        }
        
        public static matrica operator *(matrica l, celch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r.value);
        }
        
        public static matrica operator *(matrica l, celch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r.value);
        }
        
        public static matrica operator *(matrica l, celch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r.value);
        }
        
        public static matrica operator *(matrica l, drobch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r.value);
        }
        
        public static matrica operator *(matrica l, drobch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r.value);
        }
        
        public static matrica operator *(matrica l, drobch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r.value);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<short> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<int> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<long> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<float> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<double> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<celch16> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<celch32> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<celch64> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<drobch16> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<drobch32> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static massiv<drobch64> operator *(matrica l, massiv<drobch64> r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static matrica operator *(matrica l, matrica r)
        {
            matrica l2 = new matrica(l);
            return l2.___Multiply(r);
        }
        
        public static matrica operator *(int l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(float l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(double l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(natch16 l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(natch32 l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(natch64 l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(celch16 l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(celch32 l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(celch64 l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(drobch16 l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(drobch32 l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator *(drobch64 l, matrica r)
        {
            return r * l;
        }
        
        public static matrica operator /(matrica l, VOID r)
        {
            return l;
        }
        
        public static matrica operator /(VOID l, matrica r)
        {
            return r;
        }
        
        public static matrica operator /(matrica l, int r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r);
        }
        
        public static matrica operator /(matrica l, float r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r); 
        }
        
        public static matrica operator /(matrica l, double r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r);
        }
        
        public static matrica operator /(matrica l, natch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r.value);
        }
        
        public static matrica operator /(matrica l, natch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r.value);
        }
        
        public static matrica operator /(matrica l, natch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r.value);
        }
        
        public static matrica operator /(matrica l, celch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r.value);
        }
        
        public static matrica operator /(matrica l, celch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r.value);
        }
        
        public static matrica operator /(matrica l, celch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r.value);
        }
        
        public static matrica operator /(matrica l, drobch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r.value);
        }
        
        public static matrica operator /(matrica l, drobch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r.value);
        }
        
        public static matrica operator /(matrica l, drobch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r.value);
        }
        
        public static matrica operator /(int l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(float l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(double l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(natch16 l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(natch32 l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(natch64 l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(celch16 l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(celch32 l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(celch64 l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(drobch16 l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(drobch32 l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(drobch64 l, matrica r)
        {
            return r.___Inverse() * l;
        }
        
        public static matrica operator /(matrica l, matrica r)
        {
            matrica l2 = new matrica(l);
            return l2.___Divide(r);
        }
        
        public static matrica operator ^(matrica l, VOID r)
        {
            return l;
        }
        
        public static matrica operator ^(VOID l, matrica r)
        {
            return r;
        }
        
        public static matrica operator ^(matrica l, int r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r);
        }
        
        public static matrica operator ^(matrica l, float r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r);
        }
        
        public static matrica operator ^(matrica l, double r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r);
        }
        
        public static matrica operator ^(matrica l, natch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r.value);
        }
        
        public static matrica operator ^(matrica l, natch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r.value);
        }
        
        public static matrica operator ^(matrica l, natch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r.value);
        }
        
        public static matrica operator ^(matrica l, celch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r.value);
        }
        
        public static matrica operator ^(matrica l, celch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r.value);
        }
        
        public static matrica operator ^(matrica l, celch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r.value);
        }
        
        public static matrica operator ^(matrica l, drobch16 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r.value);
        }
        
        public static matrica operator ^(matrica l, drobch32 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r.value);
        }
        
        public static matrica operator ^(matrica l, drobch64 r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r.value);
        }

        public static matrica operator ^(matrica l, matrica r)
        {
            matrica l2 = new matrica(l);
            return l2.___Pow(r);
        }

        public static matrica operator ^(int l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(float l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(double l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(natch16 l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(natch32 l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(natch64 l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(celch16 l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(celch32 l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(celch64 l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(drobch16 l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(drobch32 l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public static matrica operator ^(drobch64 l, matrica r)
        {
            return (r * UralMathLib.Ln(l)).___Exp();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < (int)this.Count[0]; i++)
            {
                drobch64[] row = Enumerable.Range(0, (int)this.Count[1])
                    .Select(j => (drobch64)this.value[i, j])
                    .ToArray();
                
                yield return new massiv<drobch64>(row); 
            }
        }

        protected static matrica ChisloMatrica(Interface_UDrobch value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (short i = 0; i < scales; i++)
            {
                mtx[new natch16(i), new natch16(i)] = (drobch64)value;
            }

            return mtx;
        }

        protected static matrica ChisloMatrica(Interface_UDrobch value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (int i = 0; i < scales; i++)
            {
                mtx[new natch16(i), new natch16(i)] = (drobch64)value;
            }

            return mtx;
        }

        protected static matrica ChisloMatrica(Interface_UDrobch value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (long i = 0; i < (long)scales; i++)
            {
                mtx[new natch16(i), new natch16(i)] = (drobch64)value;
            }

            return mtx;
        }

        protected static matrica ChisloMatrica(Interface_UDrobch value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (short i = 0; i < (short)scales; i++)
            {
                mtx[new natch16(i), new natch16(i)] = (drobch64)value;
            }

            return mtx;
        }

        protected static matrica ChisloMatrica(Interface_UDrobch value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (int i = 0; i < (int)scales; i++)
            {
                mtx[new natch16(i), new natch16(i)] = (drobch64)value;
            }

            return mtx;
        }

        protected static matrica ChisloMatrica(Interface_UDrobch value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (long i = 0; i < (long)scales; i++)
            {
                mtx[new natch16(i), new natch16(i)] = (drobch64)value;
            }

            return mtx;
        }


        public matrica ___Extends(ushort scales)
        {
            ushort oldN = (ushort)this.value.GetLength(0);

            matrica result = new matrica((uint)(oldN + scales));

            for (int i = 0; i < oldN; i++)
            {
                for (int j = 0; j < oldN; j++)
                {
                    result.value[i, j] = this.value[i, j];
                }
            }

            for (ushort i = oldN; i < oldN + scales; i++)
            {
                for (ushort j = oldN; j < oldN + scales; j++)
                {
                    result.value[i, j] = i == j ? new drobch64(1.0) : new drobch64(0.0);
                }
            }

            return result;
        }

        public RCI ___Equals(matrica mtx)
        {
            RCI flag = new RCI(true);
            mtx = mtx.___Extends((ulong)this.Count[0] - (ulong)mtx.Count[0]);
            for (ulong i = 0; i < (ulong)this.Count[0]; i++)
            {
                for (ulong j = 0; j < (ulong)this.Count[1]; j++)
                {
                    flag *= this[i, j].___Equals(mtx[i, j]);
                }
            }

            return flag;
        }

        public RCI ___GreaterThan(matrica mtx)
        {
            RCI flag = new RCI(true);
            mtx = mtx.___Extends((ulong)this.Count[0] - (ulong)mtx.Count[0]);
            for (ulong i = 0; i < (ulong)this.Count[0]; i++)
            {
                for (ulong j = 0; j < (ulong)this.Count[1]; j++)
                {
                    flag *= this[i, j].___GreaterThan(mtx[i, j]);
                }
            }

            return flag;
        }

        public RCI ___GreaterThan(short _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterThan(int _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterThan(long _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterThan(float _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterThan(double _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterThan(celch16 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterThan(celch32 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterThan(celch64 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterThan(drobch16 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterThan(drobch32 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterThan(drobch64 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(matrica mtx)
        {
            RCI flag = new RCI(true);
            mtx = mtx.___Extends((ulong)this.Count[0] - (ulong)mtx.Count[0]);
            for (ulong i = 0; i < (ulong)this.Count[0]; i++)
            {
                for (ulong j = 0; j < (ulong)this.Count[1]; j++)
                {
                    flag *= this[i, j].___SmallerThan(mtx[i, j]);
                }
            }

            return flag;
        }

        public RCI ___SmallerThan(short _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(int _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(long _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(float _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(double _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(celch16 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(celch32 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(celch64 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(drobch16 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(drobch32 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerThan(drobch64 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(matrica mtx)
        {
            RCI flag = new RCI(true);
            mtx = mtx.___Extends((ulong)this.Count[0] - (ulong)mtx.Count[0]);
            for (ulong i = 0; i < (ulong)this.Count[0]; i++)
            {
                for (ulong j = 0; j < (ulong)this.Count[1]; j++)
                {
                    flag *= this[i, j].___GreaterOrEqualThan(mtx[i, j]);
                }
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(short _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(int _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(long _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(float _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(double _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(celch16 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(celch32 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(celch64 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(drobch16 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(drobch32 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___GreaterOrEqualThan(drobch64 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___GreaterOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(matrica mtx)
        {
            RCI flag = new RCI(true);
            mtx = mtx.___Extends((ulong)this.Count[0] - (ulong)mtx.Count[0]);
            for (ulong i = 0; i < (ulong)this.Count[0]; i++)
            {
                for (ulong j = 0; j < (ulong)this.Count[1]; j++)
                {
                    flag *= this[i, j].___SmallerOrEqualThan(mtx[i, j]);
                }
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(short _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(int _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(long _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(float _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(double _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(celch16 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(celch32 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(celch64 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(drobch16 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(drobch32 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public RCI ___SmallerOrEqualThan(drobch64 _value)
        {
            RCI flag = new RCI(true);
            massiv<dynamic> eigenvalues = this.___SobZnacheniya();
            for (ulong i = 0; i < (ulong)eigenvalues.value.Count; i++)
            {
                flag *= eigenvalues[(int)i].___SmallerOrEqualThan(_value);
            }

            return flag;
        }

        public matrica ___Extends(uint scales)
        {
            uint oldN = (uint)this.value.GetLength(0);

            matrica result = new matrica((uint)(oldN + scales));

            for (int i = 0; i < oldN; i++)
            {
                for (int j = 0; j < oldN; j++)
                {
                    result.value[i, j] = this.value[i, j];
                }
            }

            for (uint i = oldN; i < (long)oldN + scales; i++)
            {
                for (uint j = oldN; j < (long)oldN + scales; j++)
                {
                    result.value[i, j] = i == j ? new drobch64(1.0) : new drobch64(0.0);
                }
            }

            return result;
        }

        public matrica ___Extends(ulong scales)
        {
            ulong oldN = (ulong)this.value.GetLength(0);

            matrica result = new matrica((ulong)(oldN + scales));

            for (int i = 0; i < (long)oldN; i++)
            {
                for (int j = 0; j < (long)oldN; j++)
                {
                    result.value[i, j] = this.value[i, j];
                }
            }

            for (ulong i = oldN; i < oldN + scales; i++)
            {
                for (ulong j = oldN; j < oldN + scales; j++)
                {
                    result.value[i, j] = i == j ? new drobch64(1.0) : new drobch64(0.0);
                }
            }

            return result;
        }

        public matrica ___Extends(short scales)
        {
            switch (scales)
            {
                case 0:
                    return this;
                case > 0:
                    return this.___Extends((ushort)scales);
                default:
                {
                    ushort newN = (ushort)(this.value.GetLength(0) + scales);

                    switch (newN)
                    {
                        case < 1 :
                        {
                            MatricaOutOfRangeError err = new MatricaOutOfRangeError(1021, 1023);
                            err.Execute();
                            break;
                        }
                    }

                    matrica result = new matrica(newN);

                    for (short i = 0; i < newN; i++)
                    {
                        for (short j = 0; j < newN; j++)
                        {
                            result.value[i, j] = this.value[i, j];
                        }
                    }

                    return result;
                }
            }
        }

        public matrica ___Extends(int scales)
        {
            switch (scales)
            {
                case 0:
                    return this;
                case > 0:
                    return this.___Extends((uint)scales);
                default:
                {
                    uint newN = (uint)(this.value.GetLength(0) + scales);

                    switch (newN)
                    {
                        case < 1 :
                        {
                            MatricaOutOfRangeError err = new MatricaOutOfRangeError(1021, 1023);
                            err.Execute();
                            break;
                        }
                    }

                    matrica result = new matrica(newN);

                    for (int i = 0; i < newN; i++)
                    {
                        for (int j = 0; j < newN; j++)
                        {
                            result.value[i, j] = this.value[i, j];
                        }
                    }

                    return result;
                }
            }
        }

        public matrica ___Extends(long scales)
        {
            switch (scales)
            {
                case 0:
                    return this;
                case > 0:
                    return this.___Extends((uint)scales);
                default:
                {
                    ulong newN = (ulong)(this.value.GetLength(0) + scales);

                    switch (newN)
                    {
                        case < 1 :
                        {
                            MatricaOutOfRangeError err = new MatricaOutOfRangeError(1021, 1023);
                            err.Execute();
                            break;
                        }
                    }

                    matrica result = new matrica(newN);

                    for (long i = 0; i < (long)newN; i++)
                    {
                        for (long j = 0; j < (long)newN; j++)
                        {
                            result.value[i, j] = this.value[i, j];
                        }
                    }

                    return result;
                }
            }
        }

        public matrica ___Extends(natch16 scales)
        {
            return this.___Extends((ushort)scales);
        }

        public matrica ___Extends(natch32 scales)
        {
            return this.___Extends((uint)scales);
        }

        public matrica ___Extends(natch64 scales)
        {
            return this.___Extends((ulong)scales);
        }

        public matrica ___Extends(celch16 scales)
        {
            return this.___Extends((short)scales);
        }

        public matrica ___Extends(celch32 scales)
        {
            return this.___Extends((int)scales);
        }

        public matrica ___Extends(celch64 scales)
        {
            return this.___Extends((long)scales);
        }

        public drobch64 ___Trace()
        {
            return new drobch64(Enumerable.Range(0, (int)this.value.GetLength(0)).Select(i => this[(ulong)i, (ulong)i])
                .Sum(x => (double)x));
        }

        public matrica ___AngleSplit(ushort scales, ushort x = 0, ushort y = 0)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - y, j - x] = this.value[i, j] as drobch64;
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, uint x = 0, uint y = 0)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - y, j - x] = this.value[i, j] as drobch64;
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, ulong x = 0, ulong y = 0)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - y, j - x] = this.value[i, j] as drobch64;
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, natch16 x, natch16 y)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - (ulong)y, j - (ulong)x] = (drobch64)this.value[i, j];
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, natch16 x, natch32 y)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - (ulong)y, j - (ulong)x] = (drobch64)this.value[i, j];
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, natch16 x, natch64 y)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - (ulong)y, j - (ulong)x] = (drobch64)this.value[i, j];
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, natch32 x, natch16 y)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - (ulong)y, j - (ulong)x] = (drobch64)this.value[i, j];
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, natch32 x, natch32 y)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - (ulong)y, j - (ulong)x] = (drobch64)this.value[i, j];
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, natch32 x, natch64 y)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - (ulong)y, j - (ulong)x] = (drobch64)this.value[i, j];
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, natch64 x, natch16 y)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - (ulong)y, j - (ulong)x] = (drobch64)this.value[i, j];
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, natch64 x, natch32 y)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - (ulong)y, j - (ulong)x] = (drobch64)this.value[i, j];
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___AngleSplit(ushort scales, natch64 x, natch64 y)
        {
            matrica new_mtx = new matrica(scales);
            for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
            {
                for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
                {
                    try
                    {
                        new_mtx[i - (ulong)y, j - (ulong)x] = (drobch64)this.value[i, j];
                    }
                    catch (IndexOutOfRangeException err)
                    {
                    }
                }
            }

            return new_mtx;
        }

        public matrica ___DistanceSplit(ushort x, ushort y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(uint x, uint y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(ulong x, ulong y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(natch16 x, natch16 y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == (ulong)y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == (ulong)x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(natch16 x, natch32 y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == (ulong)y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == (ulong)x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(natch16 x, natch64 y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == (ulong)y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == (ulong)x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(natch32 x, natch16 y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == (ulong)y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == (ulong)x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(natch32 x, natch32 y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == (ulong)y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == (ulong)x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(natch32 x, natch64 y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == (ulong)y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == (ulong)x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(natch64 x, natch16 y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == (ulong)y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == (ulong)x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(natch64 x, natch32 y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == (ulong)y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == (ulong)x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___DistanceSplit(natch64 x, natch64 y)
        {
            matrica mtx = new matrica(this);
            List<List<drobch64>> new_list_mtx = new List<List<drobch64>>();

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                if (i == (ulong)y) continue;
                List<drobch64> row = new List<drobch64>();
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    if (j == (ulong)x) continue;
                    row.Add(mtx[i, j]);
                }

                new_list_mtx.Add(row);
            }

            return new matrica(new_list_mtx);
        }

        public matrica ___Add(short _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch16(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(int _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch32(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(long _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch64(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(float _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch32(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(double _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch64(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(celch16 _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch16(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(celch32 _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch32(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(celch64 _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch64(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(drobch16 _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch16(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(drobch32 _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch32(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(drobch64 _value)
        {
            matrica num_mtx = MatricaToNumeric(_value, new natch64(this.value.GetLength(0)));
            matrica new_mtx = this.___Add(num_mtx);
            return new_mtx;
        }

        public matrica ___Add(matrica _value)
        {
            matrica new_mtx;
            matrica mtx = new matrica(this);
            if (mtx.Count[0] > _value.Count[0])
            {
                new_mtx = new matrica(mtx.Count[0]);
                _value = _value.___Extends(mtx.Count[0] - _value.Count[0]);
            }
            else
            {
                new_mtx = new matrica(_value.Count[0]);
                mtx = mtx.___Extends(_value.Count[0] - mtx.Count[0]);
            }

            for (ulong i = 0; i < (ulong)new_mtx.Count[0]; i++)
            {
                for (ulong j = 0; j < (ulong)new_mtx.Count[0]; j++)
                {
                    new_mtx[i, j] = mtx[i, j] + _value[i, j];
                }
            }

            return new_mtx;
        }
        
        

        public matrica ___Add(massiv<drobch64> _value) //Testing needed
        {
            matrica _val;
            matrica mtx = new matrica(this);
            Start:
            if (mtx.Count[0] > _value.Count)
            {
                while (mtx.Count[0] > _value.Count)
                {
                    _value.___Add(0);
                }

                _val = new matrica(mtx.Count[0]);

                for (ulong i = 0; i < (ulong)_val.Count[0]; i++)
                {
                    _val[i, i] = _value[i];
                }
            }
            else if (mtx.Count[0] < _value.Count)
            {
                mtx = mtx.___Extends((natch64)_value.Count - mtx.Count[0]);
                goto Start;
            }
            else
            {
                _val = new matrica(mtx.Count[0]);

                for (ulong i = 0; i < (ulong)_val.Count[0]; i++)
                {
                    _val[i, i] = _value[i];
                }
            }

            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = mtx[i, i] + _val[i, i];
            }

            return mtx;
        }

        public matrica ___Multiply(short _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value));
        }

        public matrica ___Multiply(int _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value));
        }

        public matrica ___Multiply(long _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value));
        }

        public matrica ___Multiply(float _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value));
        }

        public matrica ___Multiply(double _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value));
        }

        public matrica ___Multiply(celch16 _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value.value));
        }

        public matrica ___Multiply(celch32 _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value.value));
        }

        public matrica ___Multiply(celch64 _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value.value));
        }

        public matrica ___Multiply(drobch16 _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value.value));
        }

        public matrica ___Multiply(drobch32 _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value.value));
        }

        public matrica ___Multiply(drobch64 _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Multiply(_value.value));
        }
        
        
        
        public massiv<drobch64> ___Multiply(massiv<short> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }
        
        public massiv<drobch64> ___Multiply(massiv<int> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }
        
        public massiv<drobch64> ___Multiply(massiv<long> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }
        
        public massiv<drobch64> ___Multiply(massiv<float> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }
        
        public massiv<drobch64> ___Multiply(massiv<double> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }
        
        public massiv<drobch64> ___Multiply(massiv<celch16> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }
        
        public massiv<drobch64> ___Multiply(massiv<celch32> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }
        
        public massiv<drobch64> ___Multiply(massiv<celch64> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }
        
        public massiv<drobch64> ___Multiply(massiv<drobch16> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }
        
        public massiv<drobch64> ___Multiply(massiv<drobch32> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }
        
        public massiv<drobch64> ___Multiply(massiv<drobch64> _value)
        {
            return NullityVectorToMatrica(this.___Multiply(MatricaToNullityVector(_value)));
        }

        public matrica ___Multiply(matrica _value)
        {
            Matrix<double> mtx = MatricaToMatrix(new matrica((drobch64[,])this.value));
            Matrix<double> val = MatricaToMatrix(new matrica((drobch64[,])_value.value));
            try
            {
                return MatrixToMatrica(mtx.Multiply(val));
            }
            catch (Exception err)
            {
                return _value;
            }
            
        }

        public matrica ___Divide(short _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value));
        }

        public matrica ___Divide(int _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value));
        }

        public matrica ___Divide(long _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value));
        }

        public matrica ___Divide(float _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value));
        }

        public matrica ___Divide(double _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value));
        }

        public matrica ___Divide(celch16 _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value.value));
        }

        public matrica ___Divide(celch32 _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value.value));
        }

        public matrica ___Divide(celch64 _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value.value));
        }

        public matrica ___Divide(drobch16 _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value.value));
        }

        public matrica ___Divide(drobch32 _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value.value));
        }

        public matrica ___Divide(drobch64 _value)
        {
            matrica mtx = new matrica(this);
            return mtx.___Multiply(new drobch64(1 / _value.value));
        }

        public matrica? ___Divide(matrica _value)
        {
            matrica mtx = new matrica(this);
            if (mtx.___Abs() == 0)
            {
                ZeroDivisionError err = new ZeroDivisionError(0, 0);
                err.Execute();
            }
            matrica inverse = new matrica(_value).___Inverse();
            return mtx.___Multiply(inverse);
        }

        public matrica ___Pow(short _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Power(_value));
        }

        public matrica ___Pow(int _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Power(_value));
        }

        public matrica ___Pow(long _value)
        {
            return MatrixToMatrica(MatricaToMatrix(this).Power((int)_value));
        }

        public matrica ___Pow(float _value)
        {
            massiv<matrica> diag = this.___Diagonalisacia();
            for (ulong i = 0; i < (ulong)diag[1].Count[0]; i++)
            {
                diag[1][i, i] = new drobch64(this.pow((double)diag[1][i, i], _value));
            }

            return diag[0].___Multiply(diag[1]).___Multiply(diag[2]);
        }

        public matrica ___Pow(double _value)
        {
            massiv<matrica> diag = this.___Diagonalisacia();
            for (ulong i = 0; i < (ulong)diag[1].Count[0]; i++)
            {
                diag[1][i, i] = new drobch64(this.pow((double)diag[1][i, i], _value));
            }

            return diag[0].___Multiply(diag[1]).___Multiply(diag[2]);
        }

        public matrica ___Pow(celch16 _value)
        {
            massiv<matrica> diag = this.___Diagonalisacia();
            for (ulong i = 0; i < (ulong)diag[1].Count[0]; i++)
            {
                diag[1][i, i] = new drobch64(pow((double)diag[1][i, i], _value.value));
            }

            return diag[0].___Multiply(diag[1]).___Multiply(diag[2]);
        }

        public matrica ___Pow(celch32 _value)
        {
            massiv<matrica> diag = this.___Diagonalisacia();
            for (ulong i = 0; i < (ulong)diag[1].Count[0]; i++)
            {
                diag[1][i, i] = new drobch64(pow((double)diag[1][i, i], _value.value));
            }

            return diag[0].___Multiply(diag[1]).___Multiply(diag[2]);
        }

        public matrica ___Pow(celch64 _value)
        {
            massiv<matrica> diag = this.___Diagonalisacia();
            for (ulong i = 0; i < (ulong)diag[1].Count[0]; i++)
            {
                diag[1][i, i] = new drobch64(pow((double)diag[1][i, i], _value.value));
            }

            return diag[0].___Multiply(diag[1]).___Multiply(diag[2]);
        }

        public matrica ___Pow(drobch16 _value)
        {
            massiv<matrica> diag = this.___Diagonalisacia();
            for (ulong i = 0; i < (ulong)diag[1].Count[0]; i++)
            {
                diag[1][i, i] = new drobch64(pow((double)diag[1][i, i], _value.value));
            }

            return diag[0].___Multiply(diag[1]).___Multiply(diag[2]);
        }

        public matrica ___Pow(drobch32 _value)
        {
            massiv<matrica> diag = this.___Diagonalisacia();
            for (ulong i = 0; i < (ulong)diag[1].Count[0]; i++)
            {
                diag[1][i, i] = new drobch64(pow((double)diag[1][i, i], _value.value));
            }

            return diag[0].___Multiply(diag[1]).___Multiply(diag[2]);
        }

        public matrica ___Pow(drobch64 _value)
        {
            massiv<matrica> diag = this.___Diagonalisacia();
            for (ulong i = 0; i < (ulong)diag[1].Count[0]; i++)
            {
                diag[1][i, i] = new drobch64(pow((double)diag[1][i, i], _value.value));
            }

            return diag[0].___Multiply(diag[1]).___Multiply(diag[2]);
        }

        public matrica ___Pow(matrica _value)
        {
            return (_value * this.___Ln()).___Exp();
        }

        public matrica ___Sqrt()
        {
            matrica eigenvalues_mtx = MatrixToMatrica(MatricaToMatrix(this).Evd().D);
            matrica eigenvectors_mtx = this.___SobVektora();
            matrica eigenvectors_mtx_inverse = this.___SobVektora().___Inverse();

            for (ulong i = 0; i < (ulong)eigenvalues_mtx.Count[0]; i++)
            {
                eigenvalues_mtx[i, i] = UralMathLib.Sqrt(new drobch64(eigenvalues_mtx[i, i]));
            }

            return eigenvectors_mtx.___Multiply(eigenvalues_mtx).___Multiply(eigenvectors_mtx_inverse);
        }

        public matrica ___Cbrt()
        {
            matrica eigenvalues_mtx = MatrixToMatrica(MatricaToMatrix(this).Evd().D);
            matrica eigenvectors_mtx = this.___SobVektora();
            matrica eigenvectors_mtx_inverse = this.___SobVektora().___Inverse();

            for (ulong i = 0; i < (ulong)eigenvalues_mtx.Count[0]; i++)
            {
                eigenvalues_mtx[i, i] = UralMathLib.Cbrt(new drobch64(eigenvalues_mtx[i, i]));
            }

            return eigenvectors_mtx.___Multiply(eigenvalues_mtx).___Multiply(eigenvectors_mtx_inverse);
        }


        public matrica ___Ln()
        {
            return ___MathFunc(this, UralMathLib.Ln);
        }

        public matrica ___Lt()
        {
            return ___MathFunc(this, UralMathLib.Lt);
        }

        public matrica ___Lg()
        {
            return ___MathFunc(this, UralMathLib.Lg);
        }

        public matrica ___Sin()
        {
            return ___MathFunc(this, UralMathLib.Sin);
        }

        public matrica ___ArcSin()
        {
            return ___MathFunc(this, UralMathLib.ArcSin);
        }

        public matrica ___Cos()
        {
            return ___MathFunc(this, UralMathLib.Cos);
        }

        public matrica ___ArcCos()
        {
            return ___MathFunc(this, UralMathLib.ArcCos);
        }

        public matrica ___Sec()
        {
            return ___MathFunc(this, UralMathLib.Sec);
        }

        public matrica ___Csc()
        {
            return ___MathFunc(this, UralMathLib.Csc);
        }

        public matrica ___Sinh()
        {
            return ___MathFunc(this, UralMathLib.Sinh);
        }

        public matrica ___ArcSinh()
        {
            return ___MathFunc(this, UralMathLib.ArcSinh);
        }

        public matrica ___Cosh()
        {
            return ___MathFunc(this, UralMathLib.Cosh);
        }

        public matrica ___ArcCosh()
        {
            return ___MathFunc(this, UralMathLib.ArcCosh);
        }

        public matrica ___Tanh()
        {
            return ___MathFunc(this, UralMathLib.Tanh);
        }

        public matrica ___Exp()
        {
            return ___MathFunc(this, UralMathLib.Exp);
        }

        public natch64 ___Rank()
        {
            return new natch64(MatricaToMatrix(this).Rank());
        }
        

        public massiv<matrica>___Diagonalisacia()
        {
            matrica eigenvalues_mtx = MatrixToMatrica(MatricaToMatrix(this).Evd().D);
            matrica eigenvectors_mtx = this.___SobVektora();
            matrica eigenvectors_mtx_inverse = this.___SobVektora().___Inverse();

            ArrayList _value = new ArrayList();
            _value.Add(eigenvectors_mtx);
            _value.Add(eigenvalues_mtx);
            _value.Add(eigenvectors_mtx_inverse);
            return new massiv<matrica>(_value);
        }
        
        public massiv<matrica>___LU()
        {
            Matrix<double> mtx = MatricaToMatrix(this);
            ArrayList _value = new ArrayList();
            _value.Add(MatrixToMatrica(mtx.LU().L));
            _value.Add(MatrixToMatrica(mtx.LU().U));
            return new massiv<matrica>(_value);
        }
        
        public massiv<matrica>___QR()
        {
            Matrix<double> mtx = MatricaToMatrix(this);
            ArrayList _value = new ArrayList();
            _value.Add(MatrixToMatrica(mtx.QR(QRMethod.Full).Q));
            _value.Add(MatrixToMatrica(mtx.QR(QRMethod.Full).R));
            return new massiv<matrica>(_value);
        }
        
        public massiv<matrica>?___Cholesky()
        {
            try
            {
                Matrix<double> mtx = MatricaToMatrix(this);
                ArrayList _value = new ArrayList();
                _value.Add(MatrixToMatrica(mtx.Cholesky().Factor));
                _value.Add(MatrixToMatrica(mtx.Cholesky().Factor.Transpose()));
                return new massiv<matrica>(_value);
            }
            catch (Exception e)
            {
                ZeroDivisionError err = new ZeroDivisionError(0, 0);
                err.Execute();
                return null;
            }
        }

        public static matrica ___MathFunc(matrica mtx, Func<drobch64, drobch64> f)
        {
            matrica eigenvalues_mtx = MatrixToMatrica(MatricaToMatrix(mtx).Evd().D);
            matrica eigenvectors_mtx = mtx.___SobVektora();
            matrica eigenvectors_mtx_inverse = mtx.___SobVektora().___Inverse();

            for (ulong i = 0; i < (ulong)eigenvalues_mtx.Count[0]; i++)
            {
                eigenvalues_mtx[i, i] = f(eigenvalues_mtx[i, i]);
            }

            return eigenvectors_mtx.___Multiply(eigenvalues_mtx).___Multiply(eigenvectors_mtx_inverse);
        }

        public matrica ___Inverse()
        {
            if (this.___Abs().___Equals(0.0))
            {
                ZeroDivisionError err = new ZeroDivisionError(0, 0);
                err.Execute();
            }

            return MatrixToMatrica(MatricaToMatrix(this).Inverse());
        }

        public drobch64 ___Abs()
        {
            matrica mtx = new matrica(this);
            switch ((ulong)mtx.Count[0b0])
            {
                case 0:
                    return mtx[0, 0];
                case 2:
                    return mtx[0, 0] * mtx[1, 1] - mtx[0, 1] * mtx[1, 0];
                default:
                {
                    drobch64 summa = new drobch64(0b0);
                    for (ulong i = 0b0; i < (ulong)mtx.Count[0b0]; i++)
                    {
                        switch (Convert.ToBoolean((double)mtx[0b0, i]))
                        {
                            case false :
                                continue;
                            default :
                                summa = (i % 0b10) switch
                                {
                                    0b1 => summa - 0b1 * mtx[0b0, i] * mtx.___DistanceSplit(i, 0b0).___Abs(),
                                    _ => summa + mtx[0b0, i] * mtx.___DistanceSplit(i, 0b0).___Abs()
                                };
                                break;
                        }
                    }

                    return summa;
                }
            }
        }

        /*
         public drobch64 ___Trace()
        {
            int min = (int)this.Count?[0] > (int)this.Count?[1] ? (int)this.Count?[1] : (int)this.Count?[0];
            Matrix<double> mtx = Matrix<double>.Build.DenseIdentity(min);
            for (int i = 0; i < min; i++)
            {
                for (int j = 0; i < min; i++)
                {
                    mtx[i, j] = (double)this[new natch64(i), new natch64(j)];
                }
            }

            return new drobch64(mtx.Trace());
        }
        */

        public matrica ___Transpose()
        {
            return MatrixToMatrica(MatricaToMatrix(this).Transpose());
        }

        public massiv<dynamic> ___SobZnacheniya()
        {
            matrica eigenvalues_mtx = MatrixToMatrica(MatricaToMatrix(this).Evd().D);
            ArrayList eigenvalues = new ArrayList();
            for (ulong i = 0; i < (ulong)eigenvalues_mtx.Count[0]; i++)
            {
                eigenvalues.Add(eigenvalues_mtx[i, i]);
            }

            return new massiv<dynamic>(eigenvalues);
        }

        public matrica ___SobVektora()
        {
            Matrix<double> mtx = MatricaToMatrix(this);
            Matrix<double> eigenvectors = mtx.Evd().EigenVectors;
            return MatrixToMatrica(eigenvectors);
        }

        public static drobch64 ___HyperDotProduct(matrica mtx1, matrica mtx2)
        {
            return mtx1.___Multiply(mtx2.___Transpose()).___Trace();
        }
        
        public static matrica ___HyperCrossProduct(matrica mtx1, matrica mtx2)
        {
            return (mtx1.___Multiply(mtx2.___Transpose())).___Diagonalisacia()[0];
        }

        public static matrica ___HyperQuaternion(spisok arr, RCI var)
        {
            for (int i = 0; i < (int)arr.Count; i++) arr[i] = (double)arr[i];
            double [] extendedArr = new double[(int)arr.Count];
            for (int i = 0; i < (int)arr.Count; i++) extendedArr[i] = (double)arr[i];
            
        switch (extendedArr.Length)
            {
                case 1 :
                    return new matrica(arr[0]);
                case 2 :
                    return new matrica(2)
                    {
                        [0, 0] = new drobch64(arr[0]),
                        [0, 1] = new drobch64(arr[1]),
                        [1, 0] = new drobch64(-arr[1]),
                        [1, 1] = new drobch64(arr[0]),
                    };
                case 4 :
                    return new matrica(4)
                    {
                        [0, 0] = new drobch64(arr[0]),
                        [0, 1] = new drobch64(arr[1]),
                        [0, 2] = new drobch64(-arr[2]),
                        [0, 3] = new drobch64(-arr[3]),
                        [1, 0] = new drobch64(arr[1]),
                        [1, 1] = new drobch64(arr[0]),
                        [1, 2] = new drobch64(-arr[3]),
                        [1, 3] = new drobch64(arr[2]),
                        [2, 0] = new drobch64(arr[2]),
                        [2, 1] = new drobch64(arr[3]),
                        [2, 2] = new drobch64(arr[0]),
                        [2, 3] = new drobch64(-arr[1]),
                        [3, 0] = new drobch64(arr[3]),
                        [3, 1] = new drobch64(-arr[2]),
                        [3, 2] = new drobch64(arr[1]),
                        [3, 3] = new drobch64(arr[0])
                    };
            }
            

            int mid = extendedArr.Length / 2;
            
            matrica A = ___HyperQuaternion(new spisok(extendedArr[0..mid]), var);
            matrica B = ___HyperQuaternion(new spisok(extendedArr[mid..]), var);

            if (!var) return A * B;
            var top = DenseMatrix.OfMatrix(MatricaToMatrix(A)).Append(MatricaToMatrix(B));
            var bottom = DenseMatrix.OfMatrix(-(MatricaToMatrix(B).Transpose())).Append(MatricaToMatrix(A).Transpose());
            return MatrixToMatrica(top.Stack(bottom));
            
        }

        public override string ToString()
        {
            return (this.ToString("[", "]", "[", "]", ", "));
        }

        public virtual string ToString(string out_left_b = "[", string out_right_b = "]", string in_left_b = "[", string in_right_b = "]", string sep = ", ")
        {
            string output = out_left_b;
            for (int i = 0; i < this.value.GetLength(0); i++)
            {
                output += in_left_b;
                for (int j = 0; j < this.value.GetLength(1); j++)
                {
                    output += this.value[i, j].ToString();
                    if (j < this.value.GetLength(1) - 1)
                    {
                        output += sep;
                    }
                }

                output += in_right_b;
                if (i < this.value.GetLength(0) - 1)
                {
                    output += sep + "\n";
                }
            }

            return output + out_right_b;
        }

        public matrica SignAlternator()
        {
            matrica mtx = new matrica(this);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                for (ulong j = 0; j < (ulong)mtx.Count[0]; j++)
                {
                    switch (i % 2)
                    {
                        case 0 when j % 2 == 0 :
                            continue;
                        default :
                            mtx[i, j] = -1 * this[i, j];
                            break;
                    }
                }
            }

            return mtx;
        }
        
        protected static matrica MatricaToNullityVector(massiv<short> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<int> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<long> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<float> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<double> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<natch16> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<natch32> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<natch64> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<celch16> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<celch32> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<celch64> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<drobch16> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<drobch32> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static matrica MatricaToNullityVector(massiv<drobch64> vec)
        {
            drobch64[,] mtx = new drobch64[vec.value.Count, vec.value.Count];
            for (int i = 0; i < vec.value.Count * vec.value.Count; i++) mtx[i % vec.value.Count, i / vec.value.Count] = new drobch64(0);
            for (int i = 0; i < (int)vec.value.Count; i++) mtx[i, 0] = new drobch64(vec[i]);
            return new matrica(mtx);
        }
        
        protected static massiv<drobch64> NullityVectorToMatrica(matrica mtx) //ToDo
        {
            drobch64[] vec = new drobch64[(int)mtx.Count[0]];
            for (int i = 0; i < (int)mtx.Count[0]; i++) vec[i] = mtx[(ulong)i, 0];
            
            return new massiv<drobch64>(vec);
        }
        

        protected static Matrix<double> MatricaToMatrix(matrica mtx)
        {
            double[,] values = new double[(ulong)mtx.Count[0], (ulong)mtx.Count[1]];
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                for (ulong j = 0; j < (ulong)mtx.Count[1]; j++)
                {
                    values[i, j] = (double)(new drobch64((drobch64)mtx.value[i, j])); //ToDo
                }
            }

            return Matrix<double>.Build.DenseOfArray(values);
        }

        protected static matrica MatrixToMatrica(Matrix<double> mtx)
        {
            drobch64[,] values = new drobch64[mtx.RowCount, mtx.ColumnCount];
            for (ulong i = 0; i < (ulong)mtx.RowCount; i++)
            {
                for (ulong j = 0; j < (ulong)mtx.ColumnCount; j++)
                {
                    values[i, j] = new drobch64(mtx[(int)i, (int)j]);
                }
            }

            return new matrica(values);
        }

        public static matrica MatricaToNumeric(short _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(int _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(long _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(float _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(double _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch16 _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch32 _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch64 _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch16 _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch32 _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch64 _value)
        {
            matrica mtx = new matrica(2);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = _value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(short _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(short _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(short _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(short _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(short _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(short _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(int _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(int _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(int _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(int _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(int _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(int _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(long _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(long _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(long _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(long _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(long _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(long _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(float _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(float _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(float _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(float _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(float _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(float _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(double _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(double _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(double _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(double _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(double _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(double _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = new drobch64(_value);
                ;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch16 _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch16 _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch16 _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch16 _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch16 _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch16 _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch32 _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch32 _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch32 _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch32 _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch32 _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch32 _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch64 _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch64 _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch64 _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch64 _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch64 _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(celch64 _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch16 _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch16 _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch16 _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch16 _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch16 _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch16 _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch32 _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch32 _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch32 _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch32 _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch32 _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch32 _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = (drobch64)_value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch64 _value, ushort scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = _value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch64 _value, uint scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = _value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch64 _value, ulong scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = _value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch64 _value, natch16 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = _value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch64 _value, natch32 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = _value;
            }

            return mtx;
        }

        public static matrica MatricaToNumeric(drobch64 _value, natch64 scales)
        {
            matrica mtx = new matrica(scales);
            for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
            {
                mtx[i, i] = _value;
            }

            return mtx;
        }
    }
}