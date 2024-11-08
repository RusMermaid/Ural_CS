using Datatypes.Booleans;
using Datatypes.Strings;

namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree;


public class TermDefinition : LambdaTerm
{
    public str10 Name;
    private RCI isFirstDefinition;

    public TermDefinition(str10 name, str10 term)
    {
        this.Name = name;

        this.isFirstDefinition = new RCI(true);


        //RuntimeEnvironment.Terms.Add(name, term);
    }

    
    public override string ToString() => (!this.isFirstDefinition ? "re" : "") + "defined " + this.Name;
}