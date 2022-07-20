
from ural_interpreter.lexer import Lexer
from ural_interpreter.parser import Parser

def run(file_name, text_code):
    lexer = Lexer(file_name, text_code)
    tokens, error = lexer.create_tokens()
    if error:
        return None, error 
    parser = Parser(tokens)
    ast = parser.parse()
    
    return ast, None