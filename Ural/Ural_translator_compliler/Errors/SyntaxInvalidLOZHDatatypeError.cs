using System;
namespace Ural.Ural_translator_compliler.Errors

{
    public class SyntaxInvalidLOZHDatatypeError : Error
    {
        public SyntaxInvalidLOZHDatatypeError(int _position_start, int _position_end, string _error_name = "—интаксическа€ ошибка: неверный тип данных 'Ћќ∆№'.", string _discription = "—интаксическа€ ошибка при некорректном использовании типа данных 'Ћќ∆№'.") : base(_position_start, _position_end, _error_name, _discription)
        {
            // Inherited Constructor
        }


    }
}