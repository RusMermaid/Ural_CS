using System;
namespace Ural.Ural_translator_compliler.Errors

{
    public class SyntaxInvalidStringDatatypeError : Error
    {
        public SyntaxInvalidStringDatatypeError(int _position_start, int _position_end, string _error_name = "Синтаксическая ошибка: неверная строка.", string _discription = "Синтаксическая ошибка при некорректном создании строк.") : base(_position_start, _position_end, _error_name, _discription)
        {
            // Inherited Constructor
        }


    }
}
