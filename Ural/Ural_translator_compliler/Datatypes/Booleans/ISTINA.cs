﻿using System;
namespace Ural.Ural_translator_compliler.Datatypes.Booleans
{
    public class ISTINA : RCI
    {
        public ISTINA(string _value) : base( _value)
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
        public ISTINA(bool _value) : base(_value)
        {
            if (_value)
            {
                this.value = "ИСТИНА"; //TRUE
            }
            else if (! _value)
            {
                this.value = "ИСТИНА"; //FALSE
            }
            else
            {
                 //Raise error
            }
        }

        public ISTINA(RCI _value) : base(_value)
        {
            this.value = _value.value;
        }

        public ISTINA(ISTINA _value) : base(_value)
        {
            this.value = _value.value;
        }

        public ISTINA(LOZH _value) : base(_value)
        {
            this.value = _value.value;
        }
    }
}