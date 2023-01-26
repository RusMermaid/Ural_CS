namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class Str10OutOfRangeError : Error
{
    public Str10OutOfRangeError(int _position_start, int _position_end, string _error_name = "Длина строки не в диапазоне: ", string _discription = "длина стр10 не может превышать 1024") : base(_position_start, _position_end, _error_name, _discription)
    {
            
    }
}