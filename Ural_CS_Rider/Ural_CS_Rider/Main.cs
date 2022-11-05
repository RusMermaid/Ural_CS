

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
using static Ural_CS_Rider.Ural_translator_compiler.Libraries.UralMathLib.UralMath;
using static Ural_CS_Rider.Ural_translator_compiler.Libraries.UralMathLib.UralMath;
using System;

namespace Ural
{
    class MainClass
    {
        public static unsafe void Main(string[] args)
        {
            int[] c = new int[3] { 125, 125, 0 };
            str10 s = new str10("-79");
            Console.WriteLine($"{Cvet.ryb2rgb(c)[0]} {Cvet.ryb2rgb(c)[1]} {Cvet.ryb2rgb(c)[2]}");




            RCI x = new RCI(true);
            if (x)
            {
                Console.WriteLine(x);
            }
            
        }

        

        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
        }
    }
}
