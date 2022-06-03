using System;
using Ural.Ural_translator_compliler.Datatypes;
namespace Ural.Ural_translator_compliler.Datatypes.Strings
{
    public class str32 : VOID
    {
        public str32(object _value = null) : base(_value)
        {
            string new_value;
            switch (Type.GetTypeCode(_value.GetType()))
            {

                case TypeCode.Boolean:
                    if ((bool)_value)
                    {
                        this.value = "??????";
                    }
                    else
                    {
                        this.value = "????";
                    }
                    break;

                default:
                    new_value = Convert.ToString(_value);
                    this.value = new_value;
                    break;
            }
        }
    }
}
