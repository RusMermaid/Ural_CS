using System;
using Ural.Ural_translator_compliler.Datatypes.Numbers;
using Ural.Ural_translator_compliler.Datatypes.Booleans;
using Ural.Ural_translator_compliler.Datatypes.Strings;
using Ural.Ural_translator_compliler.Datatypes;


using Ural.Ural_translator_compliler.Errors;
using Ural.Ural_translator_compliler.Errors.SyntaxInvalidError;
using Ural.Ural_translator_compliler.Operations;
using Ural.Ural_translator_compliler;
namespace Ural
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            drobch64 num1 = new drobch64(500);
            drobch16 num2 = new drobch16(31);
            RCI bool1 = new RCI(true);
            Console.WriteLine(num1.add(num2).value);
            Console.WriteLine(bool1);
            drobch16 num = new drobch16(4294967296L);
            Console.ReadKey();
        }
    }
}