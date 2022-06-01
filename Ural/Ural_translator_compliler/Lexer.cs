//V2.0.5
using System;
namespace Ural.Ural_translator_compliler

{
    public class Lexer
    {
        public string file_name;
        public string ural_program_code;
        public char current_char; 

        public Lexer(string _file_name, string _text)
        {
            this.file_name = _file_name;
            this.ural_program_code = _text;
            this.current_char = ural_program_code[0];
        }
    }
}
