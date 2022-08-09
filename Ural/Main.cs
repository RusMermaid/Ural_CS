using System;
using Ural.Ural_translator_compliler.Datatypes.Numbers;
using Ural.Ural_translator_compliler.Datatypes.Numbers.OtherNumbers;
using Ural.Ural_translator_compliler.Datatypes.Numbers.OtherNumbers.Binary;
using Ural.Ural_translator_compliler.Datatypes.Numbers.OtherNumbers.Hexadecimal;
using Ural.Ural_translator_compliler.Datatypes.Booleans;
using Ural.Ural_translator_compliler.Datatypes.Strings;
using Ural.Ural_translator_compliler.Datatypes;


using Ural.Ural_translator_compliler.Errors;
using Ural.Ural_translator_compliler.Errors.SyntaxInvalidError;
using Ural.Ural_translator_compliler.Errors.SyntaxInvalidError.ErrorDatatypes;
using Ural.Ural_translator_compliler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;
using Ural.Ural_translator_compliler.Operations;
using Ural.Ural_translator_compliler;
namespace Ural
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            binch num1 = new binch(1);
            Console.WriteLine(num1);
            Console.ReadKey();
            
        }
    }
}