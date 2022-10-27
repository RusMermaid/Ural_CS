

using Ural.Ural_translator_compiler.Datatypes.Numbers;
using Ural.Ural_translator_compiler.Datatypes.Numbers.OtherNumbers;
using Ural.Ural_translator_compiler.Datatypes.Numbers.OtherNumbers.Binary;
using Ural.Ural_translator_compiler.Datatypes.Numbers.OtherNumbers.Octal;
using Ural.Ural_translator_compiler.Datatypes.Numbers.OtherNumbers.Hexadecimal;
using Ural.Ural_translator_compiler.Datatypes.Booleans;
using Ural.Ural_translator_compiler.Datatypes.Strings;
using Ural.Ural_translator_compiler.Datatypes;

using Ural.Ural_translator_compiler.Errors;
using Ural.Ural_translator_compiler.Errors.SyntaxInvalidError;
using Ural.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes;
using Ural.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;
using Ural.Ural_translator_compiler.Operations;
using Ural.Ural_translator_compiler;
using Ural;
using Ural.Ural_translator_compiler.Libraries;
using Ural.Ural_translator_compiler.Libraries.UralMathLib;

using static Ural.Ural_translator_compiler.Libraries.UralMathLib.HilbertsCurve.UralMath;
using static Ural.Ural_translator_compiler.Libraries.UralMathLib.SievePrimes.UralMath;
using System;

namespace Ural
{
    class MainClass
    {
        public static unsafe void Main()
        {
            binch num1 = new binch(7);
            binch num2 = new binch(3);
            List<int> z = new List<int>() {1, 2, 3};
            HilbertsCurve hc = new HilbertsCurve(2, 3);

            //Console.WriteLine(num2);
            Console.WriteLine(hc.Point_from_distance(6)[1]);
            Console.ReadKey();
        }


        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
        }
    }
}
