namespace Ural_CS_Rider.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOverloadDatatype;

public class SyntaxInvalidOverloadStrNumericError : Error
{
    public SyntaxInvalidOverloadStrNumericError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: ошибка при работе с типами данных.",
        string _discription = "Синтаксическая ошибка при некорректной работе с строчными и числовыми типами данных.") : base(
        _position_start, _position_end, _error_name, _discription)
    {
        
    }
}