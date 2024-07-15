using System.Collections.Generic;
using System;

namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree
{
	public class LambdaFunction : LambdaTerm
	{
		//The "argument," if you will
		public LambdaVariable Input;

		//The output of this function
		public LambdaTerm Output;

		public LambdaFunction(LambdaVariable input, LambdaTerm output)
		{
			input.Parent = this;
			output.Parent = this;

			this.Input = input;
			this.Output = output;
			this.Input.IsDefinition = true;
		}

        /// <summary>
        /// If the function gets a call to perform a beta-reduce, just pass it on
        /// </summary>
        /// <returns></returns>
        public override bool BetaReduce()
		{
			try
			{
				return this.Output.BetaReduce();
			}
			catch
			{
				return true;
			}
		}

		/// <summary>
		/// Checks to see if a variable is bound
		/// </summary>
		/// <param name="variable">The name of the variable</param>
		/// <returns>True if this functions binds the variable, otherwise it passes the check to its parent</returns>
		public override bool IsBound(string variable)
		{
			if (this.Input.Name == variable) return true;
			return this.Parent != null && this.Parent.IsBound(variable);
		}

		/// <summary>
		/// Passes it on
		/// </summary>
		/// <param name="what"></param>
		/// <param name="with"></param>
		internal override void Replace(LambdaVariable what, LambdaTerm with)
		{
			this.Output.Replace(what, with);
		}

        public override int GetDeBruijnIndex(string name = "")
        {
	        if (name == this.Input.Name)
			{
				return 1;
			}

	        int parentDeBruijn = this.Parent.GetDeBruijnIndex(name);
	        return parentDeBruijn < 0 ? parentDeBruijn : parentDeBruijn + 1;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns>A nice string representation of the object</returns>
		public override string ToString()
		{
			return "λ" + this.Input.ToString() + "." + this.Output.ToString();
		}

		public override string PrintDeBruijn()
		{
			return "λ." + this.Output.PrintDeBruijn();
		}
	}
}
