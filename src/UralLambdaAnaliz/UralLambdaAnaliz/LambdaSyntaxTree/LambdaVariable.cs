using Datatypes.Booleans;
using Datatypes.Numbers;
using Datatypes.Strings;

namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree;

public class LambdaVariable : LambdaTerm
{
    //The name of the variable, believe it or not
    public str10 Name;
    public RCI IsFree = new RCI(false);
    public RCI IsDefinition = new RCI(false);

    public LambdaVariable(str10 name)
    {
        this.Name = name;
    }

    public RCI IsBound() => this.Parent?.IsBound(this.Name) ?? new RCI(false);

    
    internal override void Replace(LambdaVariable what, LambdaTerm with)
    {
        if ((this.Name != what.Name) || this.IsBound()) return;

        if (this.Parent.GetType() == typeof(LambdaFunction))
        {
            (this.Parent as LambdaFunction).Output = with;
            with.Parent = this.Parent as LambdaFunction;
        }
        else if (this.Parent.GetType() == typeof(LambdaApplication))
        {
            if ((this.Parent as LambdaApplication).First == this)
            {
                (this.Parent as LambdaApplication).First = with;
                with.Parent = this.Parent as LambdaApplication;
            }
            else
            {
                (this.Parent as LambdaApplication).Second = with;
                with.Parent = this.Parent as LambdaApplication;
            }
        }
        else if (this.Parent.GetType() == typeof(LambdaExpression))
        {
            (this.Parent as LambdaExpression).Root = with;
            with.Parent = this.Parent as LambdaExpression;
        }
    }

    public override celch64 GetDeBruijnIndex(string name ) => this.Parent.GetDeBruijnIndex(this.Name);

    public override string ToString() => new str10(this.Name);

    public override str10 PrintDeBruijn() => new str10((string)this.GetDeBruijnIndex(this.ToString()));
}