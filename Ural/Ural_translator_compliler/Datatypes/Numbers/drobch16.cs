using System;
namespace Ural.Ural_translator_compliler.Datatypes.Numbers
{
    public class drobch16 : drobch32
    {
        public drobch16(float _value = 0.0F) : base(_value)
        {
            float new_value = Convert.ToSingle(_value);
            this.value = new_value;
        }
    }
}
