using System;
namespace Ural.Ural_translator_compliler.Datatypes.Numbers
{
    public class celch64 : celch32
    {
        public celch64(long _value = 0) : base(_value)
        {
            long new_value = Convert.ToInt64(_value);
            this.value = new_value;
        }
    }
}
