using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;


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
using Ural;
using Ural.Ural_translator_compliler.Libraries;
using static Ural.Ural_translator_compliler.Libraries.UralMathLib.HilbertsCurve.UralMath;
using static Ural.Ural_translator_compliler.Libraries.UralMathLib.SievePrimes.UralMath;

namespace Ural
{
    class MainClass
    {
        public unsafe static void Main()
        {
            binch num1 = new binch(7);
            binch num2 = new binch(3);
            List<int> z = new List<int>() {6, 9, 10};
            HilbertsCurve hc = new HilbertsCurve(2, 3);

            //Console.WriteLine(new string("HelloThere".Where((ch, index) => index % (2) == (0)).ToArray()));


            Console.WriteLine(hc.Distance_from_point(z));
            //Console.WriteLine(hc.Hilbert_integer_to_transpose_single(6)[1]);
            Console.ReadKey();
        }


        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
        }
    }
}
