from ural_interpreter.tokens import *
from ural_interpreter.num_node import NumberNode
from ural_interpreter.bin_op import BinaryOperation

class Parser:
    def __init__(self, tokens):
        self.tokens = tokens
        self.current_token_index = -1
        self.advance_to_next_character()

    def advance_to_next_character(self):
        self.current_token_index += 1
        if self.current_token_index < len(self.tokens):
            self.current_token = self.tokens[self.current_token_index]
            return self.current_token

    def parse(self):
        result = self.expression()
        return result

    def factor(self):
        token = self.current_token
        if token.type in [token_interger, token_real]:
            self.advance_to_next_character()
            return NumberNode(token)

    def term(self):
        left_factor = self.factor()
        while self.current_token.type in [token_multiply, token_divide]:
            operator_token = self.current_token
            self.advance_to_next_character()
            right_factor = self.factor()
            left_factor = BinaryOperation(left_factor, operator_token, right_factor)
        return left_factor

    def expression(self):
        left_factor = self.term()
        while self.current_token.type in [token_plus, token_minus]:
            operator_token = self.current_token
            self.advance_to_next_character()
            right_factor = self.factor()
            left_factor = BinaryOperation(left_factor, operator_token, right_factor)
        return left_factor

# ----------------------------------------------------------------
# Position
# ----------------------------------------------------------------
