namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOverloadDatatype;

public class SyntaxInvalidOverloadNumbericStrError : Error
{
    public SyntaxInvalidOverloadNumbericStrError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: ошибка при работе с типами данных.",
        string _discription = "Синтаксическая ошибка при некорректной работе с числовыми и строчными типами данных.") : base(
        _position_start, _position_end, _error_name, _discription)
    {
        
    }
}