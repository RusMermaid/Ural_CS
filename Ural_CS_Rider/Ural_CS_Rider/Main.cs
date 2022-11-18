
using Ural_CS_Rider.Ural_translator_compiler.Libraries.UralMathLib;

namespace Ural_CS_Rider
{
    class MainClass
    {
        public static unsafe void Main(string[] args)
        {
            str10 s = new str10("Hello12345678");
            int[] rgb = new int[3] { 1, 1, 1};
            int[] cmyk = UralMath.Cvet.rgb2cmyk(rgb);
            
            Console.WriteLine($"{cmyk[0]}, {cmyk[1]}, {cmyk[2]}, {cmyk[3]}");
        }
        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
        }
    }
}


