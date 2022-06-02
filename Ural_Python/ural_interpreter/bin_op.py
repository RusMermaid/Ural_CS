class BinaryOperation:


    def __init__(self, left_node, operator_token, right_node):
        self.left_node = left_node
        self.operator_token = operator_token
        self.right_node = right_node


    def __repr__(self):
        return f"{self.left_node}:{self.operator_token}:{self.right_node}"