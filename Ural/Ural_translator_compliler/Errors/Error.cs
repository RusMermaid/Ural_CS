//V2.0.5
using System;
namespace Ural.Ural_translator_compliler.Errors

{
    public class Error
    {
        public int position_start;
        public int position_end;
        public string error_name;
        public string discription;

        public Error(int _position_start, int _position_end, string _error_name, string _discription)
        { //Constructor
            this.position_start = _position_start;
            this.position_end = _position_end;
            this.error_name = _error_name;
            this.discription = _discription;
        }

        public override string ToString()
        {
            return $"{this.error_name}: {this.discription}";
        }
    }
}
