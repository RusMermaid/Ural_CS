#region

using Datatypes.Collections.MathCollections.LambdaAnaliz;
using Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree;
using LambdaExpression = Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree.LambdaExpression;
using UralConsole = Colorful.Console;

#endregion

// ReSharper disable ClassNeverInstantiated.Global

namespace Ural_CS_Rider;

internal class MainClass
{
    public static unsafe void Main(string [] args)
    {
        str10 lambdaExpression = @"λx.λy.λz.x z (y z)"; //S combinator
        LambdaExpression lala = LambdaParser.ParseTerm(lambdaExpression);
        LambdaTerm lala2 = LambdaParser.ParseLine(lambdaExpression);

        Console.WriteLine(lala.PrintBinary());

        
    }

    
}