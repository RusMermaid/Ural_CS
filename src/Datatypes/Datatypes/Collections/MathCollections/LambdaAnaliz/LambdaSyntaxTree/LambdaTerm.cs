namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree;

public class LambdaTerm
{
    public LambdaTerm Parent = null;

    public virtual RCI BetaReduce() => new RCI(false);

    public virtual RCI IsBound(str10 variable) => new RCI(false);

    public virtual celch64 GetDeBruijnIndex(string name = "") => new celch64(-1);

    public virtual str10 PrintDeBruijn() => null;

    public virtual str10 PrintBinary() => null;

    public virtual binch ToBinary() => null;

    internal virtual void Replace(LambdaVariable what, LambdaTerm with)
    {
    }
}