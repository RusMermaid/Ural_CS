
from ural_interpreter.errors import IllegalCharacterError
from ural_interpreter.tokens import *
from ural_interpreter.position import Position



class Lexer:
    def __init__(self, file_name, text):
        self.file_name = file_name
        self.program_code = text
        self.position = Position(-1, 0, -1, self.file_name, self.program_code)
        self.current_character = None
        self.advance_to_next_character()

    def advance_to_next_character(self):
        self.position.advance_to_next_character(self.current_character)
        self.current_character = self.program_code[self.position.index] if self.position.index < len(
            self.program_code) else None

    def create_tokens(self):
        tokens = []

        while self.current_character != None:
            if self.current_character in ["\t", " "]:
                self.advance_to_next_character()
            elif self.current_character in digit_const_str:
                tokens.append(self.make_number())
            elif self.current_character == "+":
                tokens.append(Token(token_plus))
                self.advance_to_next_character()
            elif self.current_character == "-":
                tokens.append(Token(token_minus))
                self.advance_to_next_character()
            elif self.current_character == "*":
                tokens.append(Token(token_multiply))
                self.advance_to_next_character()
            elif self.current_character == "/":
                tokens.append(Token(token_divide))
                self.advance_to_next_character()
            elif self.current_character == "^":
                self.advance_to_next_character()
            else:
                position_start = self.position.copy()
                character = self.current_character  # error
                self.advance_to_next_character()
                return [], IllegalCharacterError(position_start, self.position, "IllegalCharacterError", character)
        return tokens, None

    def make_number(self):
        number_str = ""
        dot_count = 0
        while self.current_character != None and self.current_character in digit_const_str + ".":
            if self.current_character == ".":
                if dot_count == 1:
                    break
                dot_count += 1
                number_str += "."
            else:
                number_str += self.current_character
            self.advance_to_next_character()

        if dot_count == 0:
            return Token(token_interger, int(number_str))
        elif dot_count == 1:
            return Token(token_real, float(number_str))