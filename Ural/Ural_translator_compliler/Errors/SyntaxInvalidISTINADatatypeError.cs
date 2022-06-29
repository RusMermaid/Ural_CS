using System;
namespace Ural.Ural_translator_compliler.Errors

{
    public class SyntaxInvalidISTINADatatypeError : Error
    {
        public SyntaxInvalidISTINADatatypeError(int _position_start, int _position_end, string _error_name = "Синтаксическая ошибка: неверный тип данных 'ИСТИНА'.", string _discription = "Синтаксическая ошибка при некорректном использовании типа данных 'ИСТИНА'.") : base(_position_start, _position_end, _error_name, _discription)
        {
            // Inherited Constructor
        }


    }
}