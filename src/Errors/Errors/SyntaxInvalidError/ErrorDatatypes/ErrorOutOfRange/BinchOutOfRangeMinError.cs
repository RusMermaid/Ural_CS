namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class BinchOutOfRangeMinError : SyntaxInvalidBinchDatatypeError
{
    public BinchOutOfRangeMinError(int _position_start, int _position_end,
        string _error_name = "Бинарное (двоичное) число не в диапазоне: ",
        string _discription = "число не должно быть меньше чем -9223372036854775807.") : base(_position_start,
        _position_end, _error_name, _discription)
    {
    }
}