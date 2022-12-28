namespace Ural_CS_Rider.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class Str16OutOfRangeError : Error
{
    public Str16OutOfRangeError(int _position_start, int _position_end, string _error_name = "Длина строки не в диапазоне: ", string _discription = "длина стр16 не может превышать 65535") : base(_position_start, _position_end, _error_name, _discription)
    {
            
    }
}