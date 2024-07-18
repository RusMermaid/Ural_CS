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

    /// <summary>
    /// Recursively tells First and Second to b-reduce, then beta reduces this application
    /// </summary>
    /// <returns>True if a beta reduction happened, false if not</returns>
    public override bool BetaReduce()
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
            return true;
        }

        bool toReturn;

        try
        {
            //Tell both sides to b-reduce
            toReturn = this.First.BetaReduce() | this.Second.BetaReduce();
        }
        catch { return true; }

        return toReturn;
    }

    /// <summary>
    /// Passes it on
    /// </summary>
    /// <param name="what"></param>
    /// <param name="with"></param>
    internal override void Replace(LambdaVariable what, LambdaTerm with)
    {
        this.First.Replace(what, with);
        this.Second.Replace(what, with);
    }

    /// <summary>
    /// If a variable is bound, we won't be able to tell that from an application (pass it on)
    /// </summary>
    /// <param name="variable"></param>
    /// <returns></returns>
    public override bool IsBound(string variable) => (this.Parent != null) && this.Parent.IsBound(variable);

    public override int GetDeBruijnIndex(string name = "") => this.Parent.GetDeBruijnIndex(name);

    /// <summary>
    /// 
    /// </summary>
    /// <returns>An appropriate string representation of the object</returns>
    public override string ToString()
    {
        string? firstString = this.First.GetType() == typeof(LambdaVariable) ? this.First.ToString() : "(" + this.First + ")";
        string? secondString = this.Second.GetType() == typeof(LambdaVariable) ? this.Second.ToString() : "(" + this.Second + ")";

        return firstString + " " + secondString;
    }

    public override string PrintDeBruijn() => this.First.PrintDeBruijn() + " (" + this.Second.PrintDeBruijn() + ")";
}