namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class Celch64OutOfRangeMaxError : SyntaxInvalidCelchDatatypeError
{
    public Celch64OutOfRangeMaxError(int _position_start, int _position_end,
        string _error_name = "Целое число не в диапазоне: ",
        string _discription = "число не должно превышать 18446744073709551615.") : base(_position_start,
        _position_end, _error_name, _discription)
    {
    }
}