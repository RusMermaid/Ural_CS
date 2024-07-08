
using Sprache;
using Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree;

using LambdaExpression = Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree.LambdaExpression;
namespace Datatypes.Collections.MathCollections.LambdaAnaliz
{
	public static class LambdaParser
	{
		/// <summary>
		/// Parses any input from the console, a definition or expression
		/// </summary>
		/// <param name="input">The line to parse</param>
		/// <returns>A LambdaTerm object representing the expression or the definition, which can be written out to the console as output</returns>
		public static LambdaTerm ParseLine(string input)
		{
			return Line.Parse(input);
		}

		public static void ParseDefinition(string input)
		{
			if (input != null && input != "")
			{
				LDefinition.Parse(input);
			}
		}

		/// <summary>
		/// Parses a lambda expression
		/// </summary>
		/// <param name="input">The string to parse</param>
		/// <returns>A LambdaExpression representing the expression parsed</returns>
		public static LambdaExpression ParseTerm(string input)
		{
			return new LambdaExpression(LTermFunction.Parse(input));
		}

		//Parses an integer and returns the Church-encoded term for that integer
		static readonly Parser<LambdaTerm> LNumber = Parse.Digit.AtLeastOnce().Text().Select(s => GetNumber(Convert.ToInt32(s)));

		//Parses a word (two or more letters), returning that word as a string
		static readonly Parser<string> LWord =
			from first in Parse.Letter.Once().Text()
			from next in Parse.Letter.AtLeastOnce().Text()
			select first + next;

		//Parses a single letter into a LambdaVariable
		static readonly Parser<LambdaVariable> LVariable = Parse.Letter.Once().Text().Select(s => new LambdaVariable(s));

		//Parses the "input" part of a lambda function
		static readonly Parser<LambdaVariable> LDeclaration =
			from lam in Parse.Char('\\')
			from lVar in LVariable
			select new LambdaVariable(lVar.Name);

		//Parses a term in parentheses or several other parsers above
		static readonly Parser<LambdaTerm> LFactor =
		   (from lparen in Parse.Char('(')
			from term in Parse.Ref(() => LTermFunction)
			from rparen in Parse.Char(')')
			select term)
			.Or(LDeclaration)
			.Or(LWord.Select(s => GetTermFromWord(s)))
			.Or(LVariable)
			.Or(LNumber);

		//Parse functions and applications by considering them to be operators
		//Eliminated problems with recursive grammar in a parser-combinator
		static readonly Parser<LambdaTerm> LTermApplication = Parse.ChainOperator(Parse.Char(' '), LFactor, (op, first, second) => new LambdaApplication(first, second));
		static readonly Parser<LambdaTerm> LTermFunction = Parse.ChainRightOperator(Parse.Char('.'), LTermApplication, (op, first, second) =>
		{
			if (first.GetType() == typeof(LambdaVariable)) return new LambdaFunction((first as LambdaVariable), second);
			else throw new ParseException("Something went funny - first is: " + first.ToString());
		});

		//Parses a term into a LambdaExpression object
		static readonly Parser<LambdaTerm> LTerm = LTermFunction.Select(s => new LambdaExpression(s));

		//Parses definitions
		static readonly Parser<LambdaTerm> LDefinition =
			from word in LWord
			from sign in Parse.Char('=').Token()
			from expr in Parse.AnyChar.Many().Text()
			select new TermDefinition(word, expr);

		//Parses anything! Wow!
		static readonly Parser<LambdaTerm> Line = LDefinition.Or(LTerm);

		/// <summary>
		/// Turns an integer into a Church-encoded number
		/// </summary>
		/// <param name="toGet">The int to convert</param>
		/// <returns>The Church-encoded LambdaTerm</returns>
		static LambdaTerm GetNumber(int toGet)
		{
			string lambdaNumber = @"(\f.\a.";
			for (int i = 1; i <= toGet; i++)
			{
				lambdaNumber += "(f ";
			}
			lambdaNumber += "a";
			for (int i = 1; i <= toGet; i++)
			{
				lambdaNumber += ")";
			}
			lambdaNumber += ")";

			var num = ParseTerm(lambdaNumber).Root;
			num.Parent = null;

			return num;
		}

		/// <summary>
		/// Searches the list of defined terms in the interpreter's runtime environment
		/// </summary>
		/// <param name="word">The name of the term</param>
		/// <returns>The LambdaTerm you're looking for</returns>
		static LambdaTerm GetTermFromWord(string word)
		{
			string wordOut = @"""
				                           true = \x.\y.x
				                           false = \x.\y.y
				                           
				                           and = \a.\b.a b a
				                           or = \a.\b.a a b
				                           not = \a.a false true
				                           
				                           pair = \a.\b.\f.f a b
				                           first = \p.p true
				                           second = \p.p false
				                           
				                           suc = \n.\f.\a.f (n f a)
				                           add = \m.\n.\f.\a.m f (n f a)
				                           mult = \m.\n.\f.m (n f)
				                           pow = \m.\n.n m
				                           pred = \n.\f.\a.n (\g.\h.h (g f)) (\u.a) (\u.u)
				                           sub = \m.\n.n pred m
				                           """;

			return LTermFunction.Parse(wordOut);
		}
	}
}

