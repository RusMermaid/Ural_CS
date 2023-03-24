using System;
using Errors;

namespace Errors.SyntaxInvalidError.ErrorDatatypes
{
    public class StrIndexStartEndError : Error
    {
        public StrIndexStartEndError(int _position_start, int _position_end, string _error_name = "Ошибка Индекса:",
            string _discription = "начальный индекс больше конечного индекса") : base(_position_start, _position_end,
            _error_name, _discription)
        {
        }
    }
}