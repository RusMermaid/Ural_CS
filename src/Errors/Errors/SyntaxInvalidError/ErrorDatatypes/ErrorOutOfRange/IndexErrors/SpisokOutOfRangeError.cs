namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class SpisokOutOfRangeError : Error
{
    public SpisokOutOfRangeError(int _position_start, int _position_end,
        string _error_name = "Длина списка не в диапазоне: ",
        string _discription = "длина списка не может превышать 18446744073709551615") : base(_position_start,
        _position_end, _error_name, _discription)
    {
    }
}