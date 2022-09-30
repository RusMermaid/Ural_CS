using System;
using System.Collections;
using System.Collections.Generic;

using Ural.Ural_translator_compliler.Datatypes.Numbers;
using Ural.Ural_translator_compliler.Datatypes.Numbers.OtherNumbers;
using Ural.Ural_translator_compliler.Datatypes.Numbers.OtherNumbers.Binary;
using Ural.Ural_translator_compliler.Datatypes.Numbers.OtherNumbers.Octal;
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

using Ural.Ural_translator_compliler.Libraries.UralMathLib;

namespace Ural
{
    class MainClass
    {
        public unsafe static void Main()
        {
            binch num1 = new binch(-12);
            binch num2 = new binch(-100);
            Console.WriteLine(binch.Add(VOID.Slice(num1.value, 2), VOID.Slice(num2.value, 2)));
            Console.ReadKey();
        }


        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
        }
    }
}
