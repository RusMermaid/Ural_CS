using System;
using Ural.Ural_translator_compliler.Datatypes.Numbers;
using Ural.Ural_translator_compliler.Datatypes.Strings;
using Ural.Ural_translator_compliler.Datatypes;

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
            Error test_error = new SyntaxInvalidCharacterError(6, 9);

            str16 val = new str16("Меня держат в заложниках и пытают Python помогите");

            //Console.WriteLine(test.value, Token.digit_const_str);
            Console.WriteLine($"{val.value}, {val.value.GetType()}");
            ConsoleKeyInfo info = Console.ReadKey();
        }
    }
}
