namespace Errors.SyntaxInvalidError.ErrorDatatypes;

public class SyntaxInvalidStringDatatypeError : Error
{
    public SyntaxInvalidStringDatatypeError(int _position_start, int _position_end,
        string _error_name = "Синтаксическая ошибка: неверное создание строки.",
        string _discription = " Синтаксическая ошибка при попытке создания строки.") : base(_position_start,
        _position_end, _error_name, _discription)
    {
        // Inherited Constructor
    }
}