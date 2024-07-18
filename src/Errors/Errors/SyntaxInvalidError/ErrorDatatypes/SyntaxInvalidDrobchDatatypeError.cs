namespace Errors.SyntaxInvalidError.ErrorDatatypes;

public class SyntaxInvalidDrobchDatatypeError : Error
{
    public SyntaxInvalidDrobchDatatypeError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: неверное дробное число.",
        string _discription = "Синтаксическая ошибка при попытке создания дробного числа.") : base(_position_start,
        _position_end, _error_name, _discription)
    {
        // Inherited Constructor
    }
}