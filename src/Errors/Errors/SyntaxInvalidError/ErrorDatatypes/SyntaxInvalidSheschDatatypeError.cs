namespace Errors.SyntaxInvalidError.ErrorDatatypes;

public class SyntaxInvalidSheschDatatypeError : Error
{
    public SyntaxInvalidSheschDatatypeError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: неверное шестнадцатеричное число.",
        string _discription = "Синтаксическая ошибка при некорректном создании шестнадцатеричных чисел.") : base(
        _position_start, _position_end, _error_name, _discription)
    {
    }
}