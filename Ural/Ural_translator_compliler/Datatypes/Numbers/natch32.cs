using System;
using Ural.Ural_translator_compliler.Datatypes;
namespace Ural.Ural_translator_compliler.Datatypes.Numbers
{
    public class natch32 : celch32
    {
        public natch32(uint _value = 0) : base(_value)
        {
            //switch (Type.GetTypeCode(_value.GetType()))
            uint new_val = Convert.ToUInt32(_value);
            this.value = new_val;
        }
    }
}
