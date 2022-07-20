from ural_interpreter import ural

while True:
    text = input("Saturn  -> \n")
    result_code, error = ural.run("<strdin>", text)
    if error:
        print(error.__repr__())
    else:
        print(result_code)