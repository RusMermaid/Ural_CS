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

			Input = input;
			Output = output;
            Input.IsDefinition = true;
		}

        /// <summary>
        /// If the function gets a call to perform a beta-reduce, just pass it on
        /// </summary>
        /// <returns></returns>
        public override bool BetaReduce()
		{
			try
			{
				return Output.BetaReduce();
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
			if (Input.Name == variable) return true;
			else
			{
				return Parent == null ? false : Parent.IsBound(variable);
			}
		}

		/// <summary>
		/// Passes it on
		/// </summary>
		/// <param name="what"></param>
		/// <param name="with"></param>
		internal override void Replace(LambdaVariable what, LambdaTerm with)
		{
			Output.Replace(what, with);
		}

        public override int GetDeBruijnIndex(string name = "")
		{
			if (name == Input.Name)
			{
				return 1;
			}
			else
			{
				var parentDeBruijn = Parent.GetDeBruijnIndex(name);
				return parentDeBruijn < 0 ? parentDeBruijn : parentDeBruijn + 1;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>A nice string representation of the object</returns>
		public override string ToString()
		{
			return "\\" + Input.ToString() + "." + Output.ToString();
		}

		public override string PrintDeBruijn()
		{
			return "\\." + Output.PrintDeBruijn();
		}
	}
}
