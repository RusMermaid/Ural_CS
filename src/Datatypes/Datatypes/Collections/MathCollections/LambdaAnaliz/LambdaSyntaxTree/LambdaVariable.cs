
namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree
{
	public class LambdaVariable : LambdaTerm
	{
		//The name of the variable, believe it or not
		public string Name;
        public bool IsFree = false;
        public bool IsDefinition = false;

        public LambdaVariable(string name)
		{
			this.Name = name;
		}

        public bool IsBound()
		{
			return this.Parent?.IsBound(this.Name) ?? false;
		}

		/// <summary>
		/// If this is a variable with ought be replaced with another expression in a b-reduction, do so
		/// </summary>
		/// <param name="what">The variable which must be replaced</param>
		/// <param name="with">That with which we must replace what</param>
		internal override void Replace(LambdaVariable what, LambdaTerm with)
		{
			if (this.Name != what.Name || this.IsBound()) return;
			if (this.Parent.GetType() == typeof(LambdaFunction))
			{
				(this.Parent as LambdaFunction).Output = with;
				with.Parent = (this.Parent as LambdaFunction);
			}
			else if (this.Parent.GetType() == typeof(LambdaApplication))
			{
				if ((this.Parent as LambdaApplication).First == this)
				{
					(this.Parent as LambdaApplication).First = with;
					with.Parent = (this.Parent as LambdaApplication);
				}
				else
				{
					(this.Parent as LambdaApplication).Second = with;
					with.Parent = (this.Parent as LambdaApplication);
				}
			}
			else if (this.Parent.GetType() == typeof(LambdaExpression))
			{
				(this.Parent as LambdaExpression).Root = with;
				with.Parent = (this.Parent as LambdaExpression);
			}
		}
		
		public override int GetDeBruijnIndex(string name = "")
		{
			return this.Parent.GetDeBruijnIndex(this.Name);
		}

        public override string ToString()
		{
			return this.Name;
		}

		public override string PrintDeBruijn()
		{
			return this.GetDeBruijnIndex().ToString();
		}
	}
}
