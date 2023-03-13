using Datatypes.Numbers;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;
using natch16 = Datatypes.Numbers.natch16;

namespace Datatypes.Collections.MathCollections
{
	public class matrica : VOID, Interface_UCollection, Interface_Ural_Datatype
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
		
		public matrica(Interface_UDrobch[,] mtx)
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
			
			for (ulong i = 0; i < (ulong)(this.Count[0]); i++)
			{
				for (ulong j = 0; j < (ulong)(this.Count[0]); j++)
				{
					this.value[i, j] =mtx[i, j];
				}
			}
		}

		public matrica(matrica mtx)
		{ 
			this.value = new drobch64[mtx.value.GetLength(0), mtx.value.GetLength(0)];
			this.Count = new kortezh(new natch64(mtx.value.GetLength(0)), new natch64(mtx.value.GetLength(0)));
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
		    get
		    { return (drobch64)this.value[x, y]; }
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
		    get
		    { return (drobch64)this.value[x, y]; }
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
			
		    get
		    { return (drobch64)this.value[x, y]; }
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
		    get { return (drobch64)this.value[(ushort)x, (ushort)y]; }
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
		    get { return (drobch64)this.value[(uint)x, (uint)y]; }
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
		    get { return (drobch64)this.value[(ulong)x, (ulong)y]; }
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
		    get { return (drobch64)this.value[(uint)x, (uint)y]; }
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
		    get { return (drobch64)this.value[(uint)x, (uint)y]; }
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
		    get { return (drobch64)this.value[(ulong)x, (ulong)y]; }
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
		    get { return (drobch64)this.value[(ulong)x, (ulong)y]; }
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
		    get
		    { return (drobch64)this.value[(ulong)x, (ulong)y]; }
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
			get
			{ return (drobch64)this.value[(ulong)x, (ulong)y]; }
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

		public drobch64 ___Trace()
		{
			return new drobch64(Enumerable.Range(0, (int) this.value.GetLength(0)).Select(i => this[(ulong)i, (ulong)i]).Sum(x => (double)x));
		}

		public matrica ___Split(ushort scales, ushort x = 0, ushort y = 0)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-y, j-x] = this.value[i, j] as drobch64;
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, uint x = 0, uint y = 0)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-y, j-x] = this.value[i, j] as drobch64;
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, ulong x = 0, ulong y = 0)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-y, j-x] = this.value[i, j] as drobch64;
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, natch16 x, natch16 y)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-(ulong)y, j-(ulong)x] = (drobch64)this.value[i, j];
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, natch16 x, natch32 y)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-(ulong)y, j-(ulong)x] = (drobch64)this.value[i, j];
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, natch16 x, natch64 y)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-(ulong)y, j-(ulong)x] = (drobch64)this.value[i, j];
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, natch32 x, natch16 y)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-(ulong)y, j-(ulong)x] = (drobch64)this.value[i, j];
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, natch32 x, natch32 y)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-(ulong)y, j-(ulong)x] = (drobch64)this.value[i, j];
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, natch32 x, natch64 y)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-(ulong)y, j-(ulong)x] = (drobch64)this.value[i, j];
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, natch64 x, natch16 y)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-(ulong)y, j-(ulong)x] = (drobch64)this.value[i, j];
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, natch64 x, natch32 y)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-(ulong)y, j-(ulong)x] = (drobch64)this.value[i, j];
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}
		
		public matrica ___Split(ushort scales, natch64 x, natch64 y)
		{
			matrica new_mtx = new matrica(scales);
			for (ulong i = (ulong)y; i < (ulong)(x + scales); i++)
			{
				for (ulong j = (ulong)x; j < (ulong)(y + scales); j++)
				{
					try
					{
						new_mtx[i-(ulong)y, j-(ulong)x] = (drobch64)this.value[i, j];
					}
					catch (IndexOutOfRangeException err) { }
				}
			}

			return new_mtx;
		}

		public matrica ___Add(short _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch16(this.value.GetLength(0)));
			matrica new_mtx = this.___Add(num_mtx);
			return new_mtx;
		}
		
		public matrica ___Add(int _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch32(this.value.GetLength(0)));
			matrica new_mtx = this.___Add(num_mtx);
			return new_mtx;
		}
		
		public matrica ___Add(long _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch64(this.value.GetLength(0)));
			matrica new_mtx = this.___Add(num_mtx);
			return new_mtx;
		}
		
		public matrica ___Add(float _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch32(this.value.GetLength(0)));
			matrica new_mtx = this.___Add(num_mtx);
			return new_mtx;
		}
		
		public matrica ___Add(double _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch64(this.value.GetLength(0)));
			matrica new_mtx = this.___Add(num_mtx);
			return new_mtx;
		}
		
		public matrica ___Add(celch16 _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch16(this.value.GetLength(0)));
			matrica new_mtx = this.___Add(num_mtx);
			return new_mtx;
		}
		
		public matrica ___Add(celch32 _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch32(this.value.GetLength(0)));
			matrica new_mtx = this.___Add(num_mtx);
			return new_mtx;
		}
		
		public matrica ___Add(celch64 _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch64(this.value.GetLength(0)));
			matrica new_mtx = this.___Add(num_mtx);
			return new_mtx;
		}
		
		public matrica ___Add(drobch16 _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch16(this.value.GetLength(0)));
			matrica new_mtx = this.___Add(num_mtx);
			return new_mtx;
		}
		
		public matrica ___Add(drobch32 _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch32(this.value.GetLength(0)));
			matrica new_mtx = this.___Add(num_mtx);
			return new_mtx;
		}
		
		public matrica ___Add(drobch64 _value)
		{
			matrica num_mtx = matrica.MatricaToNumeric(_value, new natch64(this.value.GetLength(0)));
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
				mtx = mtx.___Extends( _value.Count[0] - mtx.Count[0]);
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
		
		public matrica ___Add(massiv _value) //Testing needed
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
				mtx = mtx.___Extends( (natch64)_value.Count - mtx.Count[0]);
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
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * new drobch64(_value);
				}
			}
			return new_mtx;
		}
		
		public matrica ___Multiply(int _value)
		{
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * new drobch64(_value);
				}
			}
			return new_mtx;
		}
		
		public matrica ___Multiply(long _value)
		{
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * new drobch64(_value);
				}
			}
			return new_mtx;
		}
		
		public matrica ___Multiply(float _value)
		{
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * new drobch64(_value);
				}
			}
			return new_mtx;
		}
		
		public matrica ___Multiply(double _value)
		{
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * new drobch64(_value);
				}
			}
			return new_mtx;
		}
		
		public matrica ___Multiply(celch16 _value)
		{
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * new drobch64(_value);
				}
			}
			return new_mtx;
		}
		
		public matrica ___Multiply(celch32 _value)
		{
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * new drobch64(_value);
				}
			}
			return new_mtx;
		}
		
		public matrica ___Multiply(celch64 _value)
		{
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * new drobch64(_value);
				}
			}
			return new_mtx;
		}
		
		public matrica ___Multiply(drobch16 _value)
		{
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * new drobch64(_value);
				}
			}
			return new_mtx;
		}
		
		public matrica ___Multiply(drobch32 _value)
		{
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * new drobch64(_value);
				}
			}
			return new_mtx;
		}
		
		public matrica ___Multiply(drobch64 _value)
		{
			matrica mtx = new matrica(this.value);
			matrica new_mtx = new matrica(this.value);
			for (long  i = 0; i < (long)mtx.Count[0]; i++)
			{
				for (long j = 0; i < (long)mtx.Count[0]; j++)
				{
					if (j >= (long)mtx.Count[0] || j >= (long)mtx.Count[0]) //This is a BUG -  not in my code but in compiler. Without this if statement there is out of range index error!
					{
						break; //BUG - logic wise this if statment is redundant, but needs it here!
					}
					new_mtx[(ulong)j, (ulong)i] = mtx[(ulong)j, (ulong)i] * _value;
				}
			}
			return new_mtx;
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
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(short _value, uint scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(short _value, ulong scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(short _value, natch16 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(short _value, natch32 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(short _value, natch64 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(int _value, ushort scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(int _value, uint scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(int _value, ulong scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(int _value, natch16 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(int _value, natch32 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(int _value, natch64 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(long _value, ushort scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(long _value, uint scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(long _value, ulong scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(long _value, natch16 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(long _value, natch32 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(long _value, natch64 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(float _value, ushort scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(float _value, uint scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(float _value, ulong scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(float _value, natch16 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(float _value, natch32 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(float _value, natch64 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(double _value, ushort scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(double _value, uint scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(double _value, ulong scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(double _value, natch16 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(double _value, natch32 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
			}

			return mtx;
		}
		
		public static matrica MatricaToNumeric(double _value, natch64 scales)
		{
			matrica mtx = new matrica(scales);
			for (ulong i = 0; i < (ulong)mtx.Count[0]; i++)
			{
				mtx[i, i] = new drobch64(_value);;
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

