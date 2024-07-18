namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class NatchOutOfRangeOtricError : SyntaxInvalidNatchDatatypeError
{
    public NatchOutOfRangeOtricError(int _position_start, int _position_end,
        string _error_name = "Натуральное число не в диапазоне: ",
        string _discription = "натуральное число не должно быть отрицательным.") : base(_position_start,
        _position_end, _error_name, _discription)
    {
    }
}