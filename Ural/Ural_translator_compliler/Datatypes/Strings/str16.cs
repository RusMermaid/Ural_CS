using System;
namespace Ural.Ural_translator_compliler.Datatypes.Strings
{
    public class str16 : str32
    {
        public str16(string _value = "") : base(_value)
        {
            string new_value = Convert.ToString(_value);
            this.value = new_value;

        }

        public str16(object _value = null) : base(_value)
        {
        }
    }
}

