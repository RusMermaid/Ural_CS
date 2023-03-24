using System;
using Errors;

namespace Errors.SyntaxInvalidError.ErrorDatatypes

{
    public class SyntaxInvalidRCIDatatypeError : Error
    {
        public SyntaxInvalidRCIDatatypeError(int _position_start, int _position_end,
            string _error_name = "Синтаксическая ошибка: неверное 'РЦЫ'.",
            string _discription = " 'РЦЫ' принимает только два значения: 'ИСТИНА' и 'ЛОЖЬ'.") : base(_position_start,
            _position_end, _error_name, _discription)
        {
            // Inherited Constructor
        }
    }
}