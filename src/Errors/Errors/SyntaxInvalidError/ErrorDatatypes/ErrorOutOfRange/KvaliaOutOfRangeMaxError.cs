namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class KvaliaOutOfRangeMaxError : SyntaxInvalidKvaliaDatatypeError
{
    public KvaliaOutOfRangeMaxError(int _position_start, int _position_end,
        string _error_name = "Число квалиа (шестнадцатеричное число) не в диапазоне: ",
        string _discription = "оно не должно превышать 16777215.") : base(_position_start, _position_end,
        _error_name, _discription)
    {
    }
}