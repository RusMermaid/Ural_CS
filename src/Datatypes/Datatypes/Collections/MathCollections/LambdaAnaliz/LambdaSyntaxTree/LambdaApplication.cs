namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree;

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

        this.First = first;
        this.Second = second;
    }

    
    /// <returns>True if a beta reduction happened, false if not</returns>
    public override RCI BetaReduce()
    {
        if (this.First.GetType() == typeof(LambdaFunction))
        {
            //If the left-hand side of an application is a function, then b-reduction can happen, woo
            LambdaFunction? toReduce = this.First as LambdaFunction;

            LambdaVariable reduceInput = toReduce.Input;

            //Create a new expression from the output, so that the bound occurrences of reduceInput in the output are no longer bound
            //This is (a little) hackey
            LambdaExpression reduceOutput = new LambdaExpression(toReduce.Output);

            //Call replace to replace all free occurrences of the input with the right-hand side of our application
            reduceOutput.Replace(toReduce.Input, this.Second);
            LambdaTerm reduced = reduceOutput.Root;

            //Preserve the parental relationships
            if (this.Parent.GetType() == typeof(LambdaExpression))
            {
                reduced.Parent = this.Parent;
                (this.Parent as LambdaExpression).Root = reduced;
            }
            else if (this.Parent.GetType() == typeof(LambdaFunction))
            {
                reduced.Parent = this.Parent;
                (this.Parent as LambdaFunction).Output = reduced;
            }
            else if (this.Parent.GetType() == typeof(LambdaApplication))
            {
                if ((this.Parent as LambdaApplication).First == this)
                {
                    reduced.Parent = this.Parent;
                    (this.Parent as LambdaApplication).First = reduced;
                }
                else
                {
                    reduced.Parent = this.Parent;
                    (this.Parent as LambdaApplication)!.Second = reduced;
                }
            }

            //We have, indeed, performed a b-reduction
            return new RCI(true);
        }

        bool toReturn;

        try
        {
            //Tell both sides to b-reduce
            toReturn = this.First.BetaReduce() | this.Second.BetaReduce();
        }
        catch { return new RCI(true); }

        return new RCI(toReturn);
    }

    
    internal override void Replace(LambdaVariable what, LambdaTerm with)
    {
        this.First.Replace(what, with);
        this.Second.Replace(what, with);
    }

    
    public override RCI IsBound(str10 variable) => (this.Parent != null) && this.Parent.IsBound(variable);

    public override celch64 GetDeBruijnIndex(string name = "") => new celch64(this.Parent.GetDeBruijnIndex(name));

    
    public override string ToString()
    {
        string? firstString = this.First.GetType() == typeof(LambdaVariable) ? this.First.ToString() : "(" + this.First + ")";
        string? secondString = this.Second.GetType() == typeof(LambdaVariable) ? this.Second.ToString() : "(" + this.Second + ")";

        return firstString + " " + secondString;
    }

    public override str10 PrintDeBruijn() => this.First.PrintDeBruijn() + " (" + this.Second.PrintDeBruijn() + ")";
}