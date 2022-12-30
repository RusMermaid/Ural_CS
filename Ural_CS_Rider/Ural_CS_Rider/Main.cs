using Ural_CS_Rider.Ural_translator_compiler.Datatypes;
using Ural_CS_Rider.Ural_translator_compiler.Libraries.UralMathLib;

namespace Ural_CS_Rider
{
    class MainClass
    {
        public static unsafe void Main(string[] args)
        {
            str32 b = new str32("0123456789");
            Console.WriteLine(b.___Multiply(new celch16(-5)).value);
        }
        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
        }
    }
}


