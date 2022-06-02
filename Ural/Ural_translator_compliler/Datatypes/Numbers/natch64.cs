using System;
namespace Ural.Ural_translator_compliler.Datatypes.Numbers
{
    public class natch64 : natch32
    {
        public natch64(uint _value = 0) : base(_value)
        {
            ulong new_val = Convert.ToUInt32(_value);
            this.value = new_val;
        }
    }
}
