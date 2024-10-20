namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOverloadDatatype;

public class SyntaxInvalidOverloadCastMassivError : Error
{
    public SyntaxInvalidOverloadCastMassivError(int _position_start, int _position_end,
        string _error_name = "Логическая ошибка: ошибка при работе с типами данных внутри масива.",
        string _discription =
            "Логическая и синтаксическая ошибка при некорректной работе с типами данных внутри масива. Тип данных в массиве должен быть одинаковым с типом данных каждого элемента")
        : base(
            _position_start, _position_end, _error_name, _discription)
    {
    }
}