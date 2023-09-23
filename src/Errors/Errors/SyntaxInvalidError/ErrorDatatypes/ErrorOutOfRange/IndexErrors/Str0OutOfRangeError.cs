namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class String0OutOfRangeMaxError : Error
{
    public String0OutOfRangeMaxError(int _position_start, int _position_end,
        string _error_name = "Длина символа не в диапазоне: ", string _discription = "стр0 не может превышать 1") :
        base(_position_start, _position_end, _error_name, _discription)
    {
    }
}