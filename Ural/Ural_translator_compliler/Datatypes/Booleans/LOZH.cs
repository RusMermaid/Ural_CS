using System;
namespace Ural.Ural_translator_compliler.Datatypes.Booleans
{
    public class LOZH : RCI
    {

        public LOZH(string _value) : base(_value)
        {
            if (_value == "ИСТИНА") //TRUE
            {
                this.value = _value;
            }
            else
            {
                //raise error;
            }
        }

        public LOZH(bool _value) : base(_value)
        {
            if (_value)
            {
                this.value = "ИСТИНА"; //TRUE
            }
            else if (!_value)
            {
                this.value = "ЛОЖЬ"; //FALSE
            }
            else
            {
                //Raise error
            }
        }

    }
}
