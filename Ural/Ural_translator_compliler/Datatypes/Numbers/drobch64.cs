using System;
namespace Ural.Ural_translator_compliler.Datatypes.Numbers
{
    public class drobch64 : drobch32
    {
        public drobch64(double _value = 0.0D) : base(_value)
        {
            double new_value = Convert.ToDouble(_value);
            this.value = new_value;
        }

        
    }
}
