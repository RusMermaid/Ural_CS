class Position:
    def __init__(self, index, line_number, column_number, file_name, file_txt):
        self.index = index
        self.line_number = line_number
        self.column_number = column_number
        self.file_name = file_name
        self.file_txt = file_txt

    def advance_to_next_character(self, current_character):
        self.index += 1
        self.column_number += 1
        if current_character == "\n":
            self.index += 1
            self.column_number = 0
        return self

    def copy(self):
        return Position(self.index, self.line_number, self.column_number, self.file_name, self.file_txt)