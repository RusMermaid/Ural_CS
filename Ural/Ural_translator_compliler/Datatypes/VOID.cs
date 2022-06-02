using System;
namespace Ural.Ural_translator_compliler.Datatypes
{
    public class VOID 
    {

        public object value;

        public VOID(object _value)
        {
            this.value = _value;
        }

        public VOID() : this("ВОИД") { }

        
        public override string ToString()
        {
            this.value = "ВОИД";
            return ("ВОИД");
        }

        
    }
}
