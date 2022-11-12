
namespace Ural_CS_Rider
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
