#region

using Errors.SyntaxInvalidError.ErrorDatatypes;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

#endregion

namespace Datatypes.Numbers;

public interface Interface_UDrobch
{
}

public interface Interface_Drobch
{
}

public interface Interface_UNumeric
{
    dynamic? ___Add(short n);
    dynamic? ___Add(int n);
    dynamic? ___Add(long n);
    dynamic? ___Add(float n);
    dynamic? ___Add(double n);
    dynamic? ___Add(celch16 n);
    dynamic? ___Add(celch32 n);
    dynamic? ___Add(celch64 n);
    dynamic? ___Add(drobch16 n);
    dynamic? ___Add(drobch32 n);
    dynamic? ___Add(drobch64 n);

    dynamic? ___Multiply(short n);
    dynamic? ___Multiply(int n);
    dynamic? ___Multiply(long n);
    dynamic? ___Multiply(float n);
    dynamic? ___Multiply(double n);
    dynamic? ___Multiply(celch16 n);
    dynamic? ___Multiply(celch32 n);
    dynamic? ___Multiply(celch64 n);
    dynamic? ___Multiply(drobch16 n);
    dynamic? ___Multiply(drobch32 n);
    dynamic? ___Multiply(drobch64 n);

    dynamic? ___Divide(short n);
    dynamic? ___Divide(int n);
    dynamic? ___Divide(long n);
    dynamic? ___Divide(float n);
    dynamic? ___Divide(double n);
    dynamic? ___Divide(celch16 n);
    dynamic? ___Divide(celch32 n);
    dynamic? ___Divide(celch64 n);
    dynamic? ___Divide(drobch16 n);
    dynamic? ___Divide(drobch32 n);
    dynamic? ___Divide(drobch64 n);

    dynamic? ___Power(short n);
    dynamic? ___Power(int n);
    dynamic? ___Power(long n);
    dynamic? ___Power(float n);
    dynamic? ___Power(double n);
    dynamic? ___Power(celch16 n);
    dynamic? ___Power(celch32 n);
    dynamic? ___Power(celch64 n);
    dynamic? ___Power(drobch16 n);
    dynamic? ___Power(drobch32 n);
    dynamic? ___Power(drobch64 n);
}

public class drobch64 : VOID, Interface_Drobch, Interface_UDrobch, Interface_UMathNumerics, Interface_UNumeric, Interface_Ural_Datatype
{
    public const double DefaultValue = 0D;
    public const double MaxValue = 18446744073709551615D;
    public const double MinValue = -9223372036854775807D;

    public drobch64(double _value) : base(_value)
    {
        switch (_value)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError er = new Drobch64OutOfRangeMaxError(0, 0);
                this.value = DefaultValue;
                break;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError er = new Drobch64OutOfRangeMinError(0, 0);
                this.value = DefaultValue;
                break;
            }
            default :
                this.value = Convert.ToDouble(_value);
                break;
        }
    }

    public drobch64(float _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Drobch64OutOfRangeMaxError er = new Drobch64OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else if (_value < MinValue)
        {
            Drobch64OutOfRangeMinError er = new Drobch64OutOfRangeMinError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = Convert.ToDouble(_value); }
    }

    public drobch64(int _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value);
    }

    public drobch64(short _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value);
    }

    public drobch64(long _value) : base(_value)
    {
        if (_value > MaxValue)
        {
            Drobch64OutOfRangeMaxError er = new Drobch64OutOfRangeMaxError(0, 0);
            this.value = DefaultValue;
        }
        else if (_value < MinValue)
        {
            Drobch64OutOfRangeMinError er = new Drobch64OutOfRangeMinError(0, 0);
            this.value = DefaultValue;
        }
        else { this.value = Convert.ToDouble(_value); }
    }

    public drobch64(string _value) : base(_value)
    {
        bool check_isfloat64 = double.TryParse(_value, out double new_value);
        switch (check_isfloat64)
        {
            case true :
                this.value = new_value;
                break;
            default :
                new_value = 0.0D;
                break;
        }

        this.value = Convert.ToDouble(new_value);
    }

    public drobch64(bool _value) : base(_value)
    {
        double new_value = _value switch
        {
            true => 1.0D,
            _ => 0.0D
        };

        this.value = Convert.ToDouble(new_value);
    }

    public drobch64(drobch16 _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public drobch64(drobch32 _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public drobch64(drobch64 _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public drobch64(celch16 _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public drobch64(celch32 _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public drobch64(celch64 _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public drobch64(natch16 _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public drobch64(natch32 _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public drobch64(natch64 _value) : base(_value)
    {
        this.value = Convert.ToDouble(_value.value);
    }

    public drobch64() : this(0.0D)
    {
    }

    // contructors are fully overloaded
    public static explicit operator drobch16(drobch64 num) => new drobch16 { value = num.value, subvalue = num.subvalue };

    public static explicit operator drobch32(drobch64 num) => new drobch32 { value = num.value, subvalue = num.subvalue };

    public static explicit operator celch16(drobch64 num) => new celch16 { value = num.value, subvalue = num.subvalue };

    public static explicit operator celch32(drobch64 num) => new celch32 { value = num.value, subvalue = num.subvalue };

    public static explicit operator celch64(drobch64 num) => new celch64 { value = num.value, subvalue = num.subvalue };

    public static explicit operator natch16(drobch64 num) => new natch16 { value = num.value, subvalue = num.subvalue };

    public static explicit operator natch32(drobch64 num) => new natch32 { value = num.value, subvalue = num.subvalue };

    public static explicit operator natch64(drobch64 num) => new natch64 { value = num.value, subvalue = num.subvalue };

    public static explicit operator string(drobch64 _value) => _value.ToString();

    public static explicit operator str10(drobch64 _value) => new str10(_value.ToString());

    public static explicit operator str16(drobch64 _value) => new str16(_value.ToString());

    public static explicit operator str32(drobch64 _value) => new str32(_value.ToString());

    public static explicit operator str64(drobch64 _value) => new str64(_value.ToString());

    public static explicit operator double(drobch64 num) => num.value == null ? 0.0 : (double)num.value;

    public static explicit operator float(drobch64 num) => num.value == null ? 0.0F : (float)num.value;

    public static explicit operator int(drobch64 num) => num.value == null ? 0 : (int)num.value;

    public static explicit operator short(drobch64 num) => (short)(num.value == null ? 0 : (short)num.value);

    public static explicit operator long(drobch64 num) => num.value == null ? 0L : (long)num.value;

    public static RCI operator ==(drobch64 l, VOID r) => new RCI(false);

    public static RCI operator ==(drobch64 l, ushort r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, uint r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, ulong r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, short r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, int r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, long r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, float r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, double r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, natch16 r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, natch32 r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, natch64 r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, celch16 r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, celch32 r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, celch64 r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, drobch16 r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, drobch32 r) => l.___Equals(r);

    public static RCI operator ==(drobch64 l, drobch64 r) => l.___Equals(r);

    public static RCI operator !=(drobch64 l, ushort r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, uint r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, ulong r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, short r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, int r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, long r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, float r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, double r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, natch16 r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, natch32 r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, natch64 r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, celch16 r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, celch32 r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, celch64 r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, drobch16 r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, drobch32 r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, drobch64 r) => l.___Equals(r).NE();

    public static RCI operator !=(drobch64 l, VOID r) => new RCI(true);

    public static RCI operator >(drobch64 l, ushort r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, uint r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, ulong r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, short r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, int r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, long r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, float r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, double r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, natch16 r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, natch32 r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, natch64 r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, celch16 r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, celch32 r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, celch64 r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, drobch16 r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, drobch32 r) => l.___GreaterThan(r);

    public static RCI operator >(drobch64 l, drobch64 r) => l.___GreaterThan(r);

    public static RCI operator <(drobch64 l, ushort r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, uint r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, ulong r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, short r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, int r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, long r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, float r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, double r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, natch16 r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, natch32 r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, natch64 r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, celch16 r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, celch32 r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, celch64 r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, drobch16 r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, drobch32 r) => l.___SmallerThan(r);

    public static RCI operator <(drobch64 l, drobch64 r) => l.___SmallerThan(r);

    public static RCI operator >=(drobch64 l, ushort r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, uint r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, ulong r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, short r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, int r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, long r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, float r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, double r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, natch16 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, natch32 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, natch64 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, celch16 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, celch32 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, celch64 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, drobch16 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, drobch32 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(drobch64 l, drobch64 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator <=(drobch64 l, ushort r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, uint r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, ulong r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, short r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, int r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, long r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, float r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, double r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, natch16 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, natch32 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, natch64 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, celch16 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, celch32 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, celch64 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, drobch16 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, drobch32 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(drobch64 l, drobch64 r) => l.___SmallerOrEqualThan(r);

    public static drobch64 operator +(drobch64 l, VOID r) => new drobch64(l);

    public static dynamic operator +(drobch64 l, drobch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, drobch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, celch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, celch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, celch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, natch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, natch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, natch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, short r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, int r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, long r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, float r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(drobch64 l, double r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(short l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(int l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(long l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static dynamic operator +(float l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Add(r) is drobch64)
        {
            return new drobch64(l2.___Add(r));
        }

        return l2.___Add(r);
    }

    public static drobch64 operator -(drobch64 l) => new drobch64(l.___Multiply(-1.0));

    public static dynamic operator +(double l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(r) is drobch64 ? new drobch64(l2.___Add(r)) : l2.___Add(r);
    }

    public static drobch64 operator -(drobch64 l, VOID r) => new drobch64(l);

    public static dynamic operator -(drobch64 l, drobch16 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(drobch64 l, drobch32 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(drobch64 l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(drobch64 l, celch16 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(drobch64 l, celch32 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(drobch64 l, celch64 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(drobch64 l, natch16 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(drobch64 l, natch32 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(drobch64 l, natch64 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(drobch64 l, short r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-r) is drobch64 ? new drobch64(l2.___Add(-r)) : l2.___Add(-r);
    }

    public static dynamic operator -(drobch64 l, int r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-r) is drobch64 ? new drobch64(l2.___Add(-r)) : l2.___Add(-r);
    }

    public static dynamic operator -(drobch64 l, long r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-r) is drobch64 ? new drobch64(l2.___Add(-r)) : l2.___Add(-r);
    }

    public static dynamic operator -(drobch64 l, float r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-r) is drobch64 ? new drobch64(l2.___Add(-r)) : l2.___Add(-r);
    }

    public static dynamic operator -(drobch64 l, double r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-r) is drobch64 ? new drobch64(l2.___Add(-r)) : l2.___Add(-r);
    }

    public static dynamic operator -(short l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(int l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(long l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(float l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static dynamic operator -(double l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        return l2.___Add(-(double)r.value) is drobch64 ? new drobch64(l2.___Add(-(double)r.value)) : l2.___Add(-(double)r.value);
    }

    public static drobch64 operator *(drobch64 l, VOID r) => new drobch64(l);

    public static dynamic operator *(drobch64 l, drobch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, drobch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, celch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, celch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, celch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, natch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, natch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, natch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, short r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, int r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, long r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, float r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(drobch64 l, double r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(short l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(int l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(long l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(float l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static dynamic operator *(double l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Multiply(r) is drobch64)
        {
            return new drobch64(l2.___Multiply(r));
        }

        return l2.___Multiply(r);
    }

    public static drobch64 operator /(drobch64 l, VOID r) => new drobch64(l);

    public static dynamic operator /(drobch64 l, drobch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, drobch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, celch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, celch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, celch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, natch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, natch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, natch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, short r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, int r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, long r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, float r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(drobch64 l, double r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(short l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(int l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(long l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(float l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static dynamic operator /(double l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Divide(r) is drobch64)
        {
            return new drobch64(l2.___Divide(r));
        }

        return l2.___Divide(r);
    }

    public static drobch64 operator ^(drobch64 l, VOID r) => new drobch64(l);

    public static dynamic operator ^(drobch64 l, drobch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, drobch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, natch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, natch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, natch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, celch16 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, celch32 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, celch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, short r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, int r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, long r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, float r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(drobch64 l, double r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(short l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(int l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(long l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(float l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
    }

    public static dynamic operator ^(double l, drobch64 r)
    {
        drobch64 l2 = new drobch64(l);
        if (l2.___Power(r) is drobch64)
        {
            return new drobch64(l2.___Power(r));
        }

        return l2.___Power(r);
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

    public RCI ___Equals(drobch16 num) => this.value == (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___Equals(drobch32 num) => this.value == (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___Equals(drobch64 num) => this.value == (double)num.value ? new RCI(true) : new RCI(false);

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

    public RCI ___GreaterThan(drobch16 num) => this.value > (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(drobch32 num) => this.value > (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(drobch64 num) => this.value > (double)num.value ? new RCI(true) : new RCI(false);

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

    public RCI ___SmallerThan(drobch16 num) => this.value < (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(drobch32 num) => this.value < (double)num.value ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(drobch64 num) => this.value < (double)num.value ? new RCI(true) : new RCI(false);

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

    public RCI ___GreaterOrEqualThan(drobch16 num) => RCI.ILI(this.___Equals(num), this.___GreaterThan(num));

    public RCI ___GreaterOrEqualThan(drobch32 num) => RCI.ILI(this.___Equals(num), this.___GreaterThan(num));

    public RCI ___GreaterOrEqualThan(drobch64 num) => RCI.ILI(this.___Equals(num), this.___GreaterThan(num));

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

    public RCI ___SmallerOrEqualThan(drobch16 num) => RCI.ILI(this.___Equals(num), this.___SmallerThan(num));

    public RCI ___SmallerOrEqualThan(drobch32 num) => RCI.ILI(this.___Equals(num), this.___SmallerThan(num));

    public RCI ___SmallerOrEqualThan(drobch64 num) => RCI.ILI(this.___Equals(num), this.___SmallerThan(num));

    public dynamic? ___Add(celch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch ((num1 + num2 > MaxValue) | (num1 + num2 < MinValue))
        {
            case true :
            {
                SyntaxInvalidDrobchDatatypeError err = new SyntaxInvalidDrobchDatatypeError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
                return num3;
            }
        }
    }

    public dynamic? ___Add(celch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
                return num3;
            }
        }
    }

    public dynamic? ___Add(drobch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
                return num3;
            }
        }
    }

    public dynamic? ___Add(drobch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
                return num3;
            }
        }
    }

    public dynamic? ___Add(drobch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
                return num3;
            }
        }
    }

    public dynamic? ___Add(int num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
                return num3;
            }
        }
    }

    public dynamic? ___Add(short num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
                return num3;
            }
        }
    }

    public dynamic? ___Add(float num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
                return num3;
            }
        }
    }

    public dynamic? ___Add(long num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
                return num3;
            }
        }
    }

    public dynamic? ___Add(natch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
                return num3;
            }
        }
    }

    public dynamic? ___Add(natch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 + num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 + num2);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
                return num3;
            }
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
                return num3;
            }
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
                return num3;
            }
        }
    }

    public dynamic? ___Multiply(celch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
                return num3;
            }
        }
    }

    public dynamic? ___Multiply(celch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (num1 * num2)
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
                return num3;
            }
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
                return num3;
            }
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
                return num3;
            }
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
                return num3;
            }
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
                return num3;
            }
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num1 * num2);
                return num3;
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
                return num3;
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
                return num3;
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
                return num3;
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
                return num3;
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
                return num3;
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
                return num3;
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
                return num3;
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
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
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
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(num2 / num1);
                return num3;
            }
        }
    }

    public dynamic? ___Power(short num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(int num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(long num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(float num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(double num)
    {
        double num1 = Convert.ToDouble(num);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(celch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(celch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(celch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(drobch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(drobch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(drobch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(natch16 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(natch32 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public dynamic? ___Power(natch64 num)
    {
        double num1 = Convert.ToDouble(num.value);
        double num2 = Convert.ToDouble(this.value);
        switch (Math.Pow(num2, num1))
        {
            case > MaxValue :
            {
                Drobch64OutOfRangeMaxError err = new Drobch64OutOfRangeMaxError(0, 0);
                err.Execute();
                return null;
            }
            case < MinValue :
            {
                Drobch64OutOfRangeMinError err = new Drobch64OutOfRangeMinError(0, 0);
                err.Execute();
                return null;
            }
            default :
            {
                drobch64 num3 = new drobch64(Math.Pow(num2, num1));
                return num3;
            }
        }
    }

    public drobch64 abs()
    {
        switch (((double)this.value > 0) | ((double)this.value == 0))
        {
            case true :
            {
                drobch64 new_num = new drobch64((double)this.value);
                return new_num;
            }
            default :
            {
                drobch64 new_num = new drobch64((double)this.value * -1);
                return new_num;
            }
        }
    }
    //add operations with natch166, natch32, natch64
}