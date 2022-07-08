using System;
namespace Ural.Ural_translator_compliler.Errors

{
    public class SyntaxInvalidRCIDatatypeError : Error
    {
        public SyntaxInvalidRCIDatatypeError(int _position_start, int _position_end, string _error_name = "Синтаксическая ошибка: неверный 'РЦЫ'.", string _discription = "Синтаксическая ошибка при некорректном использовании типа данных 'РЦЫ'.") : base(_position_start, _position_end, _error_name, _discription)
        {
            // Inherited Constructor
        }

    }
}