
namespace Ural_CS_Rider
{
    class MainClass
    {
        public static unsafe string Main()
        {
            matrica c = new matrica(2);
            c[1, 1] = new drobch64(8);
            c[1, 0] = new drobch64(-9);
            short n = 60;

            matrica d = new matrica(3);

            d[0, 0] = new drobch64(2);
            d[0, 1] = new drobch64(-2);
            d[1, 0] = new drobch64(4);
            d[1, 1] = new drobch64(6);
            d[2, 1] = new drobch64(10);
            d[2, 2] = new drobch64(2);
            d[2, 0] = new drobch64(-10);
            // StrIndexOutOfRangeError err = new StrIndexOutOfRangeError(0, 0);
            //err.Execute();

            return $"{c.ToString()}\n";
        }

        static double f(dynamic x, dynamic y)
        {
            return (x * 2 * y * 2);
        }
    }
}