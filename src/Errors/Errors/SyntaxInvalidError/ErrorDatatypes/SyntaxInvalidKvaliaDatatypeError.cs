namespace Errors.SyntaxInvalidError.ErrorDatatypes;

public class SyntaxInvalidKvaliaDatatypeError : Error
{
    public SyntaxInvalidKvaliaDatatypeError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: неверное цветовое число.",
        string _discription = "Синтаксическая ошибка при некорректном создании (цветовых) чисел квалиа.") : base(
        _position_start, _position_end, _error_name, _discription)
    {
    }
}