using System;
namespace Ural.Ural_translator_compliler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange
{
    public class DrobchOutOfRange : SyntaxInvalidDrobchDatatypeError
    {
        public DrobchOutOfRange(int _position_start, int _position_end, string _error_name = "", string _discription = "") : base(_position_start, _position_end, _error_name, _discription)
        {
            // Inherited Constructor
        }
    }
}

