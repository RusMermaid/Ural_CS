using System;
using Ural.Ural_translator_compliler.Datatypes.Numbers;
using Ural.Ural_translator_compliler.Datatypes.Booleans;
using Ural.Ural_translator_compliler.Datatypes.Strings;
using Ural.Ural_translator_compliler.Datatypes;

using Ural.Ural_translator_compliler.Errors;
using Ural.Ural_translator_compliler.Operations;
using Ural.Ural_translator_compliler;
namespace Ural
{
    class MainClass
        //Testing Ivan
    {
        public static void Main(string[] args)
        {
            /*
            celch32 num1 = new celch32(187);
            celch32 num2 = new celch32(27);

            Console.WriteLine(num1.modulo(num2).value);

            Token test = new Token("INT", "5");
            Error test_error = new SyntaxInvalidCharacterError(6, 9);


            str32 val1 = new str32('G');
            natch64 val2 = new natch64(9);
            RCI val3 = new RCI(true);
            
            drobch32 num3 = new drobch32(7);
            drobch32 num4 = new drobch32(3.);

            Console.WriteLine(num3.divide(num4).value);
            */
            drobch64 num5 = new drobch64(8.0D);
            int? x = (int?)6.9D;
            Console.WriteLine(num5);
            Console.WriteLine(x);
            Console.WriteLine(num5.GetType());
            Console.WriteLine(num5.value.GetType());
            Console.WriteLine(num5.value);
            Console.ReadKey();
            //Console.WriteLine(test.value, Token.digit_const_str);
            //Console.WriteLine($"{val3.value}, {val3.value.GetType()}");
        }
    }

    
}
