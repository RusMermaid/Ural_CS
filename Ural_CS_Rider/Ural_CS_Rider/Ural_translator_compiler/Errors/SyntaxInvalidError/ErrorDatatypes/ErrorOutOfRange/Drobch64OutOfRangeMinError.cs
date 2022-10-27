using System;
namespace Ural.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange
{
    public class Drobch64OutOfRangeMinError : SyntaxInvalidDrobchDatatypeError
    {
        public Drobch64OutOfRangeMinError(int _position_start, int _position_end, string _error_name = "Дробное число не в диапазоне:", string _discription = "число не должно быть меньше чем -9223372036854775807.0 .") : base(_position_start, _position_end, _error_name, _discription)
        {

        }
    }
}

