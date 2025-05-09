namespace Errors.SyntaxInvalidError.ErrorDatatypes;

public class SyntaxInvalidBinchDatatypeError : Error
{
    public SyntaxInvalidBinchDatatypeError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: неверное бинарное число.",
        string _discription = "Синтаксическая ошибка при некорректном создании бинарных (двоичный) чисел.") : base(
        _position_start, _position_end, _error_name, _discription)
    {
    }
}