using Datatypes.Numbers;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;
using natch16 = Datatypes.Numbers.natch16;

namespace Datatypes.Collections.MathCollections
{
	public class matrica : VOID, Interface_UCollection
	{
		public ulong MaxLength = 4294967295U;
		public Interface_UDrobch[,] value;
		public readonly kortezh Count;
		
		public matrica(ushort n)
		{
			this.value = new Interface_UDrobch[n, n];
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
			this.value = new Interface_UDrobch[n, n];
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
			this.value = new Interface_UDrobch[n, n];
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
			this.value = new Interface_UDrobch[(ushort)n, (ushort)n];
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
			this.value = new Interface_UDrobch[(uint)n, (uint)n];
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
			this.value = new Interface_UDrobch[(ulong)n, (ulong)n];
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
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch16(mtx.GetLength(1)), new natch16(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch16(mtx.GetLength(0)), new natch16(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch16(mtx[i, j]);
				}
			}

		}
		
		public matrica(List<List<short>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch16(mtx[0].Count), new natch16(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch16(mtx.Count), new natch16(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch16(mtx[i][j]);
				}
			}
		}
		
		public matrica(int[,] mtx)
		{
			if (mtx.GetLength(0) >= mtx.GetLength(1))
			{
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch32(mtx.GetLength(1)), new natch32(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch32(mtx[i, j]);
				}
			}

		}
		
		public matrica(List<List<int>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch32(mtx.Count), new natch32(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch32(mtx[i][j]);
				}
			}
		}
		
		public matrica(long[,] mtx)
		{
			if (mtx.GetLength(0) >= mtx.GetLength(1))
			{
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch64(mtx.GetLength(1)), new natch64(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch64(mtx[i, j]);
				}
			}

		}
		
		public matrica(List<List<long>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch64(mtx.Count), new natch64(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch64(mtx[i][j]);
				}
			}
		}
		
		public matrica(float[,] mtx)
		{
			if (mtx.GetLength(0) >= mtx.GetLength(1))
			{
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch32(mtx.GetLength(1)), new natch32(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new drobch32(mtx[i, j]);
				}
			}
		}
		
		public matrica(List<List<float>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch32(mtx.Count), new natch32(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new drobch32(mtx[i][j]);
				}
			}
		}
		
		public matrica(double[,] mtx)
		{
			if (mtx.GetLength(0) >= mtx.GetLength(1))
			{
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch64(mtx.GetLength(1)), new natch64(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new drobch64(mtx[i, j]);
				}
			}
		}
		
		public matrica(List<List<double>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch64(mtx.Count), new natch64(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new drobch64(mtx[i][j]);
				}
			}
		}
		
		public matrica(celch16[,] mtx)
		{
			if (mtx.GetLength(0) >= mtx.GetLength(1))
			{
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch16(mtx.GetLength(1)), new natch16(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch16(mtx.GetLength(0)), new natch16(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch16(mtx[i, j]);
				}
			}

		}
		
		public matrica(List<List<celch16>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch16(mtx[0].Count), new natch16(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch16(mtx.Count), new natch16(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch16(mtx[i][j]);
				}
			}
		}
		
		public matrica(celch32[,] mtx)
		{
			if (mtx.GetLength(0) >= mtx.GetLength(1))
			{
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch32(mtx.GetLength(1)), new natch32(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch32(mtx[i, j]);
				}
			}

		}
		
		public matrica(List<List<celch32>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch32(mtx.Count), new natch32(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch32(mtx[i][j]);
				}
			}
		}
		
		public matrica(celch64[,] mtx)
		{
			if (mtx.GetLength(0) >= mtx.GetLength(1))
			{
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch64(mtx.GetLength(1)), new natch64(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch64(mtx[i, j]);
				}
			}

		}
		
		public matrica(List<List<celch64>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch64(mtx.Count), new natch64(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch64(mtx[i][j]);
				}
			}
		}
		
		public matrica(drobch16[,] mtx)
		{
			if (mtx.GetLength(0) >= mtx.GetLength(1))
			{
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch16(mtx.GetLength(1)), new natch16(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch16(mtx.GetLength(0)), new natch16(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new celch16(mtx[i, j]);
				}
			}

		}
		
		public matrica(List<List<drobch16>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch16(mtx[0].Count), new natch16(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch16(mtx.Count), new natch16(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new drobch16(mtx[i][j]);
				}
			}
		}
		
		public matrica(drobch32[,] mtx)
		{
			if (mtx.GetLength(0) >= mtx.GetLength(1))
			{
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch32(mtx.GetLength(1)), new natch32(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch32(mtx.GetLength(0)), new natch32(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new drobch32(mtx[i, j]);
				}
			}
		}
		
		public matrica(List<List<drobch32>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch32(mtx[0].Count), new natch32(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch32(mtx.Count), new natch32(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new drobch32(mtx[i][j]);
				}
			}
		}
		
		public matrica(drobch64[,] mtx)
		{
			if (mtx.GetLength(0) >= mtx.GetLength(1))
			{
				this.value = new Interface_UDrobch[mtx.GetLength(1), mtx.GetLength(1)];
				this.Count = new kortezh(new natch64(mtx.GetLength(1)), new natch64(mtx.GetLength(1)));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.GetLength(0), mtx.GetLength(0)];
				this.Count = new kortezh(new natch64(mtx.GetLength(0)), new natch64(mtx.GetLength(0)));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new drobch64(mtx[i, j]);
				}
			}
		}
		
		public matrica(List<List<drobch64>> mtx)
		{
			if (mtx.Count >= mtx[0].Count)
			{
				this.value = new Interface_UDrobch[mtx[0].Count, mtx[0].Count];
				this.Count = new kortezh(new natch64(mtx[0].Count), new natch64(mtx[0].Count));
			}
			else
			{
				this.value = new Interface_UDrobch[mtx.Count, mtx.Count];
				this.Count = new kortezh(new natch64(mtx.Count), new natch64(mtx.Count));
			}
			
			for (int i = 0; i < (this.Count[0]); i++)
			{
				for (int j = 0; j < (this.Count[0]); j++)
				{
					this.value[i, j] = new drobch64(mtx[i][j]);
				}
			}
		}
		
		public Interface_UDrobch this[ushort x, ushort y]
		{
		    get { return this.value[x, y]; }
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

		public Interface_UDrobch this[ushort x, uint y]
		{
		    get { return this.value[x, y]; }
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

		public Interface_UDrobch this[ushort x, ulong y]
		{
		    get { return this.value[x, y]; }
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

		public Interface_UDrobch this[uint x, ushort y]
		{
		    get { return this.value[x, y]; }
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

		public Interface_UDrobch this[uint x, uint y]
		{
		    get { return this.value[x, y]; }
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

		public Interface_UDrobch this[uint x, ulong y]
		{
		    get { return this.value[x, y]; }
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

		public Interface_UDrobch this[ulong x, ushort y]
		{
		    get { return this.value[x, y]; }
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

		public Interface_UDrobch this[ulong x, uint y]
		{
		    get { return this.value[x, y]; }
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

		public Interface_UDrobch this[ulong x, ulong y]
		{
		    get { return this.value[x, y]; }
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
		
		public Interface_UDrobch this[natch16 x, natch16 y]
		{
		    get { return this.value[(ushort)x, (ushort)y]; }
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

		public Interface_UDrobch this[natch16 x, natch32 y]
		{
		    get { return this.value[(uint)x, (uint)y]; }
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

		public Interface_UDrobch this[natch16 x, natch64 y]
		{
		    get { return this.value[(ulong)x, (ulong)y]; }
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

		public Interface_UDrobch this[natch32 x, natch16 y]
		{
		    get { return this.value[(uint)x, (uint)y]; }
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

		public Interface_UDrobch this[natch32 x, natch32 y]
		{
		    get { return this.value[(uint)x, (uint)y]; }
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

		public Interface_UDrobch this[natch32 x, natch64 y]
		{
		    get { return this.value[(ulong)x, (ulong)y]; }
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

		public Interface_UDrobch this[natch64 x, natch16 y]
		{
		    get { return this.value[(ulong)x, (ulong)y]; }
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

		public Interface_UDrobch this[natch64 x, natch32 y]
		{
		    get { return this.value[(ulong)x, (ulong)y]; }
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
		
		public Interface_UDrobch this[natch64 x, natch64 y]
		{
			get { return this.value[(ulong)x, (ulong)y]; }
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
		
		protected static matrica ChisloMatrica(Interface_UDrobch value, ushort scales)
		{
			matrica mtx = new matrica(scales);
			for (short i = 0; i < scales; i++)
			{
				mtx[new natch16(i), new natch16(i)] = value;
			}
			return mtx;
		}
		
		protected static matrica ChisloMatrica(Interface_UDrobch value, uint scales)
		{
			matrica mtx = new matrica(scales);
			for (int i = 0; i < scales; i++)
			{
				mtx[new natch16(i), new natch16(i)] = value;
			}
			return mtx;
		}
		
		protected static matrica ChisloMatrica(Interface_UDrobch value, ulong scales)
		{
			matrica mtx = new matrica(scales);
			for (long i = 0; i < (long)scales; i++)
			{
				mtx[new natch16(i), new natch16(i)] = value;
			}
			return mtx;
		}
		
		protected static matrica ChisloMatrica(Interface_UDrobch value, natch16 scales)
		{
			matrica mtx = new matrica(scales);
			for (short i = 0; i < (short)scales; i++)
			{
				mtx[new natch16(i), new natch16(i)] = value;
			}
			return mtx;
		}
		
		protected static matrica ChisloMatrica(Interface_UDrobch value, natch32 scales)
		{
			matrica mtx = new matrica(scales);
			for (int i = 0; i < (int)scales; i++)
			{
				mtx[new natch16(i), new natch16(i)] = value;
			}
			return mtx;
		}
		
		protected static matrica ChisloMatrica(Interface_UDrobch value, natch64 scales)
		{
			matrica mtx = new matrica(scales);
			for (long i = 0; i < (long)scales; i++)
			{
				mtx[new natch16(i), new natch16(i)] = value;
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
				case  0 :
					return this;
				case > 0 :
					return this.___Extends((ushort)scales);
				default :
				{
					ushort newN = (ushort)(this.value.GetLength(0) + scales);

					if (newN < 1)
					{
						MatricaOutOfRangeError err = new MatricaOutOfRangeError(1021, 1023);
						err.Execute();
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
				case  0 :
					return this;
				case > 0 :
					return this.___Extends((uint)scales);
				default :
				{
					uint newN = (uint)(this.value.GetLength(0) + scales);

					if (newN < 1)
					{
						MatricaOutOfRangeError err = new MatricaOutOfRangeError(1021, 1023);
						err.Execute();
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
				case  0 :
					return this;
				case > 0 :
					return this.___Extends((uint)scales);
				default :
				{
					ulong newN = (ulong)(this.value.GetLength(0) + scales);

					if (newN < 1)
					{
						MatricaOutOfRangeError err = new MatricaOutOfRangeError(1021, 1023);
						err.Execute();
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
		
		public string ToString(string out_left_b = "[", string out_right_b = "]", string in_left_b = "[", string in_right_b = "]", string sep = ", ")
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
	}
}

