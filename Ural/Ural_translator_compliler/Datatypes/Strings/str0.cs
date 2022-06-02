using System;
using Ural.Ural_translator_compliler.Datatypes.Strings;
namespace Ural.Ural_translator_compliler.Datatypes.Strings
{
    public class str0 : str16
    {
        public str0(string _value = "") : base(_value)
        {
            if (_value == "" )
            {
                this.value = 'A';
            }
            else if (_value.Length == 1)
            {
                this.value = _value[0];
            }
            else
            {
                this.value = _value[0];
            }
            
        }

        public str0(char _value) : base(_value)
        {
            
                this.value = _value;
            

        }

    }
}


