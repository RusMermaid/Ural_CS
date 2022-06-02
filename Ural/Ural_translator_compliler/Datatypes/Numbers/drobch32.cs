using System;
using Ural.Ural_translator_compliler.Datatypes;
namespace Ural.Ural_translator_compliler.Datatypes.Numbers
{
    public class drobch32 : VOID
    {
        public drobch32(object _value = null) : base(_value)
        {
            float new_value;
            switch (Type.GetTypeCode(_value.GetType()))
            {
                case TypeCode.String:

                    bool check_isfloat32 = float.TryParse((string)_value, out new_value);
                    if (check_isfloat32)
                    {
                        this.value = new_value;
                    }
                    else
                    {
                        this.value = 0.0;
                    }
                    break;

                default:
                    new_value = Convert.ToSingle(_value);
                    this.value = new_value;
                    break;
            }
        }
    }
}
