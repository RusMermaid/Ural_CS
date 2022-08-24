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

using Ural.Ural_translator_compliler.Libraries.MathLib;

namespace Ural
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(UralMath.Factorial(7));
            Console.WriteLine(UralMath.TaylorFunction(0, 1, f));









            static double f(dynamic x)
            {
                return (Math.Cos((float)x));
            // f(x) = x^2/2 + 1
            }
        }
    }
}
