using Datatypes.Booleans;
using Datatypes.Numbers;
using Datatypes.Strings;

namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree;

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

    
    public override RCI BetaReduce()
    {
        try { return this.Output.BetaReduce(); }
        catch { return true; }
    }

    
    public override RCI IsBound(str10 variable)
    {
        if (this.Input.Name == variable)
        {
            return true;
        }

        return (this.Parent != null) && this.Parent.IsBound(variable);
    }

    
    internal override void Replace(LambdaVariable what, LambdaTerm with)
    {
        this.Output.Replace(what, with);
    }

    public override celch64 GetDeBruijnIndex(string name = "")
    {
        if (name == this.Input.Name)
        {
            return new celch64(1);
        }

        celch64 parentDeBruijn = this.Parent.GetDeBruijnIndex(name);
        return parentDeBruijn < 0 ? parentDeBruijn : parentDeBruijn + 1;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>A nice string representation of the object</returns>
    public override string ToString() => "λ" + this.Input + "." + this.Output;

    public override str10 PrintDeBruijn() => "λ." + this.Output.PrintDeBruijn();
}