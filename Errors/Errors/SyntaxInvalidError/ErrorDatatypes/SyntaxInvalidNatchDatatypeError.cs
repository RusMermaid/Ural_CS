using System;
using Errors;

namespace Errors.SyntaxInvalidError.ErrorDatatypes

{
    public class SyntaxInvalidNatchDatatypeError : Error
    {
        public SyntaxInvalidNatchDatatypeError(int _position_start, int _position_end,
            string _error_name = "Синтаксическая ошибка: неверное натуральное число.",
            string _discription = " Синтаксическая ошибка при попытке создания натурального числа.") : base(
            _position_start, _position_end, _error_name, _discription)
        {
            // Inherited Constructor
        }
    }
}