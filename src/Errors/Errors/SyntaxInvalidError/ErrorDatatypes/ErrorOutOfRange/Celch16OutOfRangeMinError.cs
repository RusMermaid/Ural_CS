namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class Celch16OutOfRangeMinError : SyntaxInvalidCelchDatatypeError
{
    public Celch16OutOfRangeMinError(int _position_start, int _position_end,
        string _error_name = "Целое число не в диапазоне: ",
        string _discription = "число не должно быть меньше чем -32767.") : base(_position_start, _position_end,
        _error_name, _discription)
    {
    }
}