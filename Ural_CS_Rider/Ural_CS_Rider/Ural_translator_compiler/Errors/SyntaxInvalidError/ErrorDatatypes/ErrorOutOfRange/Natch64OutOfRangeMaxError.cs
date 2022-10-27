using System;
namespace Ural.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange
{
    public class Natch64OutOfRangeMaxError : SyntaxInvalidNatchDatatypeError
    {
        public Natch64OutOfRangeMaxError(int _position_start, int _position_end, string _error_name = "Натуральное число не в диапазоне: ", string _discription = "число не должно превышать 18446744073709551615.") : base(_position_start, _position_end, _error_name, _discription)
        {

        }
    }
}

