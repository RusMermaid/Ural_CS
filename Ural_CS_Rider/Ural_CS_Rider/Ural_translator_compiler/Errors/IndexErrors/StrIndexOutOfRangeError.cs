using System;
using Ural_CS_Rider.Ural_translator_compiler.Errors;
namespace Ural_CS_Rider.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes
{
    public class StrIndexOutOfRangeError : Error
    {
        public StrIndexOutOfRangeError(int _position_start, int _position_end, string _error_name = "Ошибка Индекса:", string _discription = "индекс строки вне диапазона") : base(_position_start, _position_end, _error_name, _discription)
        {

        }
    }
}