using System;
using Ural.Ural_translator_compliler.Datatypes;
namespace Ural.Ural_translator_compliler.Datatypes.Strings;
{
    class str16 : VOID
    {
        public str16(object _value = "") : base(_value)) 
        {
            string new_value;
            switch (Type.GetTypeCode(_value.GetType()))
            {
                case TypeCode.Boolean:
                    if ((bool) _value)
                    {
                        this.value = "»—“»Õ¿";
                    }
                    else
                    {
                        this.value = "ÀŒ∆‹";
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