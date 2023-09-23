namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class KortezhOutOfRangeError : Error
{
    public KortezhOutOfRangeError(int _position_start, int _position_end,
        string _error_name = "Длина кортежа не в диапазоне: ",
        string _discription = "длина кортежа не может превышать 18446744073709551615") : base(_position_start,
        _position_end, _error_name, _discription)
    {
    }
}