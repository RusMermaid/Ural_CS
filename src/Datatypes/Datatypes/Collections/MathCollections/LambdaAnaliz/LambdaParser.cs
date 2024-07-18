#region

using Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree;
using Errors.SyntaxInvalidError.ErrorDatatypes;
using Sprache;
using LambdaExpression = Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree.LambdaExpression;

#endregion

namespace Datatypes.Collections.MathCollections.LambdaAnaliz;

public static class LambdaParser
{
    /// <summary>
    /// Parses any input from the console, a definition or expression
    /// </summary>
    /// <param name="input">The line to parse</param>
    /// <returns>A LambdaTerm object representing the expression or the definition, which can be written out to the console as output</returns>
    public static LambdaTerm ParseLine(string input) => Line.Parse(input);


    /// <summary>
    /// Parses a lambda expression
    /// </summary>
    /// <param name="input">The string to parse</param>
    /// <returns>A LambdaExpression representing the expression parsed</returns>
    public static LambdaExpression ParseTerm(string input) => new LambdaExpression(LTermFunction.Parse(input));

    //Parses an integer and returns the Church-encoded term for that integer
    private static readonly Parser<LambdaTerm> LNumber = Parse.Digit.AtLeastOnce().Text().Select(convert: s => GetNumber(Convert.ToInt32(s)));

    //Parses a word (two or more letters), returning that word as a string
    private static readonly Parser<string> LWord =
        from first in Parse.Letter.Once().Text()
        from next in Parse.Letter.AtLeastOnce().Text()
        select first + next;

    //Parses a single letter into a LambdaVariable
    private static readonly Parser<LambdaVariable> LVariable = Parse.Letter.Once().Text().Select(convert: s => new LambdaVariable(s));

    //Parses the "input" part of a lambda function
    private static readonly Parser<LambdaVariable> LDeclaration =
        from lam in Parse.Char('λ')
        from lVar in LVariable
        select new LambdaVariable(lVar.Name);

    //Parses a term in parentheses or several other parsers above
    private static readonly Parser<LambdaTerm> LFactor =
        (from lparen in Parse.Char('(')
            from term in Parse.Ref(reference: () => LTermFunction)
            from rparen in Parse.Char(')')
            select term)
        .Or(LDeclaration)
        .Or(LWord.Select(convert: s => GetTermFromWord(s)))
        .Or(LVariable)
        .Or(LNumber);

    //Parse functions and applications by considering them to be operators
    //Eliminated problems with recursive grammar in a parser-combinator
    private static readonly Parser<LambdaTerm> LTermApplication =
        Parse.ChainOperator(Parse.Char(' '), LFactor, apply: (op, first, second) => new LambdaApplication(first, second));

    private static readonly Parser<LambdaTerm> LTermFunction = Parse.ChainRightOperator(Parse.Char('.'), LTermApplication, apply: (op, first, second) =>
    {
        if (first.GetType() == typeof(LambdaVariable))
        {
            return new LambdaFunction(first as LambdaVariable, second);
        }

        throw new SyntaxInvalidLambdaDatatypeError(0, 0);
    });

    //Parses a term into a LambdaExpression object
    private static readonly Parser<LambdaTerm> LTerm = LTermFunction.Select(convert: s => new LambdaExpression(s));

    //Parses definitions
    private static readonly Parser<LambdaTerm> LDefinition =
        from word in LWord
        from sign in Parse.Char('=').Token()
        from expr in Parse.AnyChar.Many().Text()
        select new TermDefinition(word, expr);

    //Parses anything! Wow!
    private static readonly Parser<LambdaTerm> Line = LDefinition.Or(LTerm);

    /// <summary>
    /// Turns an integer into a Church-encoded number
    /// </summary>
    /// <param name="toGet">The int to convert</param>
    /// <returns>The Church-encoded LambdaTerm</returns>
    private static LambdaTerm GetNumber(int toGet)
    {
        string lambdaNumber = @"(λf.λa.";
        for (int i = 1; i <= toGet; i++) lambdaNumber += "(f ";

        lambdaNumber += "a";
        for (int i = 1; i <= toGet; i++) lambdaNumber += ")";

        lambdaNumber += ")";

        LambdaTerm num = ParseTerm(lambdaNumber).Root;
        num.Parent = null;

        return num;
    }

    /// <summary>
    /// Searches the list of defined terms in the interpreter's runtime environment
    /// </summary>
    /// <param name="word">The name of the term</param>
    /// <returns>The LambdaTerm you're looking for</returns>
    private static LambdaTerm GetTermFromWord(string word)
    {
        string wordOut = @"""
				                           true = λx.λy.x
				                           false = λx.λy.y
				                           
				                           and = λa.λb.a b a
				                           or = λa.λb.a a b
				                           not = λa.a false true
				                           
				                           pair = λa.λb.\f.f a b
				                           first = λp.p true
				                           second = λp.p false
				                           
				                           suc = λn.λf.λa.f (n f a)
				                           add = λm.λn.λf.λa.m f (n f a)
				                           mult = λm.λn.λf.m (n f)
				                           pow = λm.λn.n m
				                           pred = λn.λf.λa.n (λg.λh.h (g f)) (λu.a) (λu.u)
				                           sub = λm.λn.n pred m
				                           """;

        return LTermFunction.Parse(wordOut);
    }
}