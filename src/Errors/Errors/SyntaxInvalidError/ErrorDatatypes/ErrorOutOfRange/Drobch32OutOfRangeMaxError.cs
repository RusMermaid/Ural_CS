namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class Drobch32OutOfRangeMaxError : SyntaxInvalidDrobchDatatypeError
{
    public Drobch32OutOfRangeMaxError(int _position_start, int _position_end,
        string _error_name = "Дробное число не в диапазоне:",
        string _discription = "число не должно превышать 4294967295.0.") : base(_position_start, _position_end,
        _error_name, _discription)
    {
    }
}