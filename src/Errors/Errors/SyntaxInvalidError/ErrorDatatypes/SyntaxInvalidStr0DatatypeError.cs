using System;
using Errors;

namespace Errors.SyntaxInvalidError.ErrorDatatypes

{
    public class SyntaxInvalidStr0DatatypeError : Error
    {
        public SyntaxInvalidStr0DatatypeError(int _position_start, int _position_end,
            string _error_name = "Синтаксическая ошибка: неверное создание стр0.",
            string _discription = " Синтаксическая ошибка при попытке создания символа.") : base(_position_start,
            _position_end, _error_name, _discription)
        {
            // Inherited Constructor
        }
    }
}