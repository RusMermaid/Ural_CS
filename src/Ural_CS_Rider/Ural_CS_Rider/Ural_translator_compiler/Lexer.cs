//V2.0.5

namespace Ural_CS_Rider.Ural_translator_compiler;

public class Lexer
{
    public string file_name;
    public string ural_program_code;
    public char current_char;

    public Lexer(string _file_name, string _text)
    {
        this.file_name = _file_name;
        this.ural_program_code = _text;
        this.current_char = this.ural_program_code[0];
    }
}