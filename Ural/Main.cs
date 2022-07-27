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
            RCI bool1 = new RCI(true);
            RCI bool2 = new RCI(false);
            VOID void1 = new VOID();

            Console.WriteLine(bool1.NOR(bool2).value);
            Console.WriteLine(bool1.NE().NE().value);
            Console.WriteLine(void1.value);
            Console.WriteLine(void1.subvalue);
            Console.ReadKey();
        }
    }
}