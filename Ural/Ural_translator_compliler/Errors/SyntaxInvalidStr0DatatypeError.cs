using System;
namespace Ural.Ural_translator_compliler.Errors

{
    public class SyntaxInvalidStr0DatatypeError : Error
    {
        public SyntaxInvalidStr0DatatypeError(int _position_start, int _position_end, string _error_name = "Синтаксическая ошибка: неверный символ.", string _discription = "Синтаксическая ошибка при некорректном использовании типа данных 'символ'.") : base(_position_start, _position_end, _error_name, _discription)
        {
            // Inherited Constructor
        }


    }
}