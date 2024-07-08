
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
			Name = name;
		}

        public bool IsBound()
		{
			return Parent == null ? false : Parent.IsBound(Name);
		}

		/// <summary>
		/// If this is a variable with ought be replaced with another expression in a b-reduction, do so
		/// </summary>
		/// <param name="what">The variable which must be replaced</param>
		/// <param name="with">That with which we must replace what</param>
		internal override void Replace(LambdaVariable what, LambdaTerm with)
		{
			if (Name == what.Name && !IsBound())
			{
				if (Parent.GetType() == typeof(LambdaFunction))
				{
					(Parent as LambdaFunction).Output = with;
					with.Parent = (Parent as LambdaFunction);
				}
				else if (Parent.GetType() == typeof(LambdaApplication))
				{
					if ((Parent as LambdaApplication).First == this)
					{
						(Parent as LambdaApplication).First = with;
						with.Parent = (Parent as LambdaApplication);
					}
					else
					{
						(Parent as LambdaApplication).Second = with;
						with.Parent = (Parent as LambdaApplication);
					}
				}
				else if (Parent.GetType() == typeof(LambdaExpression))
				{
					(Parent as LambdaExpression).Root = with;
					with.Parent = (Parent as LambdaExpression);
				}
			}
		}
		
		public override int GetDeBruijnIndex(string name = "")
		{
			return Parent.GetDeBruijnIndex(Name);
		}

        public override string ToString()
		{
			return Name;
		}

		public override string PrintDeBruijn()
		{
			return GetDeBruijnIndex().ToString();
		}
	}
}
