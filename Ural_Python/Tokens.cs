
namespace Ural
{
    using System;



    public class Tokens
    {
        
        // ----------------------------------------------------------------
        // Tokens
        // ----------------------------------------------------------------
        const string digit_const_str = "0123456789";
        const string token_void = "ВОИД";
        const string token_interger = "целч16";
        const string token_real = "дробч16";
        const string token_string = "cтр16";

        const string token_plus = "ПЛЮС";
        const string token_minus = "МИНУС";
        const string token_multiply = "УМНОЖ";
        const string token_power = "СТЕПЕНЬ";
        const string token_divide = "ДЕЛИТЬ";

        const string token_l__circular_bracket = "ЛЕВАЯКРУГЛАЯСКОБКА";
        const string token_r__circular_bracket = "ПРАВАЯКРУГЛАЯСКОБКА";

        public string type;
        public object value;

        public Tokens(string _type)
        {
            type = _type;
        }
        public Tokens(string _type, object _value)
        {
            type = _type;
            value = _value;
        }
    }
    
}
