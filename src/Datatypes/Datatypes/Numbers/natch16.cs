#region

using Errors.SyntaxInvalidError.ErrorDatatypes;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

#endregion

namespace Datatypes.Numbers;

public class natch16 : VOID, IEnumerable, Interface_UNatch, Interface_Ural_Datatype
{
    public const double DefaultValue = 0F;
    public const double MaxValue = 65535F;
    public const double MinValue = 0;

    public natch16(int _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else if (_value < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = Convert.ToSingle(_value); }
    }

    public natch16(short _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else if (_value < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = Convert.ToSingle(_value); }
    }

    public natch16(long _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else if (_value < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = Convert.ToSingle(_value); }
    }

    public natch16(ushort _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value);
    }

    public natch16(uint _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = Convert.ToDouble(_value); }
    }

    public natch16(ulong _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = Convert.ToDouble(_value); }
    }

    public natch16(string _value) : base(_value)
    {
        float new_value;
        bool check_isfloat = float.TryParse(_value, out new_value);
        switch (check_isfloat)
        {
            case true when new_value > MaxValue :
            {
                Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
                this.value = DefaultValue;
                break;
            }
            case true when new_value < MinValue :
            {
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                this.value = DefaultValue;
                break;
            }
            case true :
                this.value = Convert.ToSingle(new_value);
                break;
            default :
            {
                SyntaxInvalidNatchDatatypeError er = new SyntaxInvalidNatchDatatypeError(0, 0);
                break;
            }
        }
    }

    public natch16(bool _value) : base(_value)
    {
        float new_value = _value switch
        {
            true => 1F,
            _ => 0F
        };

        this.value = Convert.ToSingle(new_value);
    }

    public natch16(float _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else if (_value < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = this.trunc(Convert.ToSingle(_value)); }
    }

    public natch16(double _value) : base(_value)
    {
        switch (_value)
        {
            case > MaxValue :
            {
                Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
                this.value = DefaultValue;
                break;
            }
            case < MinValue :
            {
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                this.value = DefaultValue;
                break;
            }
            default :
                this.value = this.trunc(Convert.ToSingle(_value));
                break;
        }
    }

    public natch16(drobch16 _value) : base((float)_value.value)
    {
        this.value = trunc(Convert.ToSingle(_value.value));
    }

    public natch16(drobch32 _value) : base((float)_value.value)
    {
        float num = Convert.ToSingle(_value.value);
        if (num > MaxValue)
        {
            Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else if (num < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = this.trunc(Convert.ToSingle(num)); }
    }

    public natch16(drobch64 _value) : base((double)_value.value)
    {
        double num = Convert.ToDouble(_value.value);
        switch (num)
        {
            case > MaxValue :
            {
                Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
                this.value = DefaultValue;
                break;
            }
            case < MinValue :
            {
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                this.value = DefaultValue;
                break;
            }
            default :
                this.value = this.trunc(Convert.ToSingle(num));
                break;
        }
    }

    public natch16(celch16 _value) : base((float)_value.value)
    {
        this.value = Convert.ToSingle(_value.value);
    }

    public natch16(celch32 _value) : base((float)_value.value)
    {
        float num = Convert.ToSingle(_value.value);
        if (num > MaxValue)
        {
            Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else if (num < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = Convert.ToSingle(num); }
    }

    public natch16(celch64 _value) : base((double)_value.value)
    {
        double num = Convert.ToDouble(_value.value);
        switch (num)
        {
            case > MaxValue :
            {
                Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
                this.value = DefaultValue;
                break;
            }
            case < MinValue :
            {
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                this.value = DefaultValue;
                break;
            }
            default :
                this.value = Convert.ToSingle(num);
                break;
        }
    }

    public natch16(natch16 _value) : base((float)_value.value)
    {
        this.value = Convert.ToSingle(_value.value);
    }

    public natch16(natch32 _value) : base((float)_value.value)
    {
        float num = Convert.ToSingle(_value.value);
        if (num > MaxValue)
        {
            Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else if (num < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = Convert.ToSingle(num); }
    }

    public natch16(natch64 _value) : base((double)_value.value)
    {
        double num = Convert.ToDouble(_value.value);
        switch (num)
        {
            case > MaxValue :
            {
                Natch16OutOfRangeMaxError er = new Natch16OutOfRangeMaxError(0, 0);
                this.value = DefaultValue;
                break;
            }
            case < MinValue :
            {
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                this.value = DefaultValue;
                break;
            }
            default :
                this.value = Convert.ToSingle(num);
                break;
        }
    }

    public natch16() : this(Convert.ToDouble(0D))
    {
    }


    public static explicit operator drobch16(natch16 num) => new drobch16 { value = num.value, subvalue = num.subvalue };

    public static explicit operator drobch32(natch16 num) => new drobch32 { value = num.value, subvalue = num.subvalue };

    public static explicit operator drobch64(natch16 num) => new drobch64 { value = num.value, subvalue = num.subvalue };

    public static explicit operator celch16(natch16 num) => new celch16 { value = num.value, subvalue = num.subvalue };

    public static explicit operator celch32(natch16 num) => new celch32 { value = num.value, subvalue = num.subvalue };

    public static explicit operator celch64(natch16 num) => new celch64 { value = num.value, subvalue = num.subvalue };

    public static explicit operator natch32(natch16 num) => new natch32 { value = num.value, subvalue = num.subvalue };

    public static explicit operator natch64(natch16 num) => new natch64 { value = num.value, subvalue = num.subvalue };

    public static explicit operator natch16(str0 chr) => new natch16((ulong)chr.value[0]);

    public static explicit operator string(natch16 _value) => _value.ToString();

    public static explicit operator str10(natch16 _value) => new str10(_value.ToString());

    public static explicit operator str16(natch16 _value) => new str16(_value.ToString());

    public static explicit operator str32(natch16 _value) => new str32(_value.ToString());

    public static explicit operator str64(natch16 _value) => new str64(_value.ToString());

    public static explicit operator double(natch16 num) => (double)num.value;

    public static explicit operator float(natch16 num) => (float)num.value;

    public static explicit operator int(natch16 num) => (int)num.value;

    public static explicit operator short(natch16 num) => (short)num.value;

    public static explicit operator long(natch16 num) => (long)num.value;

    public static explicit operator uint(natch16 num) => (uint)num.value;

    public static explicit operator ushort(natch16 num) => (ushort)num.value;

    public static explicit operator ulong(natch16 num) => (ulong)num.value;

    public static RCI operator ==(natch16 l, VOID r) => new RCI(false);

    public static RCI operator ==(natch16 l, ushort r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, uint r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, ulong r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, short r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, int r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, long r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, float r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, double r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, natch16 r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, natch32 r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, natch64 r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, celch16 r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, celch32 r) => l.___Equals(r);

    public static RCI operator ==(natch16 l, celch64 r) => l.___Equals(r);

    public static RCI operator !=(natch16 l, ushort r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, uint r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, ulong r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, short r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, int r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, long r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, float r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, double r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, natch16 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, natch32 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, natch64 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, celch16 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, celch32 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, celch64 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch16 l, VOID r) => new RCI(true);

    public static RCI operator >(natch16 l, ushort r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, uint r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, ulong r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, short r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, int r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, long r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, float r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, double r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, natch16 r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, natch32 r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, natch64 r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, celch16 r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, celch32 r) => l.___GreaterThan(r);

    public static RCI operator >(natch16 l, celch64 r) => l.___GreaterThan(r);

    public static RCI operator <(natch16 l, ushort r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, uint r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, ulong r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, short r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, int r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, long r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, float r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, double r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, natch16 r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, natch32 r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, natch64 r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, celch16 r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, celch32 r) => l.___SmallerThan(r);

    public static RCI operator <(natch16 l, celch64 r) => l.___SmallerThan(r);

    public static RCI operator >=(natch16 l, ushort r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, uint r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, ulong r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, short r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, int r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, long r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, float r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, double r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, natch16 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, natch32 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, natch64 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, celch16 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, celch32 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch16 l, celch64 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator <=(natch16 l, ushort r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, uint r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, ulong r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, short r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, int r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, long r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, float r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, double r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, natch16 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, natch32 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, natch64 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, celch16 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, celch32 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch16 l, celch64 r) => l.___SmallerOrEqualThan(r);

    public static natch16 operator +(natch16 l, VOID r) => new natch16(l);

    public static dynamic operator +(natch16 l, celch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch16 l, celch32 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch16 l, celch64 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch16 l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch16 l, natch32 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch16 l, natch64 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch16 l, short r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch16 l, int r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch16 l, long r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(short l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(int l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(long l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(r) is natch16)
        {
            return new natch16(l2.___Add(r));
        }

        if (l2.___Add(r) is natch32)
        {
            return new natch32(l2.___Add(r));
        }

        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static natch16 operator -(natch16 l, VOID r) => new natch16(l);

    public static dynamic operator -(natch16 l, celch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r.value) is natch16)
        {
            return new natch16(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch32)
        {
            return new natch32(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch16 l, celch32 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r.value) is natch16)
        {
            return new natch16(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch32)
        {
            return new natch32(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch16 l, celch64 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r.value) is natch16)
        {
            return new natch16(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch32)
        {
            return new natch32(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch16 l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r.value) is natch16)
        {
            return new natch16(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch32)
        {
            return new natch32(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch16 l, natch32 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r.value) is natch16)
        {
            return new natch16(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch32)
        {
            return new natch32(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch16 l, natch64 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r.value) is natch16)
        {
            return new natch16(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch32)
        {
            return new natch32(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch16 l, short r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r) is natch16)
        {
            return new natch16(l2.___Add(-(double)r));
        }

        if (l2.___Add(-(double)r) is natch32)
        {
            return new natch32(l2.___Add(-(double)r));
        }

        if (l2.___Add(-(double)r) is natch64)
        {
            return new natch64(l2.___Add(-(double)r));
        }

        return l2.___Add(-(double)r);
    }

    public static dynamic operator -(natch16 l, int r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r) is natch16)
        {
            return new natch16(l2.___Add(-(double)r));
        }

        if (l2.___Add(-(double)r) is natch32)
        {
            return new natch32(l2.___Add(-(double)r));
        }

        if (l2.___Add(-(double)r) is natch64)
        {
            return new natch64(l2.___Add(-(double)r));
        }

        return l2.___Add(-(double)r);
    }

    public static dynamic operator -(natch16 l, long r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r) is natch16)
        {
            return new natch16(l2.___Add(-(double)r));
        }

        if (l2.___Add(-(double)r) is natch32)
        {
            return new natch32(l2.___Add(-(double)r));
        }

        if (l2.___Add(-(double)r) is natch64)
        {
            return new natch64(l2.___Add(-(double)r));
        }

        return l2.___Add(-(double)r);
    }

    public static dynamic operator -(short l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r.value) is natch16)
        {
            return new natch16(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch32)
        {
            return new natch32(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(int l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r.value) is natch16)
        {
            return new natch16(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch32)
        {
            return new natch32(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(long l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Add(-(double)r.value) is natch16)
        {
            return new natch16(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch32)
        {
            return new natch32(l2.___Add(-(double)r.value));
        }

        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static natch16 operator *(natch16 l, VOID r) => new natch16(l);

    public static dynamic operator *(natch16 l, celch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, celch32 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, celch64 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, natch32 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, natch64 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, short r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, int r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, long r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(short l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(int l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(long l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Multiply(r) is natch16)
        {
            return new natch16(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch32)
        {
            return new natch32(l2.___Multiply(r));
        }

        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, str10 r)
    {
        natch16 l2 = new natch16(l);
        return l2.___Multiply(r);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, str16 r)
    {
        natch16 l2 = new natch16(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, str32 r)
    {
        natch16 l2 = new natch16(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch16 l, str64 r)
    {
        natch16 l2 = new natch16(l);
        return l2.___Multiply(r);
    }

    public static natch16 operator |(natch16 l, VOID r) => new natch16(l);

    public static dynamic operator |(natch16 l, celch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch16 l, celch32 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch16 l, celch64 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch16 l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch16 l, natch32 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch16 l, natch64 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch16 l, short r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch16 l, int r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch16 l, long r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(short l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(int l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(long l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Div(r) is natch16)
        {
            return new natch16(l2.___Div(r));
        }

        if (l2.___Div(r) is natch32)
        {
            return new natch32(l2.___Div(r));
        }

        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static natch16 operator %(natch16 l, VOID r) => new natch16(l);

    public static dynamic operator %(natch16 l, celch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch16 l, celch32 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch16 l, celch64 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch16 l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch16 l, natch32 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch16 l, natch64 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch16 l, short r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch16 l, int r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch16 l, long r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(short l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(int l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(long l, natch16 r)
    {
        natch16 l2 = new natch16(l);
        if (l2.___Modulo(r) is natch16)
        {
            return new natch16(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public IEnumerator GetEnumerator()
    {
        for (short i = 0; i < (ushort)this; i++) yield return new natch16(i);
    }

    public RCI ___Equals(ushort num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___Equals(uint num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___Equals(ulong num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___Equals(short num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___Equals(int num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___Equals(long num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___Equals(float num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___Equals(double num) => this.value == num ? new RCI(true) : new RCI(false);

    public RCI ___Equals(natch16 num) => this.value == (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___Equals(natch32 num) => this.value == (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___Equals(natch64 num) => this.value == (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___Equals(celch16 num) => this.value == (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___Equals(celch32 num) => this.value == (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___Equals(celch64 num) => this.value == (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(ushort num) => this.value > (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(uint num) => this.value > (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(ulong num) => this.value > (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(short num) => this.value > (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(int num) => this.value > (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(long num) => this.value > (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(float num) => this.value > (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(double num) => this.value > num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(natch16 num) => this.value > (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(natch32 num) => this.value > (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(natch64 num) => this.value > (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(celch16 num) => this.value > (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(celch32 num) => this.value > (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(celch64 num) => this.value > (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(ushort num) => this.value < (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(uint num) => this.value < (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(ulong num) => this.value < (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(short num) => this.value < (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(int num) => this.value < (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(long num) => this.value < (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(float num) => this.value < (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(double num) => this.value < num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(natch16 num) => this.value < (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(natch32 num) => this.value < (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(natch64 num) => this.value < (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(celch16 num) => this.value < (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(celch32 num) => this.value < (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(celch64 num) => this.value < (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___GreaterOrEqualThan(ushort num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterOrEqualThan(uint num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterOrEqualThan(ulong num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterOrEqualThan(short num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterOrEqualThan(int num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterOrEqualThan(long num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterOrEqualThan(float num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterOrEqualThan(double num) => this.value == num ? new RCI(true) : new RCI(false);

    public RCI ___GreaterOrEqualThan(natch16 num) => RCI.ILI(this.___Equals(num), this.___GreaterThan(num));

    public RCI ___GreaterOrEqualThan(natch32 num) => RCI.ILI(this.___Equals(num), this.___GreaterThan(num));

    public RCI ___GreaterOrEqualThan(natch64 num) => RCI.ILI(this.___Equals(num), this.___GreaterThan(num));

    public RCI ___GreaterOrEqualThan(celch16 num) => RCI.ILI(this.___Equals(num), this.___GreaterThan(num));

    public RCI ___GreaterOrEqualThan(celch32 num) => RCI.ILI(this.___Equals(num), this.___GreaterThan(num));

    public RCI ___GreaterOrEqualThan(celch64 num) => RCI.ILI(this.___Equals(num), this.___GreaterThan(num));

    public RCI ___SmallerOrEqualThan(ushort num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerOrEqualThan(uint num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerOrEqualThan(ulong num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerOrEqualThan(short num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerOrEqualThan(int num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerOrEqualThan(long num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerOrEqualThan(float num) => this.value == (double)num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerOrEqualThan(double num) => this.value == num ? new RCI(true) : new RCI(false);

    public RCI ___SmallerOrEqualThan(natch16 num) => RCI.ILI(this.___Equals(num), this.___SmallerThan(num));

    public RCI ___SmallerOrEqualThan(natch32 num) => RCI.ILI(this.___Equals(num), this.___SmallerThan(num));

    public RCI ___SmallerOrEqualThan(natch64 num) => RCI.ILI(this.___Equals(num), this.___SmallerThan(num));

    public RCI ___SmallerOrEqualThan(celch16 num) => RCI.ILI(this.___Equals(num), this.___SmallerThan(num));

    public RCI ___SmallerOrEqualThan(celch32 num) => RCI.ILI(this.___Equals(num), this.___SmallerThan(num));

    public RCI ___SmallerOrEqualThan(celch64 num) => RCI.ILI(this.___Equals(num), this.___SmallerThan(num));

    public dynamic ___Add(celch16 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        return ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue)) switch
        {
            true => new natch16(num1 + num2),
            _ => new natch32(num1 + num2)
        };
    }

    public dynamic ___Add(celch32 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        return ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue)) switch
        {
            true => new natch16(num1 + num2),
            _ => ((num1 + num2 <= natch32.MaxValue) & (num1 + num2 >= natch32.MinValue)) switch
            {
                true => new natch32(num1 + num2),
                _ => new natch64(num1 + num2)
            }
        };
    }

    public dynamic? ___Add(celch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue))
        {
            case true :
                return new natch16(num1 + num2);
            default :
            {
                switch ((num1 + num2 <= natch32.MaxValue) & (num1 + num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 + num2);
                    default :
                    {
                        switch ((num1 + num2 <= natch64.MaxValue) & (num1 + num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 + num2);
                            default :
                            {
                                switch (num1 + num2)
                                {
                                    case > natch64.MaxValue :
                                    {
                                        Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                        err.Execute();
                                        return null;
                                    }
                                    default :
                                    {
                                        NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic ___Add(natch16 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        return ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue)) switch
        {
            true => new natch16(num1 + num2),
            _ => new natch32(num1 + num2)
        };
    }

    public dynamic ___Add(natch32 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        return ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue)) switch
        {
            true => new natch16(num1 + num2),
            _ => ((num1 + num2 <= natch32.MaxValue) & (num1 + num2 >= natch32.MinValue)) switch
            {
                true => new natch32(num1 + num2),
                _ => new natch64(num1 + num2)
            }
        };
    }

    public dynamic? ___Add(natch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue))
        {
            case true :
                return new natch16(num1 + num2);
            default :
            {
                switch ((num1 + num2 <= natch32.MaxValue) & (num1 + num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 + num2);
                    default :
                    {
                        switch ((num1 + num2 <= natch64.MaxValue) & (num1 + num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 + num2);
                            default :
                            {
                                switch (num1 + num2)
                                {
                                    case > natch64.MaxValue :
                                    {
                                        Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                        err.Execute();
                                        return null;
                                    }
                                    default :
                                    {
                                        NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num);
        return ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue)) switch
        {
            true => new natch16(num1 + num2),
            _ => new natch32(num1 + num2)
        };
    }

    public dynamic ___Add(int num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num);
        return ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue)) switch
        {
            true => new natch16(num1 + num2),
            _ => ((num1 + num2 <= natch32.MaxValue) & (num1 + num2 >= natch32.MinValue)) switch
            {
                true => new natch32(num1 + num2),
                _ => new natch64(num1 + num2)
            }
        };
    }

    public dynamic? ___Add(long num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        switch ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue))
        {
            case true :
                return new natch16(num1 + num2);
            default :
            {
                switch ((num1 + num2 <= natch32.MaxValue) & (num1 + num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 + num2);
                    default :
                    {
                        switch ((num1 + num2 <= natch64.MaxValue) & (num1 + num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 + num2);
                            default :
                            {
                                switch (num1 + num2)
                                {
                                    case > natch64.MaxValue :
                                    {
                                        Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                        err.Execute();
                                        return null;
                                    }
                                    default :
                                    {
                                        NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Add(float num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        switch ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue))
        {
            case true :
                return new natch16(num1 + num2);
            default :
            {
                switch ((num1 + num2 <= natch32.MaxValue) & (num1 + num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 + num2);
                    default :
                    {
                        switch ((num1 + num2 <= natch64.MaxValue) & (num1 + num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 + num2);
                            default :
                            {
                                switch (num1 + num2)
                                {
                                    case > natch64.MaxValue :
                                    {
                                        Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                        err.Execute();
                                        return null;
                                    }
                                    default :
                                    {
                                        NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Add(double num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        switch ((num1 + num2 <= MaxValue) & (num1 + num2 >= MinValue))
        {
            case true :
                return new natch16(num1 + num2);
            default :
            {
                switch ((num1 + num2 <= natch32.MaxValue) & (num1 + num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 + num2);
                    default :
                    {
                        switch ((num1 + num2 <= natch64.MaxValue) & (num1 + num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 + num2);
                            default :
                            {
                                switch (num1 + num2)
                                {
                                    case > natch64.MaxValue :
                                    {
                                        Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                        err.Execute();
                                        return null;
                                    }
                                    default :
                                    {
                                        NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Add(str0 _value)
    {
        string str = (string)this.value + (string)_value;
        switch (str.Length)
        {
            case < str10.MaxLength :
                return new str10(str);
            default :
            {
                switch ((str.Length >= str10.MaxLength) & (str.Length < str16.MaxLength))
                {
                    case true :
                        return new str16(str);
                    default :
                    {
                        switch ((str.Length >= str16.MaxLength) & (str.Length < str32.MaxLength))
                        {
                            case true :
                                return new str32(str);
                            default :
                            {
                                switch ((str.Length >= str32.MaxLength) & ((ulong)str.Length < str64.MaxLength))
                                {
                                    case true :
                                        return new str64(str);
                                    default :
                                    {
                                        Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
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

    public dynamic? ___Add(str10 _value)
    {
        string str = (string)this.value + (string)_value;
        switch (str.Length)
        {
            case < str10.MaxLength :
                return new str10(str);
            default :
            {
                switch ((str.Length >= str10.MaxLength) & (str.Length < str16.MaxLength))
                {
                    case true :
                        return new str16(str);
                    default :
                    {
                        switch ((str.Length >= str16.MaxLength) & (str.Length < str32.MaxLength))
                        {
                            case true :
                                return new str32(str);
                            default :
                            {
                                switch ((str.Length >= str32.MaxLength) & ((ulong)str.Length < str64.MaxLength))
                                {
                                    case true :
                                        return new str64(str);
                                    default :
                                    {
                                        Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
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

    public dynamic? ___Add(str16 _value)
    {
        string str = (string)this.value + (string)_value;
        switch (str.Length)
        {
            case < str16.MaxLength :
                return new str16(str);
            default :
            {
                switch ((str.Length >= str16.MaxLength) & (str.Length < str32.MaxLength))
                {
                    case true :
                        return new str32(str);
                    default :
                    {
                        switch ((str.Length >= str32.MaxLength) & ((ulong)str.Length < str64.MaxLength))
                        {
                            case true :
                                return new str64(str);
                            default :
                            {
                                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                                err.Execute();
                                return null;
                            }
                        }
                    }
                }
            }
        }
    }

    public dynamic? ___Add(str32 _value)
    {
        string str = (string)this.value + (string)_value;
        if (str.Length < str32.MaxLength)
        {
            return new str32(str);
        }

        switch ((str.Length >= str32.MaxLength) & ((ulong)str.Length < str64.MaxLength))
        {
            case true :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic? ___Add(str64 _value)
    {
        string str = (string)this.value + (string)_value;
        switch ((ulong)str.Length)
        {
            case < str64.MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic? ___Multiply(celch16 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        switch ((num1 * num2 <= MaxValue) & (num1 * num2 >= MinValue))
        {
            case true :
                return new natch16(num1 * num2);
            default :
            {
                switch ((num1 * num2 <= natch32.MaxValue) & (num1 * num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 * num2);
                    default :
                    {
                        switch ((num1 * num2 <= natch64.MaxValue) & (num1 * num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 * num2);
                            default :
                            {
                                if (num1 * num2 > natch64.MaxValue)
                                {
                                    Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                    err.Execute();
                                    return null;
                                }
                                else
                                {
                                    NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Multiply(celch32 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        switch ((num1 * num2 <= MaxValue) & (num1 * num2 >= MinValue))
        {
            case true :
                return new natch16(num1 * num2);
            default :
            {
                switch ((num1 * num2 <= natch32.MaxValue) & (num1 * num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 * num2);
                    default :
                    {
                        switch ((num1 * num2 <= natch64.MaxValue) & (num1 * num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 * num2);
                            default :
                            {
                                if (num1 * num2 > natch64.MaxValue)
                                {
                                    Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                    err.Execute();
                                    return null;
                                }
                                else
                                {
                                    NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Multiply(celch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch ((num1 * num2 <= MaxValue) & (num1 * num2 >= MinValue))
        {
            case true :
                return new natch16(num1 * num2);
            default :
            {
                switch ((num1 * num2 <= natch32.MaxValue) & (num1 * num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 * num2);
                    default :
                    {
                        switch ((num1 * num2 <= natch64.MaxValue) & (num1 * num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 * num2);
                            default :
                            {
                                switch (num1 * num2)
                                {
                                    case > natch64.MaxValue :
                                    {
                                        Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                        err.Execute();
                                        return null;
                                    }
                                    default :
                                    {
                                        NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Multiply(natch16 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        switch ((num1 * num2 <= MaxValue) & (num1 * num2 >= MinValue))
        {
            case true :
                return new natch16(num1 * num2);
            default :
            {
                switch ((num1 * num2 <= natch32.MaxValue) & (num1 * num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 * num2);
                    default :
                    {
                        switch ((num1 * num2 <= natch64.MaxValue) & (num1 * num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 * num2);
                            default :
                            {
                                if (num1 * num2 > natch64.MaxValue)
                                {
                                    Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                    err.Execute();
                                    return null;
                                }
                                else
                                {
                                    NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Multiply(natch32 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        switch ((num1 * num2 <= MaxValue) & (num1 * num2 >= MinValue))
        {
            case true :
                return new natch16(num1 * num2);
            default :
            {
                switch ((num1 * num2 <= natch32.MaxValue) & (num1 * num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 * num2);
                    default :
                    {
                        switch ((num1 * num2 <= natch64.MaxValue) & (num1 * num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 * num2);
                            default :
                            {
                                if (num1 * num2 > natch64.MaxValue)
                                {
                                    Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                    err.Execute();
                                    return null;
                                }
                                else
                                {
                                    NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Multiply(natch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch ((num1 * num2 <= MaxValue) & (num1 * num2 >= MinValue))
        {
            case true :
                return new natch16(num1 * num2);
            default :
            {
                switch ((num1 * num2 <= natch32.MaxValue) & (num1 * num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 * num2);
                    default :
                    {
                        switch ((num1 * num2 <= natch64.MaxValue) & (num1 * num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 * num2);
                            default :
                            {
                                switch (num1 * num2)
                                {
                                    case > natch64.MaxValue :
                                    {
                                        Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                        err.Execute();
                                        return null;
                                    }
                                    default :
                                    {
                                        NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Multiply(short num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num);
        switch ((num1 * num2 <= MaxValue) & (num1 * num2 >= MinValue))
        {
            case true :
                return new natch16(num1 * num2);
            default :
            {
                switch ((num1 * num2 <= natch32.MaxValue) & (num1 * num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 * num2);
                    default :
                    {
                        switch ((num1 * num2 <= natch64.MaxValue) & (num1 * num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 * num2);
                            default :
                            {
                                if (num1 * num2 > natch64.MaxValue)
                                {
                                    Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                    err.Execute();
                                    return null;
                                }
                                else
                                {
                                    NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Multiply(int num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num);
        switch ((num1 * num2 <= MaxValue) & (num1 * num2 >= MinValue))
        {
            case true :
                return new natch16(num1 * num2);
            default :
            {
                switch ((num1 * num2 <= natch32.MaxValue) & (num1 * num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 * num2);
                    default :
                    {
                        switch ((num1 * num2 <= natch64.MaxValue) & (num1 * num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 * num2);
                            default :
                            {
                                if (num1 * num2 > natch64.MaxValue)
                                {
                                    Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                    err.Execute();
                                    return null;
                                }
                                else
                                {
                                    NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Multiply(long num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        switch ((num1 * num2 <= MaxValue) & (num1 * num2 >= MinValue))
        {
            case true :
                return new natch16(num1 * num2);
            default :
            {
                switch ((num1 * num2 <= natch32.MaxValue) & (num1 * num2 >= natch32.MinValue))
                {
                    case true :
                        return new natch32(num1 * num2);
                    default :
                    {
                        switch ((num1 * num2 <= natch64.MaxValue) & (num1 * num2 >= natch64.MinValue))
                        {
                            case true :
                                return new natch64(num1 * num2);
                            default :
                            {
                                switch (num1 * num2)
                                {
                                    case > natch64.MaxValue :
                                    {
                                        Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
                                        err.Execute();
                                        return null;
                                    }
                                    default :
                                    {
                                        NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
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

    public dynamic? ___Multiply(str10 _value)
    {
        string str = StrMultiply(Convert.ToString(_value.value), Convert.ToUInt64(this.value));
        switch (str.Length)
        {
            case < str10.MaxLength :
                return new str10(str);
            default :
            {
                switch ((str.Length >= str10.MaxLength) & (str.Length <= str16.MaxLength))
                {
                    case true :
                        return new str16(str);
                    default :
                    {
                        switch ((str.Length >= str16.MaxLength) & (str.Length < str32.MaxLength))
                        {
                            case true :
                                return new str32(str);
                            default :
                            {
                                switch ((str.Length >= str32.MaxLength) & ((ulong)str.Length < str64.MaxLength))
                                {
                                    case true :
                                        return new str64(str);
                                    default :
                                    {
                                        Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
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

    public dynamic? ___Multiply(str16 _value)
    {
        string str = StrMultiply(Convert.ToString(_value.value), Convert.ToUInt64(this.value));
        switch (str.Length)
        {
            case < str10.MaxLength :
                return new str10(str);
            default :
            {
                switch ((str.Length >= str10.MaxLength) & (str.Length <= str16.MaxLength))
                {
                    case true :
                        return new str16(str);
                    default :
                    {
                        switch ((str.Length >= str16.MaxLength) & (str.Length < str32.MaxLength))
                        {
                            case true :
                                return new str32(str);
                            default :
                            {
                                switch ((str.Length >= str32.MaxLength) & ((ulong)str.Length < str64.MaxLength))
                                {
                                    case true :
                                        return new str64(str);
                                    default :
                                    {
                                        Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
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

    public dynamic? ___Multiply(str32 _value)
    {
        string str = StrMultiply(Convert.ToString(_value.value), Convert.ToUInt64(this.value));
        switch (str.Length)
        {
            case < str10.MaxLength :
                return new str10(str);
            default :
            {
                switch ((str.Length >= str10.MaxLength) & (str.Length <= str16.MaxLength))
                {
                    case true :
                        return new str16(str);
                    default :
                    {
                        switch ((str.Length >= str16.MaxLength) & (str.Length < str32.MaxLength))
                        {
                            case true :
                                return new str32(str);
                            default :
                            {
                                switch ((str.Length >= str32.MaxLength) & ((ulong)str.Length < str64.MaxLength))
                                {
                                    case true :
                                        return new str64(str);
                                    default :
                                    {
                                        Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
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

    public dynamic? ___Multiply(str64 _value)
    {
        string str = StrMultiply(Convert.ToString(_value.value), Convert.ToUInt64(this.value));
        switch (str.Length)
        {
            case < str10.MaxLength :
                return new str10(str);
            default :
            {
                switch ((str.Length >= str10.MaxLength) & (str.Length <= str16.MaxLength))
                {
                    case true :
                        return new str16(str);
                    default :
                    {
                        switch ((str.Length >= str16.MaxLength) & (str.Length < str32.MaxLength))
                        {
                            case true :
                                return new str32(str);
                            default :
                            {
                                switch ((str.Length >= str32.MaxLength) & ((ulong)str.Length < str64.MaxLength))
                                {
                                    case true :
                                        return new str64(str);
                                    default :
                                    {
                                        Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
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

    public dynamic? ___Divide(celch16 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        switch ((num1 / num2 <= drobch16.MaxValue) & (num1 / num2 >= drobch16.MinValue))
        {
            case true :
                return new drobch16(num1 / num2);
            default :
            {
                switch ((num1 / num2 <= drobch32.MaxValue) & (num1 / num2 >= drobch32.MinValue))
                {
                    case true :
                        return new drobch32(num1 / num2);
                    default :
                    {
                        switch (((num1 / num2 > drobch32.MaxValue) | (num1 / num2 < drobch32.MinValue)) &
                                (num1 / num2 >= drobch64.MinValue) & (num1 / num2 <= drobch64.MaxValue))
                        {
                            case true :
                                return new drobch64(num1 / num2);
                            default :
                            {
                                if (num1 / num2 > drobch64.MaxValue)
                                {
                                    Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                                    err.Execute();
                                    return null;
                                }
                                else
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

    public dynamic? ___Divide(celch32 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        switch ((num1 / num2 <= drobch32.MaxValue) & (num1 / num2 >= drobch32.MinValue))
        {
            case true :
                return new drobch32(num1 / num2);
            default :
            {
                switch (((num1 / num2 > drobch32.MaxValue) | (num1 / num2 < drobch32.MinValue)) &
                        (num1 / num2 >= drobch64.MinValue) & (num1 / num2 <= drobch64.MaxValue))
                {
                    case true :
                        return new drobch64(num1 / num2);
                    default :
                    {
                        if (num1 / num2 > drobch64.MaxValue)
                        {
                            Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                            err.Execute();
                            return null;
                        }
                        else
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

    public dynamic? ___Divide(celch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch ((num1 / num2 >= drobch64.MinValue) & (num1 / num2 <= drobch64.MaxValue))
        {
            case true :
                return new drobch64(num1 / num2);
            default :
            {
                switch (num1 / num2)
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

    public dynamic? ___Divide(natch16 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        switch ((num1 / num2 <= drobch16.MaxValue) & (num1 / num2 >= drobch16.MinValue))
        {
            case true :
                return new drobch16(num1 / num2);
            default :
            {
                switch ((num1 / num2 <= drobch32.MaxValue) & (num1 / num2 >= drobch32.MinValue))
                {
                    case true :
                        return new drobch32(num1 / num2);
                    default :
                    {
                        switch (((num1 / num2 > drobch32.MaxValue) | (num1 / num2 < drobch32.MinValue)) &
                                (num1 / num2 >= drobch64.MinValue) & (num1 / num2 <= drobch64.MaxValue))
                        {
                            case true :
                                return new drobch64(num1 / num2);
                            default :
                            {
                                if (num1 / num2 > drobch64.MaxValue)
                                {
                                    Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                                    err.Execute();
                                    return null;
                                }
                                else
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

    public dynamic? ___Divide(natch32 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        switch ((num1 / num2 <= drobch32.MaxValue) & (num1 / num2 >= drobch32.MinValue))
        {
            case true :
                return new drobch32(num1 / num2);
            default :
            {
                switch (((num1 / num2 > drobch32.MaxValue) | (num1 / num2 < drobch32.MinValue)) &
                        (num1 / num2 >= drobch64.MinValue) & (num1 / num2 <= drobch64.MaxValue))
                {
                    case true :
                        return new drobch64(num1 / num2);
                    default :
                    {
                        if (num1 / num2 > drobch64.MaxValue)
                        {
                            Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                            err.Execute();
                            return null;
                        }
                        else
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

    public dynamic? ___Divide(natch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch ((num1 / num2 >= drobch64.MinValue) & (num1 / num2 <= drobch64.MaxValue))
        {
            case true :
                return new drobch64(num1 / num2);
            default :
            {
                switch (num1 / num2)
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

    public dynamic? ___Divide(short num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num);
        switch ((num1 / num2 <= drobch16.MaxValue) & (num1 / num2 >= drobch16.MinValue))
        {
            case true :
                return new drobch16(num1 / num2);
            default :
            {
                switch ((num1 / num2 <= drobch32.MaxValue) & (num1 / num2 >= drobch32.MinValue))
                {
                    case true :
                        return new drobch32(num1 / num2);
                    default :
                    {
                        switch (((num1 / num2 > drobch32.MaxValue) | (num1 / num2 < drobch32.MinValue)) &
                                (num1 / num2 >= drobch64.MinValue) & (num1 / num2 <= drobch64.MaxValue))
                        {
                            case true :
                                return new drobch64(num1 / num2);
                            default :
                            {
                                if (num1 / num2 > drobch64.MaxValue)
                                {
                                    Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                                    err.Execute();
                                    return null;
                                }
                                else
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

    public dynamic? ___Divide(int num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num);
        switch ((num1 / num2 <= drobch32.MaxValue) & (num1 / num2 >= drobch32.MinValue))
        {
            case true :
                return new drobch32(num1 / num2);
            default :
            {
                switch (((num1 / num2 > drobch32.MaxValue) | (num1 / num2 < drobch32.MinValue)) &
                        (num1 / num2 >= drobch64.MinValue) & (num1 / num2 <= drobch64.MaxValue))
                {
                    case true :
                        return new drobch64(num1 / num2);
                    default :
                    {
                        if (num1 / num2 > drobch64.MaxValue)
                        {
                            Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                            err.Execute();
                            return null;
                        }
                        else
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

    public dynamic? ___Divide(long num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        switch ((num1 / num2 >= drobch64.MinValue) & (num1 / num2 <= drobch64.MaxValue))
        {
            case true :
                return new drobch64(num1 / num2);
            default :
            {
                switch (num1 / num2)
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

    public dynamic? ___Div(short num)
    {
        float num1 = Convert.ToSingle(num);
        float num2 = Convert.ToSingle(this.value);
        if (num2 / num1 > MaxValue)
        {
            Natch16OutOfRangeMaxError err = new Natch16OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (num2 / num1 < MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        return new natch16(num2 / num1);
    }

    public dynamic? ___Div(int num)
    {
        float num1 = Convert.ToSingle(num);
        float num2 = Convert.ToSingle(this.value);
        if (num2 / num1 > MaxValue)
        {
            Natch16OutOfRangeMaxError err = new Natch16OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (num2 / num1 < MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        return new natch16(num2 / num1);
    }

    public dynamic? ___Div(long num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch16OutOfRangeMaxError err = new Natch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch16(num2 / num1);
        }
    }

    public dynamic? ___Div(celch16 num)
    {
        float num1 = Convert.ToSingle(num.value);
        float num2 = Convert.ToSingle(this.value);
        if (num2 / num1 > MaxValue)
        {
            Natch16OutOfRangeMaxError err = new Natch16OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (num2 / num1 < MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        return new natch16(num2 / num1);
    }

    public dynamic? ___Div(celch32 num)
    {
        float num1 = Convert.ToSingle(num.value);
        float num2 = Convert.ToSingle(this.value);
        if (num2 / num1 > MaxValue)
        {
            Natch16OutOfRangeMaxError err = new Natch16OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (num2 / num1 < MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        return new natch16(num2 / num1);
    }

    public dynamic? ___Div(celch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch16OutOfRangeMaxError err = new Natch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch16(num2 / num1);
        }
    }

    public dynamic? ___Div(natch16 num)
    {
        float num1 = Convert.ToSingle(num.value);
        float num2 = Convert.ToSingle(this.value);
        if (num2 / num1 > MaxValue)
        {
            Natch16OutOfRangeMaxError err = new Natch16OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (num2 / num1 < MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        return new natch16(num2 / num1);
    }

    public dynamic? ___Div(natch32 num)
    {
        float num1 = Convert.ToSingle(num.value);
        float num2 = Convert.ToSingle(this.value);
        if (num2 / num1 > MaxValue)
        {
            Natch16OutOfRangeMaxError err = new Natch16OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (num2 / num1 < MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        return new natch16(num2 / num1);
    }

    public dynamic? ___Div(natch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch16OutOfRangeMaxError err = new Natch16OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch16(num2 / num1);
        }
    }

    public dynamic? ___Power(short num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num);
        if ((this.pow(num1, num2) >= MinValue) & (this.pow(num1, num2) <= MaxValue))
        {
            return new natch16(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch32.MinValue) & (this.pow(num1, num2) <= natch32.MaxValue))
        {
            return new natch32(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch64.MinValue) & (this.pow(num1, num2) <= natch64.MaxValue))
        {
            return new natch64(this.pow(num1, num2));
        }

        if (this.pow(num1, num2) > natch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }
        else
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }
    }

    public dynamic? ___Power(int num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num);
        if ((this.pow(num1, num2) >= MinValue) & (this.pow(num1, num2) <= MaxValue))
        {
            return new natch16(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch32.MinValue) & (this.pow(num1, num2) <= natch32.MaxValue))
        {
            return new natch32(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch64.MinValue) & (this.pow(num1, num2) <= natch64.MaxValue))
        {
            return new natch64(this.pow(num1, num2));
        }

        if (this.pow(num1, num2) > natch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }
        else
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }
    }

    public dynamic? ___Power(long num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        if ((this.pow(num1, num2) >= MinValue) & (this.pow(num1, num2) <= MaxValue))
        {
            return new natch16(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch32.MinValue) & (this.pow(num1, num2) <= natch32.MaxValue))
        {
            return new natch32(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch64.MinValue) & (this.pow(num1, num2) <= natch64.MaxValue))
        {
            return new natch64(this.pow(num1, num2));
        }

        if (this.pow(num1, num2) > natch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }
        else
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }
    }

    public dynamic? ___Power(celch16 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        if ((this.pow(num1, num2) >= MinValue) & (this.pow(num1, num2) <= MaxValue))
        {
            return new natch16(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch32.MinValue) & (this.pow(num1, num2) <= natch32.MaxValue))
        {
            return new natch32(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch64.MinValue) & (this.pow(num1, num2) <= natch64.MaxValue))
        {
            return new natch64(this.pow(num1, num2));
        }

        if (this.pow(num1, num2) > natch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }
        else
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }
    }

    public dynamic? ___Power(celch32 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        if ((this.pow(num1, num2) >= MinValue) & (this.pow(num1, num2) <= MaxValue))
        {
            return new natch16(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch32.MinValue) & (this.pow(num1, num2) <= natch32.MaxValue))
        {
            return new natch32(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch64.MinValue) & (this.pow(num1, num2) <= natch64.MaxValue))
        {
            return new natch64(this.pow(num1, num2));
        }

        if (this.pow(num1, num2) > natch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }
        else
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }
    }

    public dynamic? ___Power(celch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        if ((this.pow(num1, num2) >= MinValue) & (this.pow(num1, num2) <= MaxValue))
        {
            return new natch16(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch32.MinValue) & (this.pow(num1, num2) <= natch32.MaxValue))
        {
            return new natch32(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch64.MinValue) & (this.pow(num1, num2) <= natch64.MaxValue))
        {
            return new natch64(this.pow(num1, num2));
        }

        if (this.pow(num1, num2) > natch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }
        else
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }
    }

    public dynamic? ___Power(natch16 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        if ((this.pow(num1, num2) >= MinValue) & (this.pow(num1, num2) <= MaxValue))
        {
            return new natch16(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch32.MinValue) & (this.pow(num1, num2) <= natch32.MaxValue))
        {
            return new natch32(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch64.MinValue) & (this.pow(num1, num2) <= natch64.MaxValue))
        {
            return new natch64(this.pow(num1, num2));
        }

        if (this.pow(num1, num2) > natch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }
        else
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }
    }

    public dynamic? ___Power(natch32 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        if ((this.pow(num1, num2) >= MinValue) & (this.pow(num1, num2) <= MaxValue))
        {
            return new natch16(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch32.MinValue) & (this.pow(num1, num2) <= natch32.MaxValue))
        {
            return new natch32(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch64.MinValue) & (this.pow(num1, num2) <= natch64.MaxValue))
        {
            return new natch64(this.pow(num1, num2));
        }

        if (this.pow(num1, num2) > natch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }
        else
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }
    }

    public dynamic? ___Power(natch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        if ((this.pow(num1, num2) >= MinValue) & (this.pow(num1, num2) <= MaxValue))
        {
            return new natch16(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch32.MinValue) & (this.pow(num1, num2) <= natch32.MaxValue))
        {
            return new natch32(this.pow(num1, num2));
        }

        if ((this.pow(num1, num2) >= natch64.MinValue) & (this.pow(num1, num2) <= natch64.MaxValue))
        {
            return new natch64(this.pow(num1, num2));
        }

        if (this.pow(num1, num2) > natch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }
        else
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }
    }

    public natch16 ___Modulo(celch16 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        return new natch16(num1 % num2);
    }

    public natch16 ___Modulo(celch32 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        return new natch16(num1 % num2);
    }

    public natch16 ___Modulo(celch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        return new natch16(num1 % num2);
    }

    public natch16 ___Modulo(natch16 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        return new natch16(num1 % num2);
    }

    public natch16 ___Modulo(natch32 num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num.value);
        return new natch16(num1 % num2);
    }

    public natch16 ___Modulo(natch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        return new natch16(num1 % num2);
    }

    public natch16 ___Modulo(short num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num);
        return new natch16(num1 % num2);
    }

    public natch16 ___Modulo(int num)
    {
        float num1 = Convert.ToSingle(this.value);
        float num2 = Convert.ToSingle(num);
        return new natch16(num1 % num2);
    }

    public natch16 ___Modulo(long num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        return new natch16(num1 % num2);
    }
}