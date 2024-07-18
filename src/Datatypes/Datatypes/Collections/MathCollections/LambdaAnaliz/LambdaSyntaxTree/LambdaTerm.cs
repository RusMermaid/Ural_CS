namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree;

/// <summary>
/// A base type for everything the parser constructs
/// A bit hackey
/// </summary>
public class LambdaTerm
{
    public LambdaTerm Parent = null;

    public virtual bool BetaReduce() => false;

    public virtual bool IsBound(string variable) => false;

    public virtual int GetDeBruijnIndex(string name = "") => -1;

    public virtual string PrintDeBruijn() => null;

    public virtual string PrintBinary() => null;

    public virtual binch ToBinary() => null;

    internal virtual void Replace(LambdaVariable what, LambdaTerm with)
    {
    }
}