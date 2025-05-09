namespace Errors.SyntaxInvalidError.ErrorDatatypes;

public class SyntaxInvalidVoschDatatypeError : Error
{
    public SyntaxInvalidVoschDatatypeError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: неверное восьмеричное число.",
        string _discription = "Синтаксическая ошибка при некорректном создании восьмеричных чисел.") : base(
        _position_start, _position_end, _error_name, _discription)
    {
    }
}