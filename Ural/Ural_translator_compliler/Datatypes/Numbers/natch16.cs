using System;
namespace Ural.Ural_translator_compliler.Datatypes.Numbers
{
    public class natch16 : natch32
    {
        public natch16(ushort _value = 0) : base(_value)
        {
            ushort new_val = Convert.ToUInt16(_value);
            this.value = new_val;
        }
    }
}
