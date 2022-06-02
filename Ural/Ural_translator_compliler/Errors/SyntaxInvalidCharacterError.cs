//V2.0.5
using System;
namespace Ural.Ural_translator_compliler.Errors

{
    public class SyntaxInvalidCharacterError : Error
    {
        public SyntaxInvalidCharacterError(int _position_start, int _position_end, string _error_name = "Invalid Character Error", string _discription = "This error occures when you type a character operator that Ural doesn't understand") : base(_position_start, _position_end, _error_name, _discription)
        {
            // Inherited Constructor
        }
        

    }
}
