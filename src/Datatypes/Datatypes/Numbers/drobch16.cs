using Errors.SyntaxInvalidError.ErrorDatatypes;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

namespace Datatypes.Numbers

{
    public class drobch16 : VOID, Interface_Drobch, Interface_UDrobch, Interface_UMathNumerics, Interface_UNumeric, Interface_Ural_Datatype
    {
        public const float DefaultValue = 0F;
        public const float MaxValue = 65535F;
        public const float MinValue = -32767F;

        public drobch16(float _value) : base(_value)
        {
            switch (_value)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                default :
                    this.value = Convert.ToSingle(_value);
                    break;
            }
        }

        public drobch16(int _value) : base(_value)
        {
            if (_value > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                this.value = drobch16.DefaultValue;
            }
            else if (_value < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                this.value = drobch16.DefaultValue;
            }
            else
            {
                this.value = Convert.ToSingle(_value);
            }
        }

        public drobch16(short _value) : base(_value)
        {
            if (_value > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                this.value = drobch16.DefaultValue;
            }
            else if (_value < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                this.value = drobch16.DefaultValue;
            }
            else
            {
                this.value = Convert.ToSingle(_value);
            }
        }

        public drobch16(long _value) : base(_value)
        {
            if (_value > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                this.value = drobch16.DefaultValue;
            }
            else if (_value < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                this.value = drobch16.DefaultValue;
            }
            else
            {
                this.value = Convert.ToSingle(_value);
            }
        }

        public drobch16(string _value) : base(_value)
        {
            bool check_isfloat16 = float.TryParse((string)_value, out float new_value);
            switch (check_isfloat16)
            {
                case true :
                    switch (new_value)
                    {
                        case > drobch16.MaxValue :
                        {
                            Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                            this.value = drobch16.DefaultValue;
                            break;
                        }
                        case < drobch16.MinValue :
                        {
                            Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                            this.value = drobch16.DefaultValue;
                            break;
                        }
                        default :
                            this.value = Convert.ToSingle(_value);
                            break;
                    }

                    break;
                default :
                {
                    SyntaxInvalidDrobchDatatypeError er = new SyntaxInvalidDrobchDatatypeError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
            }

            this.value = Convert.ToSingle(new_value);
        }

        public drobch16(bool _value) : base(_value)
        {
            float new_value = _value switch
            {
                true => 1.0F,
                _ => 0.0F
            };

            this.value = Convert.ToSingle(new_value);
        }

        public drobch16(double _value) : base(_value)
        {
            switch (_value)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                default :
                    this.value = Convert.ToSingle(_value);
                    break;
            }
        }

        public drobch16(drobch16 _value) : base(_value)
        {
            this.value = Convert.ToSingle(_value.value);
        }

        public drobch16(drobch32 _value) : base(_value)
        {
            switch ((float)_value.value)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                default :
                    this.value = Convert.ToSingle(_value.value);
                    break;
            }
        }

        public drobch16(drobch64 _value) : base(_value)
        {
            switch ((double)_value.value)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                default :
                    this.value = Convert.ToSingle(_value.value);
                    break;
            }
        }

        public drobch16(celch16 _value) : base(_value)
        {
            switch ((float)_value.value)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                default :
                    this.value = Convert.ToSingle(_value.value);
                    break;
            }
        }

        public drobch16(celch32 _value) : base(_value)
        {
            switch ((float)_value.value)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                default :
                    this.value = Convert.ToSingle(_value.value);
                    break;
            }
        }

        public drobch16(celch64 _value) : base(_value)
        {
            switch ((double)_value.value)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError er = new Drobch16OutOfRangeMinError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                default :
                    this.value = Convert.ToSingle(_value.value);
                    break;
            }
        }

        public drobch16(natch16 _value) : base(_value)
        {
            switch ((float)_value.value)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                default :
                    this.value = Convert.ToSingle(_value.value);
                    break;
            }
        }

        public drobch16(natch32 _value) : base(_value)
        {
            switch ((float)_value.value)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                default :
                    this.value = Convert.ToSingle(_value.value);
                    break;
            }
        }

        public drobch16(natch64 _value) : base(_value)
        {
            switch ((double)_value.value)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError er = new Drobch16OutOfRangeMaxError(0, 0);
                    this.value = drobch16.DefaultValue;
                    break;
                }
                default :
                    this.value = Convert.ToSingle(_value.value);
                    break;
            }
        }

        public drobch16() : this(0.0F)
        {
        }

        public static explicit operator drobch32(drobch16 num)
        {
            return new drobch32() { value = num.value, subvalue = num.subvalue };
        }

        public static explicit operator drobch64(drobch16 num)
        {
            return new drobch64() { value = num.value, subvalue = num.subvalue };
        }

        public static explicit operator celch16(drobch16 num)
        {
            return new celch16() { value = num.value, subvalue = num.subvalue };
        }

        public static explicit operator celch32(drobch16 num)
        {
            return new celch32() { value = num.value, subvalue = num.subvalue };
        }

        public static explicit operator celch64(drobch16 num)
        {
            return new celch64() { value = num.value, subvalue = num.subvalue };
        }

        public static explicit operator natch16(drobch16 num)
        {
            return new natch16() { value = num.value, subvalue = num.subvalue };
        }

        public static explicit operator natch32(drobch16 num)
        {
            return new natch32() { value = num.value, subvalue = num.subvalue };
        }

        public static explicit operator natch64(drobch16 num)
        {
            return new natch64() { value = num.value, subvalue = num.subvalue };
        }

        public static explicit operator string(drobch16 _value)
        {
            return _value.ToString();
        }

        public static explicit operator str10(drobch16 _value)
        {
            return new str10(_value.ToString());
        }

        public static explicit operator str16(drobch16 _value)
        {
            return new str16(_value.ToString());
        }

        public static explicit operator str32(drobch16 _value)
        {
            return new str32(_value.ToString());
        }

        public static explicit operator str64(drobch16 _value)
        {
            return new str64(_value.ToString());
        }

        public static explicit operator double(drobch16 num)
        {
            return (double)num.value;
        }

        public static explicit operator float(drobch16 num)
        {
            return (float)num.value;
        }

        public static explicit operator int(drobch16 num)
        {
            return (int)num.value;
        }

        public static explicit operator short(drobch16 num)
        {
            return (short)num.value;
        }

        public static explicit operator long(drobch16 num)
        {
            return (long)num.value;
        }

        public static RCI operator ==(drobch16 l, VOID r)
        {
            return new RCI(false);
        }

        public static RCI operator ==(drobch16 l, ushort r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, uint r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, ulong r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, short r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, int r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, long r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, float r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, double r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, natch16 r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, natch32 r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, natch64 r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, celch16 r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, celch32 r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, celch64 r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, drobch16 r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, drobch32 r)
        {
            return l.___Equals(r);
        }

        public static RCI operator ==(drobch16 l, drobch64 r)
        {
            return l.___Equals(r);
        }

        public static RCI operator !=(drobch16 l, ushort r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, uint r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, ulong r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, short r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, int r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, long r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, float r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, double r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, natch16 r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, natch32 r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, natch64 r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, celch16 r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, celch32 r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, celch64 r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, drobch16 r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, drobch32 r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, drobch64 r)
        {
            return l.___Equals(r).NE();
        }

        public static RCI operator !=(drobch16 l, VOID r)
        {
            return new RCI(true);
        }

        public static RCI operator >(drobch16 l, ushort r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, uint r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, ulong r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, short r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, int r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, long r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, float r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, double r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, natch16 r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, natch32 r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, natch64 r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, celch16 r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, celch32 r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, celch64 r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, drobch16 r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, drobch32 r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator >(drobch16 l, drobch64 r)
        {
            return l.___GreaterThan(r);
        }

        public static RCI operator <(drobch16 l, ushort r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, uint r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, ulong r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, short r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, int r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, long r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, float r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, double r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, natch16 r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, natch32 r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, natch64 r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, celch16 r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, celch32 r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, celch64 r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, drobch16 r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, drobch32 r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator <(drobch16 l, drobch64 r)
        {
            return l.___SmallerThan(r);
        }

        public static RCI operator >=(drobch16 l, ushort r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, uint r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, ulong r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, short r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, int r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, long r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, float r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, double r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, natch16 r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, natch32 r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, natch64 r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, celch16 r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, celch32 r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, celch64 r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, drobch16 r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, drobch32 r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator >=(drobch16 l, drobch64 r)
        {
            return l.___GreaterOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, ushort r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, uint r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, ulong r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, short r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, int r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, long r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, float r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, double r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, natch16 r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, natch32 r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, natch64 r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, celch16 r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, celch32 r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, celch64 r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, drobch16 r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, drobch32 r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static RCI operator <=(drobch16 l, drobch64 r)
        {
            return l.___SmallerOrEqualThan(r);
        }

        public static drobch16 operator +(drobch16 l, VOID r)
        {
            return new drobch16(l);
        }

        public static dynamic operator +(drobch16 l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, drobch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, drobch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, celch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, celch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, celch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, natch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, natch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, natch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, short r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, int r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, long r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, float r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(drobch16 l, double r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(short l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(int l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(long l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(float l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static dynamic operator +(double l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(r) is drobch16)
            {
                return new drobch16(l2.___Add(r));
            }
            else
            {
                return l2.___Add(r);
            }
        }

        public static drobch16 operator -(drobch16 l, VOID r)
        {
            return new drobch16(l);
        }

        public static dynamic operator -(drobch16 l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(drobch16 l, drobch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(drobch16 l, drobch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(drobch16 l, celch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(drobch16 l, celch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(drobch16 l, celch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(drobch16 l, natch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(drobch16 l, natch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(drobch16 l, natch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(drobch16 l, short r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-r) is drobch16)
            {
                return new drobch16(l2.___Add(-r));
            }
            else
            {
                return l2.___Add(-r);
            }
        }

        public static dynamic operator -(drobch16 l, int r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-r) is drobch16)
            {
                return new drobch16(l2.___Add(-r));
            }
            else
            {
                return l2.___Add(-r);
            }
        }

        public static dynamic operator -(drobch16 l, long r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-r) is drobch16)
            {
                return new drobch16(l2.___Add(-r));
            }
            else
            {
                return l2.___Add(-r);
            }
        }

        public static dynamic operator -(drobch16 l, float r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-r) is drobch16)
            {
                return new drobch16(-r);
            }
            else
            {
                return l2.___Add(-r);
            }
        }

        public static dynamic operator -(drobch16 l, double r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-r) is drobch16)
            {
                return new drobch16(-r);
            }
            else
            {
                return l2.___Add(-r);
            }
        }

        public static dynamic operator -(short l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(int l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(long l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(float l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch32(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static dynamic operator -(double l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Add(-(double)r.value) is drobch16)
            {
                return new drobch16(l2.___Add(-(double)r.value));
            }
            else
            {
                return l2.___Add(-(double)r.value);
            }
        }

        public static drobch16 operator *(drobch16 l, VOID r)
        {
            return new drobch16(l);
        }

        public static dynamic operator *(drobch16 l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, drobch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, drobch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, celch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, celch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, celch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, natch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, natch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, natch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, short r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, int r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, long r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, float r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(drobch16 l, double r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(short l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(int l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(long l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(float l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static dynamic operator *(double l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Multiply(r) is drobch16)
            {
                return new drobch16(l2.___Multiply(r));
            }
            else
            {
                return l2.___Multiply(r);
            }
        }

        public static drobch16 operator /(drobch16 l, VOID r)
        {
            return new drobch16(l);
        }

        public static dynamic operator /(drobch16 l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, drobch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, drobch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, celch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, celch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, celch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, natch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, natch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, natch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, short r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, int r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, long r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, float r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(drobch16 l, double r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(short l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch32(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(int l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(long l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(float l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static dynamic operator /(double l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Divide(r) is drobch16)
            {
                return new drobch16(l2.___Divide(r));
            }
            else
            {
                return l2.___Divide(r);
            }
        }

        public static drobch16 operator ^(drobch16 l, VOID r)
        {
            return new drobch16(l);
        }

        public static dynamic operator ^(drobch16 l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, drobch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, drobch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, celch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, celch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, celch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, natch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, natch32 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, natch64 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, short r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, int r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, long r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, float r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(drobch16 l, double r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(short l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(int l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(long l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(float l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public static dynamic operator ^(double l, drobch16 r)
        {
            drobch16 l2 = new drobch16(l);
            if (l2.___Power(r) is drobch16)
            {
                return new drobch16(l2.___Power(r));
            }
            else
            {
                return l2.___Power(r);
            }
        }

        public RCI ___Equals(ushort num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(uint num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(ulong num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(short num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(int num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(long num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(float num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(double num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(natch16 num)
        {
            return this.value == (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(natch32 num)
        {
            return this.value == (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(natch64 num)
        {
            return this.value == (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(celch16 num)
        {
            return this.value == (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(celch32 num)
        {
            return this.value == (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(celch64 num)
        {
            return this.value == (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(drobch16 num)
        {
            return this.value == (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(drobch32 num)
        {
            return this.value == (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___Equals(drobch64 num)
        {
            return this.value == (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(ushort num)
        {
            return this.value > (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(uint num)
        {
            return this.value > (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(ulong num)
        {
            return this.value > (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(short num)
        {
            return this.value > (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(int num)
        {
            return this.value > (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(long num)
        {
            return this.value > (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(float num)
        {
            return this.value > (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(double num)
        {
            return this.value > (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(natch16 num)
        {
            return this.value > (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(natch32 num)
        {
            return this.value > (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(natch64 num)
        {
            return this.value > (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(celch16 num)
        {
            return this.value > (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(celch32 num)
        {
            return this.value > (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(celch64 num)
        {
            return this.value > (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(drobch16 num)
        {
            return this.value > (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(drobch32 num)
        {
            return this.value > (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterThan(drobch64 num)
        {
            return this.value > (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(ushort num)
        {
            return this.value < (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(uint num)
        {
            return this.value < (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(ulong num)
        {
            return this.value < (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(short num)
        {
            return this.value < (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(int num)
        {
            return this.value < (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(long num)
        {
            return this.value < (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(float num)
        {
            return this.value < (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(double num)
        {
            return this.value < (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(natch16 num)
        {
            return this.value < (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(natch32 num)
        {
            return this.value < (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(natch64 num)
        {
            return this.value < (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(celch16 num)
        {
            return this.value < (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(celch32 num)
        {
            return this.value < (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(celch64 num)
        {
            return this.value < (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(drobch16 num)
        {
            return this.value < (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(drobch32 num)
        {
            return this.value < (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerThan(drobch64 num)
        {
            return this.value < (double)num.value ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterOrEqualThan(ushort num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterOrEqualThan(uint num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterOrEqualThan(ulong num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterOrEqualThan(short num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterOrEqualThan(int num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterOrEqualThan(long num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterOrEqualThan(float num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterOrEqualThan(double num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___GreaterOrEqualThan(natch16 num)
        {
            return RCI.ILI(this.___Equals(num), this.___GreaterThan((num)));
        }

        public RCI ___GreaterOrEqualThan(natch32 num)
        {
            return RCI.ILI(this.___Equals(num), this.___GreaterThan((num)));
        }

        public RCI ___GreaterOrEqualThan(natch64 num)
        {
            return RCI.ILI(this.___Equals(num), this.___GreaterThan((num)));
        }

        public RCI ___GreaterOrEqualThan(celch16 num)
        {
            return RCI.ILI(this.___Equals(num), this.___GreaterThan((num)));
        }

        public RCI ___GreaterOrEqualThan(celch32 num)
        {
            return RCI.ILI(this.___Equals(num), this.___GreaterThan((num)));
        }

        public RCI ___GreaterOrEqualThan(celch64 num)
        {
            return RCI.ILI(this.___Equals(num), this.___GreaterThan((num)));
        }

        public RCI ___GreaterOrEqualThan(drobch16 num)
        {
            return RCI.ILI(this.___Equals(num), this.___GreaterThan((num)));
        }

        public RCI ___GreaterOrEqualThan(drobch32 num)
        {
            return RCI.ILI(this.___Equals(num), this.___GreaterThan((num)));
        }

        public RCI ___GreaterOrEqualThan(drobch64 num)
        {
            return RCI.ILI(this.___Equals(num), this.___GreaterThan((num)));
        }

        public RCI ___SmallerOrEqualThan(ushort num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerOrEqualThan(uint num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerOrEqualThan(ulong num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerOrEqualThan(short num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerOrEqualThan(int num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerOrEqualThan(long num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerOrEqualThan(float num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerOrEqualThan(double num)
        {
            return this.value == (double)num ? new RCI(true) : new RCI(false);
        }

        public RCI ___SmallerOrEqualThan(natch16 num)
        {
            return RCI.ILI(this.___Equals(num), this.___SmallerThan((num)));
        }

        public RCI ___SmallerOrEqualThan(natch32 num)
        {
            return RCI.ILI(this.___Equals(num), this.___SmallerThan((num)));
        }

        public RCI ___SmallerOrEqualThan(natch64 num)
        {
            return RCI.ILI(this.___Equals(num), this.___SmallerThan((num)));
        }

        public RCI ___SmallerOrEqualThan(celch16 num)
        {
            return RCI.ILI(this.___Equals(num), this.___SmallerThan((num)));
        }

        public RCI ___SmallerOrEqualThan(celch32 num)
        {
            return RCI.ILI(this.___Equals(num), this.___SmallerThan((num)));
        }

        public RCI ___SmallerOrEqualThan(celch64 num)
        {
            return RCI.ILI(this.___Equals(num), this.___SmallerThan((num)));
        }

        public RCI ___SmallerOrEqualThan(drobch16 num)
        {
            return RCI.ILI(this.___Equals(num), this.___SmallerThan((num)));
        }

        public RCI ___SmallerOrEqualThan(drobch32 num)
        {
            return RCI.ILI(this.___Equals(num), this.___SmallerThan((num)));
        }

        public RCI ___SmallerOrEqualThan(drobch64 num)
        {
            return RCI.ILI(this.___Equals(num), this.___SmallerThan((num)));
        }

        public dynamic ___Add(drobch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            return ((num1 + num2 <= drobch16.MaxValue) & (num1 + num2 >= drobch16.MinValue)) switch
            {
                true => new drobch16(num1 + num2),
                _ => new drobch32(num1 + num2)
            };
        }

        public dynamic ___Add(drobch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            return ((num1 + num2 <= drobch16.MaxValue) & (num1 + num2 >= drobch16.MinValue)) switch
            {
                true => new drobch16(num1 + num2),
                _ => ((num1 + num2 <= celch32.MaxValue) & (num1 + num2 >= celch32.MinValue)) switch
                {
                    true => new drobch32(num1 + num2),
                    _ => new drobch64(num1 + num2)
                }
            };
        }

        public dynamic? ___Add(drobch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            switch ((num1 + num2 <= drobch16.MaxValue) & (num1 + num2 >= drobch16.MinValue))
            {
                case true :
                    return new drobch16(num1 + num2);
                default :
                {
                    switch ((num1 + num2 <= drobch32.MaxValue) & (num1 + num2 >= drobch32.MinValue))
                    {
                        case true :
                            return new drobch32(num1 + num2);
                        default :
                        {
                            switch ((num1 + num2 <= drobch64.MaxValue) & (num1 + num2 >= drobch64.MinValue))
                            {
                                case true :
                                    return new drobch64(num1 + num2);
                                default :
                                {
                                    switch (num1 + num2)
                                    {
                                        case > drobch64.MaxValue :
                                        {
                                            Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                                            err.Execute();
                                            return null;
                                        }
                                        default :
                                        {
                                            Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                                            err.Execute();
                                            return null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public dynamic ___Add(short num)
        {
            float num1 = Convert.ToSingle(num);
            float num2 = Convert.ToSingle(this.value);
            return ((num1 + num2 <= drobch16.MaxValue) & (num1 + num2 >= drobch16.MinValue)) switch
            {
                true => new drobch16(num1 + num2),
                _ => new drobch32(num1 + num2)
            };
        }

        public dynamic? ___Add(int num)
        {
            float num1 = Convert.ToSingle(num);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 + num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 + num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Add(long num)
        {
            float num1 = Convert.ToSingle(num);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 + num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 + num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Add(float num)
        {
            float num1 = Convert.ToSingle(num);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 + num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 + num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Add(double num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            switch (num1 + num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 + num2);
                    return num3;
                }
            }
        }

        public dynamic ___Add(celch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            return ((num1 + num2 <= drobch16.MaxValue) & (num1 + num2 >= drobch16.MinValue)) switch
            {
                true => new drobch16(num1 + num2),
                _ => new drobch32(num1 + num2)
            };
        }

        public dynamic? ___Add(celch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 + num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 + num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Add(celch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            switch (num1 + num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 + num2);
                    return num3;
                }
            }
        }

        public dynamic ___Add(natch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            return ((num1 + num2 <= drobch16.MaxValue) & (num1 + num2 >= drobch16.MinValue)) switch
            {
                true => new drobch16(num1 + num2),
                _ => new drobch32(num1 + num2)
            };
        }

        public dynamic? ___Add(natch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 + num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 + num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Add(natch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            switch (num1 + num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 + num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(drobch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(drobch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(drobch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(short num)
        {
            float num1 = Convert.ToSingle(num);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(int num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(long num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(float num)
        {
            float num1 = Convert.ToSingle(num);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(double num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(celch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(celch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(celch64 num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(natch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(natch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Multiply(natch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            switch (num1 * num2)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num1 * num2);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(drobch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(drobch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(drobch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(short num)
        {
            float num1 = Convert.ToSingle(num);
            float num2 = Convert.ToSingle(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(int num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(long num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(float num)
        {
            float num1 = Convert.ToSingle(num);
            float num2 = Convert.ToSingle(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(double num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(celch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(celch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(celch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(natch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(natch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Divide(natch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            switch (num2 / num1)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    drobch16 num3 = new drobch16(num2 / num1);
                    return num3;
                }
            }
        }

        public dynamic? ___Power(short num)
        {
            float num1 = Convert.ToSingle(num);
            float num2 = Convert.ToSingle(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(int num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(long num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(float num)
        {
            float num1 = Convert.ToSingle(num);
            float num2 = Convert.ToSingle(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(double num)
        {
            double num1 = Convert.ToDouble(num);
            double num2 = Convert.ToDouble(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(drobch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(drobch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(drobch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(celch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(celch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(celch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(natch16 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(natch32 num)
        {
            float num1 = Convert.ToSingle(num.value);
            float num2 = Convert.ToSingle(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? ___Power(natch64 num)
        {
            double num1 = Convert.ToDouble(num.value);
            double num2 = Convert.ToDouble(this.value);
            if (pow(num2, num1) > drobch16.MaxValue)
            {
                Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            else if (pow(num2, num1) < drobch16.MinValue)
            {
                Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            else
            {
                drobch16 num3 = new drobch16(pow(num2, num1));
                return num3;
            }
        }

        public dynamic? abs()
        {
            float num = Convert.ToSingle(this.value);
            switch (num)
            {
                case > drobch16.MaxValue :
                {
                    Drobch16OutOfRangeMaxError err = new Drobch16OutOfRangeMaxError(0, 0);
                    err.Execute();
                    return null;
                }
                case < drobch16.MinValue :
                {
                    Drobch16OutOfRangeMinError err = new Drobch16OutOfRangeMinError(0, 0);
                    err.Execute();
                    return null;
                }
                default :
                {
                    switch (((float)this.value > 0) | ((float)this.value == 0))
                    {
                        case true :
                        {
                            drobch16 new_num = new drobch16((float)this.value);
                            return new_num;
                        }
                        default :
                        {
                            drobch16 new_num = new drobch16((float)this.value * (-1));
                            return new_num;
                        }
                    }
                }
            }
        }
    }
}