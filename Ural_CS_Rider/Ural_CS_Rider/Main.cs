
using Ural_CS_Rider.Ural_translator_compiler.Libraries.UralMathLib;

namespace Ural_CS_Rider
{
    class MainClass
    {
        public static unsafe void Main(string[] args)
        {
            str10 s = new str10("Hello12345678");
            int[] cyan = new int[4] {1, 0, 0, 0};
            int[] rgb = UralMath.Cvet.cmyk2rgb(cyan);
            int[] ryb = UralMath.Cvet.rgb2ryb(UralMath.Cvet.cmyk2rgb(cyan));
            int[] ryb2 = UralMath.Cvet.rgb2ryb(new int[3] { ryb[0], ryb[1], ryb[2] });
            Console.WriteLine($"{rgb[0]}, {rgb[1]}, {rgb[2]}");
            Console.WriteLine($"{ryb[0]}, {ryb[1]}, {ryb[2]}");
            Console.WriteLine($"{ryb2[0]}, {ryb2[1]}, {ryb2[2]}");
        }

        static double f(dynamic x, dynamic y)
        {
            return (x*2 + y*2);
        }
    }
}
