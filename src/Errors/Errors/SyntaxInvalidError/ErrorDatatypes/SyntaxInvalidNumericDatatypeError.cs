namespace Errors.SyntaxInvalidError.ErrorDatatypes;

public class SyntaxInvalidNumericDatatypeError : Error
{
    public SyntaxInvalidNumericDatatypeError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: неверный перевод данных в число. ",
        string _discription = "Синтаксическая ошибка при некорректном переводе чисел.") : base(_position_start,
        _position_end, _error_name, _discription)
    {
    }
}