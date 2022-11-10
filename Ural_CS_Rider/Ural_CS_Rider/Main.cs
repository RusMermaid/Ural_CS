

using Ural_CS_Rider.Ural_translator_compiler.Datatypes.Numbers;
using Ural_CS_Rider.Ural_translator_compiler.Datatypes.Numbers.OtherNumbers;
using Ural_CS_Rider.Ural_translator_compiler.Datatypes.Numbers.OtherNumbers.Binary;
using Ural_CS_Rider.Ural_translator_compiler.Datatypes.Numbers.OtherNumbers.Octal;
using Ural_CS_Rider.Ural_translator_compiler.Datatypes.Numbers.OtherNumbers.Hexadecimal;
using Ural_CS_Rider.Ural_translator_compiler.Datatypes.Booleans;
using Ural_CS_Rider.Ural_translator_compiler.Datatypes.Strings;
using Ural_CS_Rider.Ural_translator_compiler.Datatypes;

using Ural_CS_Rider.Ural_translator_compiler.Errors;
using Ural_CS_Rider.Ural_translator_compiler.Errors.SyntaxInvalidError;
using Ural_CS_Rider.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes;
using Ural_CS_Rider.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;
using Ural_CS_Rider.Ural_translator_compiler.Operations;
using Ural_CS_Rider.Ural_translator_compiler;
using Ural_CS_Rider;
using static Ural_CS_Rider.Ural_translator_compiler.Libraries.UralMathLib.UralMath;
using static Ural_CS_Rider.Ural_translator_compiler.Libraries.UralMathLib.UralMath;
using System;

namespace Ural
{
    class MainClass
    {
        public static unsafe void Main(string[] args)
        {
            str10 s = new str10("Hello12345678");
            Console.WriteLine(s[5, 10, 2]);
        }

        

        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
        }
    }
}
