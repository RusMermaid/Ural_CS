using System;
using Ural.Ural_translator_compliler.Datatypes.Strings;
namespace Ural.Ural_translator_compliler.Datatypes.Strings;
{
    class str10 : str16
    {
    public str10(string _value = "") : base(_value)) 
        {
            string new_value = Convert.ToString(_value);
            this.value = new_value;
           
        }
    }

}
