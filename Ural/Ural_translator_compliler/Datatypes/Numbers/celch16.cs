using System;
namespace Ural.Ural_translator_compliler.Datatypes.Numbers
{
    public class celch16 : celch32
    {
        public celch16(short _value = 0) : base(_value)
        {
            short new_value = Convert.ToInt16(_value);
            this.value = new_value;
        }
    }
}
