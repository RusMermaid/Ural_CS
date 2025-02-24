namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class FuncOutOfRangeError : SyntaxInvalidBinchDatatypeError
{
    public FuncOutOfRangeError(int _position_start, int _position_end,
        string _error_name = "Функция не определена диапазоне: ",
        string _discription = "Домен функции не принимает значение в этом диапазоне.") : base(_position_start,
        _position_end, _error_name, _discription)
    {
    }
}