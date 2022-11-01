

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
            str10 s = new str10("-79");
            Console.WriteLine(s.EtoCifra());
        }

        

        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
        }
    }
}
