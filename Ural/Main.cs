using System;
using Ural.Ural_translator_compliler.Datatypes.Numbers;
using Ural.Ural_translator_compliler.Datatypes.Numbers.OtherNumbers;
using Ural.Ural_translator_compliler.Datatypes.Numbers.OtherNumbers.Binary;
using Ural.Ural_translator_compliler.Datatypes.Numbers.OtherNumbers.Octal;
using Ural.Ural_translator_compliler.Datatypes.Numbers.OtherNumbers.Hexadecimal;
using Ural.Ural_translator_compliler.Datatypes.Booleans;
using Ural.Ural_translator_compliler.Datatypes.Strings;
using Ural.Ural_translator_compliler.Datatypes;


using Ural.Ural_translator_compliler.Errors;
using Ural.Ural_translator_compliler.Errors.SyntaxInvalidError;
using Ural.Ural_translator_compliler.Errors.SyntaxInvalidError.ErrorDatatypes;
using Ural.Ural_translator_compliler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;
using Ural.Ural_translator_compliler.Operations;
using Ural.Ural_translator_compliler;
namespace Ural
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            binch num1 = new binch(-18);
            binch num2 = new binch(3);
            int[] array = { 297, 183, 464, 1112, 0, -9, 127};
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");

            VOID.CocktailSort(array);

            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");
            //Console.WriteLine(num1.add(num2) + " " + num1.add(num2).BinchToNatch());
            Console.ReadKey();
            
        }
    }
}