//V2.0.5

namespace Errors.SyntaxInvalidError.ErrorDatatypes;

public class SyntaxInvalidCharacterError : Error
{
    public SyntaxInvalidCharacterError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: неизвестный символ.",
        string _discription = " Интерпритатор столкнулся с неизвестным символом или оператором.") : base(
        _position_start, _position_end, _error_name, _discription)
    {
        // Inherited Constructor
    }
}