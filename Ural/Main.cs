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
        public static void Main()
        {
            // lx and ux are upper and lower limit of x integral
            // ly and uy are upper and lower limit of y integral
            // h is the step size for integration wrt x
            // k is the step size for integration wrt y
            drobch32 num1 = new drobch32(3);
            drobch64 num2 = new drobch64(drobch64.MaxValue);
            Console.WriteLine(num1 - num2);
            Console.ReadKey();
        }


        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
            // f(x) = x^2/2 + 1
        }
    }
}
