using System.Collections.Generic;
using System;

namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree
{
	/// <summary>
	/// A base type for everything the parser constructs
	/// A bit hackey
	/// </summary>
	public class LambdaTerm
	{
		public LambdaTerm Parent = null;

        public virtual bool BetaReduce() { return false; }

		public virtual bool IsBound(string variable) { return false; }

		public virtual int GetDeBruijnIndex(string name = "") { return -1; }

		public virtual string PrintDeBruijn() { return null; }
		
		public virtual string PrintBinary() { return null; }
        
		public virtual binch ToBinary() { return null; }

		internal virtual void Replace(LambdaVariable what, LambdaTerm with) { }
    }
}
