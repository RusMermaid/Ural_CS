using Ural_CS_Rider.Ural_translator_compiler.Datatypes;
using Ural_CS_Rider.Ural_translator_compiler.Libraries.UralMathLib;

namespace Ural_CS_Rider
{
    class MainClass
    {
        public static unsafe void Main(string[] args)
        {
            str32 b = new str32("0123456789");
            natch64 f = new natch64(5);
            Console.WriteLine(b*f);
        }
        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
        }
    }
}


