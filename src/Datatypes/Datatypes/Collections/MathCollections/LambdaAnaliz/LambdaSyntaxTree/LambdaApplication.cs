
namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree
{
	public class LambdaApplication : LambdaTerm
	{
		//The left-hand side of the application
		public LambdaTerm First;

		//The right-hand side
		public LambdaTerm Second;

		public LambdaApplication(LambdaTerm first, LambdaTerm second)
		{
			first.Parent = this;
			second.Parent = this;

			First = first;
			Second = second;
		}

		/// <summary>
		/// Recursively tells First and Second to b-reduce, then beta reduces this application
		/// </summary>
		/// <returns>True if a beta reduction happened, false if not</returns>
		public override bool BetaReduce()
		{
			if (First.GetType() == typeof(LambdaFunction))
			{
				//If the left-hand side of an application is a function, then b-reduction can happen, woo
				var toReduce = (First as LambdaFunction);

				var reduceInput = toReduce.Input;

				//Create a new expression from the output, so that the bound occurrences of reduceInput in the output are no longer bound
				//This is (a little) hackey
				var reduceOutput = new LambdaExpression(toReduce.Output);

				//Call replace to replace all free occurrences of the input with the right-hand side of our application
				reduceOutput.Replace(toReduce.Input, Second);
				var reduced = reduceOutput.Root;

				//Preserve the parental relationships
				if (Parent.GetType() == typeof(LambdaExpression))
				{
					reduced.Parent = Parent;
					(Parent as LambdaExpression).Root = reduced;
				}
				else if (Parent.GetType() == typeof(LambdaFunction))
				{
					reduced.Parent = Parent;
					(Parent as LambdaFunction).Output = reduced;
				}
				else if (Parent.GetType() == typeof(LambdaApplication))
				{
					if ((Parent as LambdaApplication).First == this)
					{
						reduced.Parent = Parent;
						(Parent as LambdaApplication).First = reduced;
					}
					else
					{
						reduced.Parent = Parent;
						(Parent as LambdaApplication).Second = reduced;
					}
				}

				//We have, indeed, performed a b-reduction
				return true;
			}

			bool toReturn;

			try
			{
				//Tell both sides to b-reduce
				toReturn = this.First.BetaReduce() | this.Second.BetaReduce();
			}
			catch
			{
				return true;
			}

			return toReturn;
		}

		/// <summary>
		/// Passes it on
		/// </summary>
		/// <param name="what"></param>
		/// <param name="with"></param>
		internal override void Replace(LambdaVariable what, LambdaTerm with)
		{
			First.Replace(what, with);
			Second.Replace(what, with);
		}

		/// <summary>
		/// If a variable is bound, we won't be able to tell that from an application (pass it on)
		/// </summary>
		/// <param name="variable"></param>
		/// <returns></returns>
		public override bool IsBound(string variable)
		{
			return Parent == null ? false : Parent.IsBound(variable);
		}

		public override int GetDeBruijnIndex(string name = "")
		{
			return Parent.GetDeBruijnIndex(name);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>An appropriate string representation of the object</returns>
		public override string ToString()
		{
			var firstString = First.GetType() == typeof(LambdaVariable) ? First.ToString() : "(" + First.ToString() + ")";
			var secondString = Second.GetType() == typeof(LambdaVariable) ? Second.ToString() : "(" + Second.ToString() + ")";

			return firstString + " " + secondString;
		}

		public override string PrintDeBruijn()
		{
			return First.PrintDeBruijn() + " " + Second.PrintDeBruijn();
		}
	}
}
