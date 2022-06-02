using System;
using Ural.Ural_translator_compliler.Datatypes;
namespace Ural.Ural_translator_compliler.Datatypes.Numbers
{
    public class celch32 : VOID
    {
        public celch32(object _value = null) : base(_value)
        {
            int new_value;
            switch (Type.GetTypeCode(_value.GetType()))
            {
                case TypeCode.String:
                    
                    bool check_isint32 = int.TryParse((string)_value, out new_value);
                    if (check_isint32)
                    {
                        this.value = new_value;
                    }
                    else
                    {
                        this.value = 0;
                    }
                    break;
                case TypeCode.Boolean:
                    if ((bool)_value)
                    {
                        this.value = 1;
                    }
                    else
                    {
                        this.value = 0;
                    }
                    break;
                
                default:
                    new_value = Convert.ToInt32(_value);
                    this.value = new_value;
                    break;
            }
        }
    }
}
