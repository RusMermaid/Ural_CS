namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOverloadDatatype;

public class SyntaxInvalidOverloadMassivError : Error
{
    public SyntaxInvalidOverloadMassivError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: ошибка при работе с типами данных.",
        string _discription = "Синтаксическая ошибка при некорректной работе с массивом как типами данных.") : base(
        _position_start, _position_end, _error_name, _discription)
    {
    }
}