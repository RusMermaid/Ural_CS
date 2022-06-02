class Error:
    def __init__(self, position_start, position_end, error_name, discription):
        self.position_start = position_start
        self.position_end = position_end
        self.error_name = error_name
        self.discription = discription

    def __repr__(self):
        error_message = f"{self.error_name} : '{self.discription}' \t"
        error_message += f"File: {self.position_start.file_name}, line {self.position_start.line_number + 1}"
        return error_message


class IllegalCharacterError(Error):
    def __init__(self, position_start, position_end, error_name, discription):
        super().__init__(position_start, position_end, "Illegal Character", discription)