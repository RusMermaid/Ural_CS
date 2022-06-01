import re
import json

def updating_dict(key:str=None, value=None):
    try:
        f = open("regex_for_blocks.json", "r")
        data_dict = json.load(f)
    except Exception as error:
        return error
    else:
        if key is None and value is None:
            f.close()

        elif type(key) == str and value is not None:
            f.close()
            f = open("regex_for_blocks.json", "w")
            if key in data_dict:
                pass
            else:
                data_dict[key] = value
                json.dump(data_dict, f, indent=4)
        else:
            return TypeError
    finally:
        f.close()
        return data_dict



print(updating_dict())




