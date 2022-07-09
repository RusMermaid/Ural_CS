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
    {
        public static void Main(string[] args)
        {

            drobch16 num = new drobch16(4294967296L);

            Console.ReadKey();
            drobch64 num1 = new drobch64(-655);
            dynamic x = 0;
            x = true;
            Console.WriteLine(x);
            Console.WriteLine(num1.abs(num1.value).value);
            Console.WriteLine(num1.abs(num1).value);
        }
    }

    
}
