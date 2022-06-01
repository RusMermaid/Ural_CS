using System;
using Ural.Ural_translator_compliler.Errors;
using Ural.Ural_translator_compliler.Operations;
using Ural.Ural_translator_compliler;
namespace Ural
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
            Token test = new Token("INT", "5");
            Error test_error = new SyntaxInvalidCharacterError(6, 9, null, null);
            Console.WriteLine(test.value, Token.digit_const_str);
            Console.WriteLine(test_error.error_name);
        }
    }
}
