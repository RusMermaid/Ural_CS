namespace Errors.SyntaxInvalidError.ErrorDatatypes;

public class ZeroDivisionError : Error
{
    public ZeroDivisionError(int _position_start, int _position_end,
        string _error_name = "Логическая ошибка: ошибка при делении на ноль. ",
        string _discription = "На ноль делить нельзя.") : base(_position_start, _position_end, _error_name,
        _discription)
    {
    }
}