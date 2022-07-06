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

            drobch16 num1 = new drobch16(655);
            drobch64 num2 = new drobch64(num1);
            Console.WriteLine(num2.value);
            Console.WriteLine(num2.value.GetType());
        }
    }

    
}
