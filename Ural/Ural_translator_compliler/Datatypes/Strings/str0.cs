using System;
using Ural.Ural_translator_compliler.Datatypes.Strings;
namespace Ural.Ural_translator_compliler.Datatypes.Strings;
{
    class str0 : str16
    {
        public str0(char? _value = "") : base(_value)) 
        {
            char new_value;
            switch (Type.GetTypeCode(_value.GetType()))
            {
                  case TypeCode.String:
                        if (_value = "") or (_value = null)
                        {
                            this.value = "A";
                        }
                        else
                        {
                            new_value = _value[0];
                            this.value = new_value;
                        }

                        break;
                
                    default:
                        new_value = Convert.ToChar(_value);
                        this.value = new_value;
                        break;
            }
        }
           
    }
}


