namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class Celch32OutOfRangeMaxError : SyntaxInvalidCelchDatatypeError
{
    public Celch32OutOfRangeMaxError(int _position_start, int _position_end,
        string _error_name = "Целое число не в диапазоне: ",
        string _discription = "число не должно превышать 4294967295.") : base(_position_start, _position_end,
        _error_name, _discription)
    {
    }
}