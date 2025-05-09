#region

using Errors.SyntaxInvalidError.ErrorDatatypes;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

#endregion

namespace Datatypes.Numbers;

public interface Interface_UNatch
{
}

public class natch64 : VOID, IEnumerable, Interface_UNatch, Interface_UNumeric, Interface_Ural_Datatype
{
    public const double DefaultValue = 0D;
    public const double MaxValue = 18446744073709551615D;
    public const double MinValue = 0D;

    public natch64(long _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Natch64OutOfRangeMaxError er = new Natch64OutOfRangeMaxError(0, 0);
            this.value = celch64.DefaultValue;
        }
        else if (_value < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = celch64.DefaultValue;
        }
        else { this.value = Convert.ToDouble(_value); }
    }

    public natch64(short _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Natch64OutOfRangeMaxError er = new Natch64OutOfRangeMaxError(0, 0);
            this.value = celch64.DefaultValue;
        }
        else if (_value < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = celch64.DefaultValue;
        }
        else { this.value = Convert.ToDouble(_value); }
    }

    public natch64(int _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Natch64OutOfRangeMaxError er = new Natch64OutOfRangeMaxError(0, 0);
            this.value = celch64.DefaultValue;
        }
        else if (_value < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = celch64.DefaultValue;
        }
        else { this.value = Convert.ToDouble(_value); }
    }

    public natch64(ushort _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value);
    }

    public natch64(uint _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value);
    }

    public natch64(ulong _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value);
    }

    public natch64(string _value) : base(_value)
    {
        bool check_isdouble = double.TryParse(_value, out double new_value);
        switch (check_isdouble)
        {
            case true :
                switch (new_value)
                {
                    case > MaxValue :
                    {
                        Natch64OutOfRangeMaxError er = new Natch64OutOfRangeMaxError(0, 0);
                        this.value = celch64.DefaultValue;
                        break;
                    }
                    case < MinValue :
                    {
                        NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                        this.value = celch64.DefaultValue;
                        break;
                    }
                    default :
                        this.value = this.trunc(Convert.ToDouble(new_value));
                        break;
                }

                break;
            default :
            {
                SyntaxInvalidNatchDatatypeError er = new SyntaxInvalidNatchDatatypeError(0, 0);
                break;
            }
        }
    }

    public natch64(bool _value) : base(_value)
    {
        double new_value = _value switch
        {
            true => 1D,
            _ => 0D
        };

        this.value = new_value;
    }

    public natch64(float _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Natch64OutOfRangeMaxError er = new Natch64OutOfRangeMaxError(0, 0);
            this.value = celch64.DefaultValue;
        }
        else if (_value < MinValue)
        {
            NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
            this.value = celch64.DefaultValue;
        }
        else { this.value = this.trunc(Convert.ToDouble(_value)); }
    }


    public natch64(double _value) : base(_value)
    {
        switch (_value)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError er = new Natch64OutOfRangeMaxError(0, 0);
                this.value = celch64.DefaultValue;
                break;
            }
            case < MinValue :
            {
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                this.value = celch64.DefaultValue;
                break;
            }
            default :
                this.value = this.trunc(Convert.ToDouble(_value));
                break;
        }
    }

    public natch64(drobch16 _value) : base((double)_value.value)
    {
        switch ((double)_value.value)
        {
            case >= MinValue :
                this.value = trunc(Convert.ToDouble(_value.value));
                break;
            default :
            {
                this.value = DefaultValue;
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                break;
            }
        }
    }

    public natch64(drobch32 _value) : base((double)_value.value)
    {
        switch ((double)_value.value)
        {
            case >= MinValue :
                this.value = trunc(Convert.ToDouble(_value.value));
                break;
            default :
            {
                this.value = DefaultValue;
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                break;
            }
        }
    }

    public natch64(drobch64 _value) : base((double)_value.value)
    {
        switch ((double)_value.value)
        {
            case >= MinValue :
                this.value = trunc(Convert.ToDouble(_value.value));
                break;
            default :
            {
                this.value = DefaultValue;
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                break;
            }
        }
    }

    public natch64(celch16 _value) : base((double)_value.value)
    {
        switch ((double)_value.value)
        {
            case >= MinValue :
                this.value = Convert.ToDouble(_value.value);
                break;
            default :
            {
                this.value = DefaultValue;
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                break;
            }
        }
    }

    public natch64(celch32 _value) : base((double)_value.value)
    {
        switch ((double)_value.value)
        {
            case >= MinValue :
                this.value = Convert.ToDouble(_value.value);
                break;
            default :
            {
                this.value = DefaultValue;
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                break;
            }
        }
    }

    public natch64(celch64 _value) : base((double)_value.value)
    {
        switch ((double)_value.value)
        {
            case >= MinValue :
                this.value = Convert.ToDouble(_value.value);
                break;
            default :
            {
                this.value = DefaultValue;
                NatchOutOfRangeOtricError er = new NatchOutOfRangeOtricError(0, 0);
                break;
            }
        }
    }

    public natch64(natch16 _value) : base((double)_value.value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public natch64(natch32 _value) : base((double)_value.value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public natch64(natch64 _value) : base((double)_value.value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public natch64() : this(Convert.ToDouble(0D))
    {
    }

    // contructors are fully overloaded
    public static explicit operator drobch16(natch64 num) => new drobch16 { value = num.value, subvalue = num.subvalue };

    public static explicit operator drobch32(natch64 num) => new drobch32 { value = num.value, subvalue = num.subvalue };

    public static explicit operator drobch64(natch64 num) => new drobch64 { value = num.value, subvalue = num.subvalue };

    public static explicit operator celch16(natch64 num) => new celch16 { value = num.value, subvalue = num.subvalue };

    public static explicit operator celch32(natch64 num) => new celch32 { value = num.value, subvalue = num.subvalue };

    public static explicit operator celch64(natch64 num) => new celch64 { value = num.value, subvalue = num.subvalue };

    public static explicit operator natch16(natch64 num) => new natch16 { value = num.value, subvalue = num.subvalue };

    public static explicit operator natch32(natch64 num) => new natch32 { value = num.value, subvalue = num.subvalue };

    public static explicit operator natch64(str0 chr) => new natch64((ulong)chr.value[0]);

    public static explicit operator string(natch64 _value) => _value.ToString();

    public static explicit operator str10(natch64 _value) => new str10(_value.ToString());

    public static explicit operator str16(natch64 _value) => new str16(_value.ToString());

    public static explicit operator str32(natch64 _value) => new str32(_value.ToString());

    public static explicit operator str64(natch64 _value) => new str64(_value.ToString());

    public static explicit operator double(natch64 num) => (double)num.value;

    public static explicit operator float(natch64 num) => (float)num.value;

    public static explicit operator int(natch64 num) => (int)num.value;

    public static explicit operator short(natch64 num) => (short)num.value;

    public static explicit operator long(natch64 num) => (long)num.value;

    public static explicit operator uint(natch64 num) => (uint)num.value;

    public static explicit operator ushort(natch64 num) => (ushort)num.value;

    public static explicit operator ulong(natch64 num) => (ulong)num.value;

    public static RCI operator ==(natch64 l, VOID r) => new RCI(false);

    public static RCI operator ==(natch64 l, ushort r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, uint r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, ulong r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, short r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, int r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, long r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, float r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, double r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, natch16 r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, natch32 r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, natch64 r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, celch16 r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, celch32 r) => l.___Equals(r);

    public static RCI operator ==(natch64 l, celch64 r) => l.___Equals(r);

    public static RCI operator !=(natch64 l, ushort r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, uint r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, ulong r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, short r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, int r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, long r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, float r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, double r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, natch16 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, natch32 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, natch64 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, celch16 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, celch32 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, celch64 r) => l.___Equals(r).NE();

    public static RCI operator !=(natch64 l, VOID r) => new RCI(true);

    public static RCI operator >(natch64 l, ushort r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, uint r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, ulong r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, short r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, int r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, long r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, float r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, double r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, natch16 r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, natch32 r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, natch64 r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, celch16 r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, celch32 r) => l.___GreaterThan(r);

    public static RCI operator >(natch64 l, celch64 r) => l.___GreaterThan(r);

    public static RCI operator <(natch64 l, ushort r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, uint r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, ulong r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, short r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, int r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, long r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, float r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, double r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, natch16 r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, natch32 r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, natch64 r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, celch16 r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, celch32 r) => l.___SmallerThan(r);

    public static RCI operator <(natch64 l, celch64 r) => l.___SmallerThan(r);

    public static RCI operator >=(natch64 l, ushort r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, uint r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, ulong r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, short r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, int r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, long r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, float r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, double r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, natch16 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, natch32 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, natch64 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, celch16 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, celch32 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(natch64 l, celch64 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator <=(natch64 l, ushort r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, uint r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, ulong r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, short r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, int r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, long r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, float r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, double r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, natch16 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, natch32 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, natch64 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, celch16 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, celch32 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(natch64 l, celch64 r) => l.___SmallerOrEqualThan(r);

    public static natch64 operator +(natch64 l, VOID r) => new natch64(l);

    public static dynamic operator +(natch64 l, drobch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, drobch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, drobch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, celch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, celch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, celch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, natch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, natch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, natch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, short r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, int r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, long r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is natch64)
        {
            return new natch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, float r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(natch64 l, double r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static natch64 operator -(natch64 l, VOID r) => new natch64(l);

    public static dynamic operator -(natch64 l, drobch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-(double)r.value) is drobch64)
        {
            return new drobch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch64 l, drobch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-(double)r.value) is drobch64)
        {
            return new drobch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch64 l, drobch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-(double)r.value) is drobch64)
        {
            return new drobch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch64 l, celch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch64 l, celch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch64 l, celch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch64 l, natch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch64 l, natch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch64 l, natch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-(double)r.value) is natch64)
        {
            return new natch64(l2.___Add(-(double)r.value));
        }

        return l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(natch64 l, short r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-r) is natch64)
        {
            return new natch64(l2.___Add(-r));
        }

        return l2.___Add(-r);
    }

    public static dynamic operator -(natch64 l, int r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-r) is natch64)
        {
            return new natch64(l2.___Add(-r));
        }

        return l2.___Add(-r);
    }

    public static dynamic operator -(natch64 l, long r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-r) is natch64)
        {
            return new natch64(l2.___Add(-r));
        }

        return l2.___Add(-r);
    }

    public static dynamic operator -(natch64 l, float r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-r) is drobch64)
        {
            return new drobch64(l2.___Add(-r));
        }

        return l2.___Add(-r);
    }

    public static dynamic operator -(natch64 l, double r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Add(-r) is drobch64)
        {
            return new drobch64(l2.___Add(-r));
        }

        return l2.___Add(-r);
    }

    public static natch64 operator *(natch64 l, VOID r) => new natch64(l);

    public static dynamic operator *(natch64 l, drobch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, drobch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, drobch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, celch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, celch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, celch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, natch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, natch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, natch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, short r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, int r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, long r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is natch64)
        {
            return new natch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, float r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, str10 r)
    {
        natch64 l2 = new natch64(l);
        return l2.___Multiply(r);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, str16 r)
    {
        natch64 l2 = new natch64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, str32 r)
    {
        natch64 l2 = new natch64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, str64 r)
    {
        natch64 l2 = new natch64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(natch64 l, double r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }


    public static natch64 operator /(natch64 l, VOID r) => new natch64(l);

    public static dynamic operator /(natch64 l, drobch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, drobch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, drobch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, celch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is natch64)
        {
            return new natch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, celch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is natch64)
        {
            return new natch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, celch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is natch64)
        {
            return new natch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, natch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is natch64)
        {
            return new natch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, natch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is natch64)
        {
            return new natch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, natch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is natch64)
        {
            return new natch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, short r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is natch64)
        {
            return new natch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, int r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is natch64)
        {
            return new natch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, long r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is natch64)
        {
            return new natch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, float r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(natch64 l, double r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static natch64 operator ^(natch64 l, VOID r) => new natch64(l);

    public static dynamic operator ^(natch64 l, drobch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, drobch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, drobch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, natch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is natch64)
        {
            return new natch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, natch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is natch64)
        {
            return new natch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, natch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is natch64)
        {
            return new natch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, celch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is natch64)
        {
            return new natch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, celch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is natch64)
        {
            return new natch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, celch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is natch64)
        {
            return new natch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, short r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is natch64)
        {
            return new natch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, int r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is natch64)
        {
            return new natch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, long r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is natch64)
        {
            return new natch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, float r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(natch64 l, double r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator |(natch64 l, celch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch64 l, celch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch64 l, celch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch64 l, natch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch64 l, natch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch64 l, natch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch64 l, short r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch64 l, int r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator |(natch64 l, long r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Div(r) is natch64)
        {
            return new natch64(l2.___Div(r));
        }

        return l2.___Div(r);
    }

    public static dynamic operator %(natch64 l, VOID r) => new natch64(l);

    public static dynamic operator %(natch64 l, celch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Modulo(r) is natch64)
        {
            return new natch64(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch64 l, celch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Modulo(r) is natch64)
        {
            return new natch64(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch64 l, celch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Modulo(r) is natch64)
        {
            return new natch64(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch64 l, natch16 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Modulo(r) is natch64)
        {
            return new natch64(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch64 l, natch32 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Modulo(r) is natch64)
        {
            return new natch64(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch64 l, natch64 r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Modulo(r) is natch64)
        {
            return new natch64(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch64 l, short r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Modulo(r) is natch64)
        {
            return new natch64(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch64 l, int r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Modulo(r) is natch64)
        {
            return new natch64(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public static dynamic operator %(natch64 l, long r)
    {
        natch64 l2 = new natch64(l);
        if (l2.___Modulo(r) is natch64)
        {
            return new natch64(l2.___Modulo(r));
        }

        return l2.___Modulo(r);
    }

    public IEnumerator GetEnumerator()
    {
        for (ulong i = 0; i < (ulong)this; i++) yield return new natch64(i);
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

    public dynamic? ___Add(celch16 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(celch32 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(celch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(drobch16 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(drobch32 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(drobch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(natch16 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(natch32 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(natch64 num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(short num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(int num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(long num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(float num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Add(double num)
    {
        double num1 = Convert.ToDouble(this.value);
        double num2 = Convert.ToDouble(num);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
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
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Multiply(celch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 + num2);
        }
    }

    public dynamic? ___Multiply(celch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(drobch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(drobch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(drobch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(natch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(natch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(natch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(short num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(int num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(long num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(float num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
        }
    }

    public dynamic? ___Multiply(double num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
                return new natch64(num1 * num2);
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

    public dynamic? ___Divide(drobch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(drobch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(drobch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(celch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(celch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(celch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(natch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(natch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(natch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(short num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(int num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(long num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(float num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Divide(double num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num2 / num1)
        {
            case > MaxValue :
            {
                Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
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
            {
                if (num2 / num1 == this.trunc(num2 / num1))
                {
                    return new natch64(num2 / num1);
                }

                return new drobch64(num2 / num1);
            }
        }
    }

    public dynamic? ___Div(drobch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(drobch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(drobch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(celch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(celch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(celch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(natch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(natch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(natch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(short num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(int num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(long num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(float num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public dynamic? ___Div(double num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        if (this.trunc(num2 / num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        switch (num2 / num1)
        {
            case < celch64.MinValue :
            {
                NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
                err.Execute();
                return null;
            }
            default :
                return new natch64(num2 / num1);
        }
    }

    public natch64 ___Modulo(short num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(int num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(long num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(float num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(double num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(drobch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(drobch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(drobch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(celch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(celch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(celch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(natch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(natch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public natch64 ___Modulo(natch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        return new natch64(num2 % num1);
    }

    public dynamic? ___Power(short num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(int num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(long num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(float num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(double num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(drobch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(drobch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(drobch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(celch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(celch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(celch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(natch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(natch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }

    public dynamic? ___Power(natch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        if (this.pow(num2, num1) > celch64.MaxValue)
        {
            Natch64OutOfRangeMaxError err = new Natch64OutOfRangeMaxError(0, 0);
            err.Execute();
            return null;
        }

        if (this.pow(num2, num1) < celch64.MinValue)
        {
            NatchOutOfRangeOtricError err = new NatchOutOfRangeOtricError(0, 0);
            err.Execute();
            return null;
        }

        natch64 num3 = new natch64(this.pow(num2, num1));
        return num3;
    }
}