//V2.0.5
using System;
namespace Ural.Ural_translator_compliler

{
    public class Token
    {
        
        // ----------------------------------------------------------------
        // Tokens
        // ----------------------------------------------------------------
        public const string digit_const_str = "0123456789";
        public const string token_dt_void = "ВОИД";
        public const string token_op_commenting = "КОММЕНТАРИЙ";

        public const string token_dt_nat16 = "натч16";
        public const string token_dt_nat32 = "натч32";
        public const string token_dt_nat64 = "натч64";

        public const string token_dt_int16 = "целч16";
        public const string token_dt_int32 = "целч32";
        public const string token_dt_int64 = "целч64";

        public const string token_dt_real16 = "дробч16";
        public const string token_dt_real32 = "дробч32";
        public const string token_dt_real64 = "дробч64";

        public const string token_dt_binnum64 = "бинч";
        public const string token_dt_octnum64 = "восч";
        public const string token_dt_hexnum64 = "шесч";

        public const string token_dt_bool_true = "ИСТИНА";
        public const string token_dt_bool_false = "ЛОЖЬ";

        public const string token_dt_str0 = "чар";
        public const string token_dt_str10 = "cтр10";
        public const string token_dt_str16 = "cтр16";
        public const string token_dt_str32 = "cтр32";

        public const string token_op_math_plus = "ПЛЮС"; // +
        public const string token_op_math_minus = "МИНУС"; // -
        public const string token_op_math_multiply = "УМНОЖЬ"; // *
        public const string token_op_math_power = "СТЕПЕНЬ"; // ^
        public const string token_op_math_divide = "ДЕЛИТЬ"; // /

        public const string token_op_math_plus_by = "ПЛЮСНА"; // +=
        public const string token_op_math_minus_by = "МИНУСНА"; // -=
        public const string token_op_math_multiply_by = "УМНОЖЬНА"; // *=
        public const string token_op_math_power_by = "СТЕПЕНЬНА"; // ^=
        public const string token_op_math_divide_by = "ДЕЛИТЬНА"; // /=

        public const string token_op_math_plus_one = "ПЛЮСОДИН"; // ++
        public const string token_op_math_minus_one = "МИНУСОДИН"; // --
        public const string token_op_math_multiply_concat_list = "УМНОЖСПИСОК"; // **
        public const string token_op_math_divide_whole = "ДЕЛИТЬЦЕЛЧ"; // //

        public const string token_op_system_bracket_leftcircular = "ЛЕВАЯКРУГЛАЯСКОБКА"; // (
        public const string token_op_system_bracket_rightcircular = "ПРАВАЯКРУГЛАЯСКОБКА"; // )
        public const string token_op_system_bracket_leftsquare = "ЛЕВАЯКВАДРАТНАЯСКОБКА"; // [
        public const string token_op_system_bracket_rightsquare = "ПРАВАЯКВАДРАТНАЯСКОБКА"; // ]
        public const string token_op_system_bracket_leftline = "ЛЕВАЯПРЯМАЯСКОБКА"; // |
        public const string token_op_system_bracket_rightline = "ПРАВАЯПРЯМАЯСКОБКА"; // |
        public const string token_op_system_bracket_leftcurly = "ЛЕВАЯФИГУРНАЯСКОБКА"; // {
        public const string token_op_system_bracket_rightcurly = "ПРАВАЯФИГУРНАЯСКОБКА"; // }
        public const string token_op_system_bracket_lefttriangle = "ЛЕВАЯТРЕУГОЛЬНАЯСКОБКА"; // <
        public const string token_op_system_bracket_righttriangle = "ПРАВАЯТРЕУГОЛЬНАЯСКОБКА"; // >

        public const string token_op_vardeclaration_datatype = "ДВОЕТОЧИЕПЕРЕМЕННАЯ"; // :

        public string type;
        public string value;

        public Token(string _type, string _value)
        {
            this.type = _type;
            this.value = _value;
        }

        public Token(string type) : this(type, null) { }

        public override string ToString()
        {
            if (this.value is null)
            {
                return ($"{this.type} : {this.value}");
            }
            else
            {
                return ($"{this.type}");
            }
        }
    } 
    
}
