﻿#region

using Errors.SyntaxInvalidError.ErrorDatatypes;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOverloadDatatype;

#endregion

namespace Datatypes.Strings;

public interface Interface_Ustr
{
    dynamic ___Add(string s);
    dynamic ___Add(str0 s);
    dynamic ___Add(str10 s);
    dynamic ___Add(str16 s);
    dynamic ___Add(str32 s);
    dynamic ___Add(str64 s);
    dynamic ___Add(natch16 n);
    dynamic ___Add(natch32 n);
    dynamic ___Add(natch64 n);
    dynamic ___Add(celch16 n);
    dynamic ___Add(celch32 n);
    dynamic ___Add(celch64 n);
    dynamic ___Add(drobch16 n);
    dynamic ___Add(drobch32 n);
    dynamic ___Add(drobch64 n);

    /*
    dynamic ___Minus(string s);
    dynamic ___Minus(str0 s);
    dynamic ___Minus(str10 s);
    dynamic ___Minus(str16 s);
    dynamic ___Minus(str32 s);
    dynamic ___Minus(str64 s);
    */
    dynamic ___Multiply(natch16 n);
    dynamic ___Multiply(natch32 n);
    dynamic ___Multiply(natch64 n);
    dynamic ___Multiply(celch16 n);
    dynamic ___Multiply(celch32 n);
    dynamic ___Multiply(celch64 n);

    /*
    dynamic ___Multiply(string s);
    dynamic ___Multiply(str0 s);
    dynamic ___Multiply(str10 s);
    dynamic ___Multiply(str16 s);
    dynamic ___Multiply(str32 s);
    dynamic ___Multiply(str64 s);
    */

    massiv<str0> ToMassiv();
    spisok ToSpisok();
    RCI EtoCifra();
    RCI EtoDrob();
}

public class str64 : VOID, Interface_Ustr, Interface_Ural_Datatype
{
    public const ulong MaxLength = 18446744073709551615U;
    public const string DefaultValue = "";
    public readonly natch64 Count;

    public str64(string _value = "") : base(_value)
    {
        this.value = Convert.ToString(_value);
        this.Count = new natch64(this.value.Length);
    }

    public str64(char _value) : base(_value)
    {
        this.value = Convert.ToString(_value);
        this.Count = new natch64(this.value.Length);
    }

    public str64(str0 _value) : base(_value)
    {
        this.value = Convert.ToString(_value.value);
        this.Count = new natch64(this.value.Length);
    }

    public str64(str10 _value) : base(_value)
    {
        this.value = _value.value;
        this.Count = new natch64(this.value.Length);
    }

    public str64(str16 _value) : base(_value)
    {
        this.value = _value.value;
        this.Count = new natch64(this.value.Length);
    }

    public str64(str32 _value) : base(_value)
    {
        this.value = _value.value;
        this.Count = new natch64(this.value.Length);
    }

    public str64(str64 _value) : base(_value)
    {
        this.value = _value.value;
        this.Count = new natch64(this.value.Length);
    }

    public str0 this[int index]
    {
        get => new str0(this.value[index]);
        set => this.value = this.value.Remove(index, 1).Insert(index, value.ToString());
    }

    public str0 this[ushort index]
    {
        get => new str0(this.value[index]);
        set => this.value = this.value.Remove(index, 1).Insert(index, value.ToString());
    }

    public str0 this[uint index]
    {
        get => new str0(this.value[index]);
        set => this.value = this.value.Remove(index, 1).Insert(index, value.ToString());
    }

    public str0 this[ulong index]
    {
        get => new str0(this.value[index]);
        set => this.value = this.value.Remove(index, 1).Insert(index, value.ToString());
    }

    public str0 this[natch16 index]
    {
        get => new str0(this.value[index.value]);
        set => this.value = this.value.Remove(index.value, 1).Insert(index.value, value.ToString());
    }

    public str0 this[natch32 index]
    {
        get => new str0(this.value[index.value]);
        set => this.value = this.value.Remove(index.value, 1).Insert(index.value, value.ToString());
    }

    public str0 this[natch64 index]
    {
        get => new str0(this.value[index.value]);
        set => this.value = this.value.Remove(index.value, 1).Insert(index.value, value.ToString());
    }

    public str64 this[int start, int stop] => new str64(Slice((string)this.value, start, stop));

    public str64 this[int start, natch16 stop] => new str64(Slice((string)this.value, start, (int)stop.value));

    public str64 this[int start, natch32 stop] => new str64(Slice((string)this.value, start, (int)stop.value));

    public str64 this[int start, natch64 stop] => new str64(Slice((string)this.value, start, (int)stop.value));

    public str64 this[natch16 start, int stop] => new str64(Slice((string)this.value, (int)start.value, stop));

    public str64 this[natch16 start, natch16 stop] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));

    public str64 this[natch16 start, natch32 stop] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));

    public str64 this[natch16 start, natch64 stop] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));

    public str64 this[natch32 start, int stop] => new str64(Slice((string)this.value, (int)start.value, stop));

    public str64 this[natch32 start, natch16 stop] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));

    public str64 this[natch32 start, natch32 stop] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));

    public str64 this[natch32 start, natch64 stop] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));

    public str64 this[natch64 start, int stop] => new str64(Slice((string)this.value, (int)start.value, stop));

    public str64 this[natch64 start, natch16 stop] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));

    public str64 this[natch64 start, natch32 stop] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));

    public str64 this[natch64 start, natch64 stop] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));

    public str64 this[int start, int stop, int step] => new str64(Slice((string)this.value, start, stop, step));

    public str64 this[int start, int stop, natch16 step] => new str64(Slice((string)this.value, start, stop, (int)step.value));

    public str64 this[int start, int stop, natch32 step] => new str64(Slice((string)this.value, start, stop, (int)step.value));

    public str64 this[int start, int stop, natch64 step] => new str64(Slice((string)this.value, start, stop, (int)step.value));

    public str64 this[int start, natch16 stop, int step] => new str64(Slice((string)this.value, start, (int)stop.value, step));

    public str64 this[int start, natch16 stop, natch16 step] => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));

    public str64 this[int start, natch16 stop, natch32 step] => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));

    public str64 this[int start, natch16 stop, natch64 step] => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));

    public str64 this[int start, natch32 stop, int step] => new str64(Slice((string)this.value, start, (int)stop.value, step));

    public str64 this[int start, natch32 stop, natch16 step] => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));

    public str64 this[int start, natch32 stop, natch32 step] => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));

    public str64 this[int start, natch32 stop, natch64 step] => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));

    public str64 this[int start, natch64 stop, int step] => new str64(Slice((string)this.value, start, (int)stop.value, step));

    public str64 this[int start, natch64 stop, natch16 step] => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));

    public str64 this[int start, natch64 stop, natch32 step] => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));

    public str64 this[int start, natch64 stop, natch64 step] => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));

    public str64 this[natch16 start, int stop, int step] => new str64(Slice((string)this.value, (int)start.value, stop, step));

    public str64 this[natch16 start, int stop, natch16 step] => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));

    public str64 this[natch16 start, int stop, natch32 step] => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));

    public str64 this[natch16 start, int stop, natch64 step] => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));

    public str64 this[natch16 start, natch16 stop, int step] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, step));

    public str64 this[natch16 start, natch16 stop, natch16 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch16 start, natch16 stop, natch32 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch16 start, natch16 stop, natch64 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch16 start, natch32 stop, int step] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, step));

    public str64 this[natch16 start, natch32 stop, natch16 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch16 start, natch32 stop, natch32 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch16 start, natch32 stop, natch64 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch16 start, natch64 stop, int step] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, step));

    public str64 this[natch16 start, natch64 stop, natch16 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch16 start, natch64 stop, natch32 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch16 start, natch64 stop, natch64 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch32 start, int stop, int step] => new str64(Slice((string)this.value, (int)start.value, stop, step));

    public str64 this[natch32 start, int stop, natch16 step] => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));

    public str64 this[natch32 start, int stop, natch32 step] => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));

    public str64 this[natch32 start, int stop, natch64 step] => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));

    public str64 this[natch32 start, natch16 stop, int step] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, step));

    public str64 this[natch32 start, natch16 stop, natch16 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch32 start, natch16 stop, natch32 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch32 start, natch16 stop, natch64 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public str64 this[natch32 start, natch32 stop, int step] => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, step));

    public str64 this[natch32 start, natch32 stop, natch16 step] =>
        new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));

    public static RCI operator ==(str64 l, string r) => l.___Equals(r);

    public static RCI operator ==(str64 l, str10 r) => l.___Equals(r);

    public static RCI operator ==(str64 l, str16 r) => l.___Equals(r);

    public static RCI operator ==(str64 l, str32 r) => l.___Equals(r);

    public static RCI operator ==(str64 l, str64 r) => l.___Equals(r);

    public static RCI operator !=(str64 l, string r) => l.___Equals(r).NE();

    public static RCI operator !=(str64 l, str10 r) => l.___Equals(r).NE();

    public static RCI operator !=(str64 l, str16 r) => l.___Equals(r).NE();

    public static RCI operator !=(str64 l, str32 r) => l.___Equals(r).NE();

    public static RCI operator !=(str64 l, str64 r) => l.___Equals(r).NE();

    public static RCI operator >(str64 l, string r) => l.___GreaterThan(r);

    public static RCI operator >(str64 l, str10 r) => l.___GreaterThan(r);

    public static RCI operator >(str64 l, str16 r) => l.___GreaterThan(r);

    public static RCI operator >(str64 l, str32 r) => l.___GreaterThan(r);

    public static RCI operator >(str64 l, str64 r) => l.___GreaterThan(r);

    public static RCI operator <(str64 l, string r) => l.___SmallerThan(r);

    public static RCI operator <(str64 l, str10 r) => l.___SmallerThan(r);

    public static RCI operator <(str64 l, str16 r) => l.___SmallerThan(r);

    public static RCI operator <(str64 l, str32 r) => l.___SmallerThan(r);

    public static RCI operator <(str64 l, str64 r) => l.___SmallerThan(r);

    public static RCI operator >=(str64 l, string r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(str64 l, str10 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(str64 l, str16 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(str64 l, str32 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator >=(str64 l, str64 r) => l.___GreaterOrEqualThan(r);

    public static RCI operator <=(str64 l, string r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(str64 l, str10 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(str64 l, str16 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(str64 l, str32 r) => l.___SmallerOrEqualThan(r);

    public static RCI operator <=(str64 l, str64 r) => l.___SmallerOrEqualThan(r);

    public static dynamic operator +(str64 l, str0 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, str10 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, str16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, str32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, str64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, natch16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, natch32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, natch64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, celch16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, celch32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, celch64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, drobch16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, drobch32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(str64 l, drobch64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(natch16 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(natch32 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(natch64 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(celch16 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(celch32 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(celch64 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(drobch16 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(drobch32 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator +(drobch64 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Add(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, str0 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, str10 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, str16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, str32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, str64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, natch16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, natch32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, natch64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, celch16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, celch32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, celch64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, drobch16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, drobch32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(str64 l, drobch64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(natch16 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(natch32 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(natch64 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(celch16 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(celch32 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(celch64 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(drobch16 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(drobch32 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator -(drobch64 l, str64 r)
    {
        str64 l2 = new str64(Convert.ToString(l));
        return l2.___Minus(Convert.ToString(r.value));
    }

    public static dynamic operator *(str64 l, natch16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(str64 l, natch32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(str64 l, natch64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(str64 l, celch16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(str64 l, celch32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(str64 l, celch64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(str64 l, str10 r)
    {
        str64 l2 = new str64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(str64 l, str16 r)
    {
        str64 l2 = new str64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(str64 l, str32 r)
    {
        str64 l2 = new str64(l);
        return l2.___Multiply(r);
    }

    public static dynamic operator *(str64 l, str64 r)
    {
        str64 l2 = new str64(l);
        return l2.___Multiply(r);
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < (int)this.Count; i++) yield return new str0(this.value[i]);
    }

    public static explicit operator string(str64 str) => (string)str.value;

    public RCI ___Equals(string str) => (string)this.value == str ? new RCI(true) : new RCI(false);

    public RCI ___Equals(str10 str) => (string)this.value == (string)str.value ? new RCI(true) : new RCI(false);

    public RCI ___Equals(str16 str) => (string)this.value == (string)str.value ? new RCI(true) : new RCI(false);

    public RCI ___Equals(str32 str) => (string)this.value == (string)str.value ? new RCI(true) : new RCI(false);

    public RCI ___Equals(str64 str) => (string)this.value == (string)str.value ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(string str) => this.value.Lengt > str.Length ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(str10 str) => this.value.Length > str.value.Length ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(str16 str) => this.value.Length > str.value.Length ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(str32 str) => this.value.Length > str.value.Length ? new RCI(true) : new RCI(false);

    public RCI ___GreaterThan(str64 str) => this.value.Length > str.value.Length ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(string str) => this.value.Lengt < str.Length ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(str10 str) => this.value.Length < str.value.Length ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(str16 str) => this.value.Length < str.value.Length ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(str32 str) => this.value.Length < str.value.Length ? new RCI(true) : new RCI(false);

    public RCI ___SmallerThan(str64 str) => this.value.Length < str.value.Length ? new RCI(true) : new RCI(false);

    public RCI ___GreaterOrEqualThan(string str) => RCI.ILI(this.___Equals(str), this.___GreaterThan(str));


    public RCI ___GreaterOrEqualThan(str10 str) => RCI.ILI(this.___Equals(str), this.___GreaterThan(str));

    public RCI ___GreaterOrEqualThan(str16 str) => RCI.ILI(this.___Equals(str), this.___GreaterThan(str));

    public RCI ___GreaterOrEqualThan(str32 str) => RCI.ILI(this.___Equals(str), this.___GreaterThan(str));

    public RCI ___GreaterOrEqualThan(str64 str) => RCI.ILI(this.___Equals(str), this.___GreaterThan(str));

    public RCI ___SmallerOrEqualThan(string str) => RCI.ILI(this.___Equals(str), this.___SmallerThan(str));


    public RCI ___SmallerOrEqualThan(str10 str) => RCI.ILI(this.___Equals(str), this.___SmallerThan(str));

    public RCI ___SmallerOrEqualThan(str16 str) => RCI.ILI(this.___Equals(str), this.___SmallerThan(str));

    public RCI ___SmallerOrEqualThan(str32 str) => RCI.ILI(this.___Equals(str), this.___SmallerThan(str));

    public RCI ___SmallerOrEqualThan(str64 str) => RCI.ILI(this.___Equals(str), this.___SmallerThan(str));

    public dynamic ___Add(dynamic _value)
    {
        if (IsNumericFull(_value))
        {
            return new SyntaxInvalidOverloadStrNumericError(0, 0);
        }

        switch (_value)
        {
            case str0 :
                return this.___Add(_value.ToString());
            default :
            {
                string str = this.value + Convert.ToString(_value);
                switch ((ulong)str.Length)
                {
                    case < MaxLength :
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

    public dynamic ___Add(string _value)
    {
        string str = this.value + Convert.ToString(_value);
        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Add(str0 _value) => this.___Add((string)_value.value);

    public dynamic ___Add(str10 _value) => this.___Add((string)_value.value);

    public dynamic ___Add(str16 _value) => this.___Add((string)_value.value);

    public dynamic ___Add(str32 _value) => this.___Add((string)_value.value);

    public dynamic ___Add(str64 _value) => this.___Add((string)_value.value);

    public dynamic ___Add(natch16 _value)
    {
        string str = this.value + Convert.ToString(_value.value);
        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Add(natch32 _value)
    {
        string str = this.value + Convert.ToString(_value.value);
        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Add(natch64 _value)
    {
        string str = this.value + Convert.ToString(_value.value);
        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Add(celch16 _value)
    {
        string str = this.value + Convert.ToString(_value.value);
        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Add(celch32 _value)
    {
        string str = this.value + Convert.ToString(_value.value);
        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Add(celch64 _value)
    {
        string str = this.value + Convert.ToString(_value.value);
        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Add(drobch16 _value)
    {
        string str = this.value + Convert.ToString(_value.value);
        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Add(drobch32 _value)
    {
        string str = this.value + Convert.ToString(_value.value);
        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Add(drobch64 _value)
    {
        string str = this.value + Convert.ToString(_value.value);
        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public str64 ___Minus(string str2)
    {
        // Convert str1 to a char array
        char [] s = this.value.ToCharArray();

        // Loop through each character in str2
        foreach (char c in str2)
            // Remove c from set1 if it is present
            s = ((string)this.value).Where(predicate: val => val != c).ToArray();

        // Create a new string from the remaining characters in set1
        return new str64(new string(s));
    }

    public str64 ___Minus(str0 _value) => this.___Add((string)_value.value);

    public str64 ___Minus(str10 _value) => this.___Add((string)_value.value);

    public str64 ___Minus(str16 _value) => this.___Add((string)_value.value);

    public str64 ___Minus(str32 _value) => this.___Add((string)_value.value);

    public str64 ___Minus(str64 _value) => this.___Add((string)_value.value);

    public str64 ___Multiply(str10 str)
    {
        List<ulong>? cnv = new List<ulong>();

        foreach (char c1 in this.value)
        {
            foreach (char c2 in str.value) cnv.Add(c1 * (ulong)c2 / (ulong)(this.Count + str.Count));
        }

        char [] result = cnv.Select(selector: c => (char)c).ToArray();

        return new str64(new string(result));
    }

    public str64 ___Multiply(str16 str)
    {
        List<ulong>? cnv = new List<ulong>();

        foreach (char c1 in this.value)
        {
            foreach (char c2 in str.value) cnv.Add(c1 * (ulong)c2 / (ulong)(this.Count + str.Count));
        }

        char [] result = cnv.Select(selector: c => (char)c).ToArray();

        return new str64(new string(result));
    }

    public str64 ___Multiply(str32 str)
    {
        List<ulong>? cnv = new List<ulong>();

        foreach (char c1 in this.value)
        {
            foreach (char c2 in str.value) cnv.Add(c1 * (ulong)c2 / (ulong)(this.Count + str.Count));
        }

        char [] result = cnv.Select(selector: c => (char)c).ToArray();

        return new str64(new string(result));
    }

    public str64 ___Multiply(str64 str)
    {
        List<ulong>? cnv = new List<ulong>();

        foreach (char c1 in this.value)
        {
            foreach (char c2 in str.value) cnv.Add(c1 * (ulong)c2 / (ulong)(this.Count + str.Count));
        }

        char [] result = cnv.Select(selector: c => (char)c).ToArray();

        return new str64(new string(result));
    }

    public dynamic ___Multiply(natch16 _value)
    {
        string str = StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
        if (_value.value == 0)
        {
            return this;
        }

        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Multiply(natch32 _value)
    {
        string str = StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
        if (_value.value == 0)
        {
            return this;
        }

        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Multiply(natch64 _value)
    {
        string str = StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
        if (_value.value == 0)
        {
            return this;
        }

        switch ((ulong)str.Length)
        {
            case < MaxLength :
                return new str64(str);
            default :
            {
                Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Multiply(celch16 _value)
    {
        if (_value.value == 0)
        {
            return this;
        }

        if (_value.value > 0)
        {
            string str = StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
            switch ((ulong)str.Length)
            {
                case < MaxLength :
                    return new str64(str);
                default :
                {
                    Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                    err.Execute();
                    return null;
                }
            }
        }
        else
        {
            ulong n = Convert.ToUInt64(-1 * _value.value);
            string str = Convert.ToString(this.value);
            if (n < (ulong)str.Length)
            {
                str = Slice(str, 0, n + 1);
                str = StrMultiply(str, n);
                switch ((ulong)str.Length)
                {
                    case < MaxLength :
                        return new str64(str);
                    default :
                    {
                        Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                        err.Execute();
                        return null;
                    }
                }
            }

            {
                StrIndexOutOfRangeError err = new StrIndexOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Multiply(celch32 _value)
    {
        if (_value.value == 0)
        {
            return this;
        }

        if (_value.value > 0)
        {
            string str = StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
            switch ((ulong)str.Length)
            {
                case < MaxLength :
                    return new str64(str);
                default :
                {
                    Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                    err.Execute();
                    return null;
                }
            }
        }
        else
        {
            ulong n = Convert.ToUInt64(-1 * _value.value);
            string str = Convert.ToString(this.value);
            if (n < (ulong)str.Length)
            {
                str = Slice(str, 0, n + 1);
                str = StrMultiply(str, n);
                switch ((ulong)str.Length)
                {
                    case < MaxLength :
                        return new str64(str);
                    default :
                    {
                        Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                        err.Execute();
                        return null;
                    }
                }
            }

            {
                StrIndexOutOfRangeError err = new StrIndexOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public dynamic ___Multiply(celch64 _value)
    {
        if (_value.value == 0)
        {
            return this;
        }

        if (_value.value > 0)
        {
            string str = StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
            switch ((ulong)str.Length)
            {
                case < MaxLength :
                    return new str64(str);
                default :
                {
                    Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                    err.Execute();
                    return null;
                }
            }
        }
        else
        {
            ulong n = Convert.ToUInt64(-1 * _value.value);
            string str = Convert.ToString(this.value);
            if (n < (ulong)str.Length)
            {
                str = Slice(str, 0, n + 1);
                str = StrMultiply(str, n);
                switch ((ulong)str.Length)
                {
                    case < MaxLength :
                        return new str64(str);
                    default :
                    {
                        Str64OutOfRangeError err = new Str64OutOfRangeError(0, 0);
                        err.Execute();
                        return null;
                    }
                }
            }

            {
                StrIndexOutOfRangeError err = new StrIndexOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public str64 Reverse()
    {
        char [] dop = this.value.ToCharArray();
        char simvol;
        for (int i = 0; i < dop.Length / 2; i++)
        {
            simvol = dop[i];
            dop[i] = dop[dop.Length - i - 1];
            dop[dop.Length - i - 1] = simvol;
        }

        string rev = new string(dop);
        return new str64(rev);
    }

    public static string Range(string _value, int step)
    {
        return new string(_value.Where(predicate: (ch, index) => index % step == 0).ToArray());
    }

    public static string Range(str10 _value, int step)
    {
        string value = _value.value;
        return new string(value.Where(predicate: (ch, index) => index % step == 0).ToArray());
    }

    public static string Range(str16 _value, int step)
    {
        string value = _value.value;
        return new string(value.Where(predicate: (ch, index) => index % step == 0).ToArray());
    }

    public static string Range(str32 _value, int step)
    {
        string value = _value.value;
        return new string(value.Where(predicate: (ch, index) => index % step == 0).ToArray());
    }

    public static string Range(str64 _value, int step)
    {
        string value = _value.value;
        return new string(value.Where(predicate: (ch, index) => index % step == 0).ToArray());
    }

    public string Range(int step)
    {
        string value = this.value;
        return new string(value.Where(predicate: (ch, index) => index % step == 0).ToArray());
    }

    public str64 Slice(int start)
    {
        int len = this.value.Length - start;
        return new str64(this.value.Substring(start, len));
    }

    public str64 Slice(int start, int end) => new str64(this.value.Substring(start, end - start));

    public str64 Slice(int start, int end, int step)
    {
        string value = this.value.Substring(start, end - start);
        string str_step = new string(value.Where(predicate: (ch, index) => index % step == 0).ToArray());
        return new str64(str_step);
    }

    public massiv<str0> ToMassiv()
    {
        return new massiv<str0>(((string)this.value).Select(selector: c => new str0(c)).ToArray());
    }

    public spisok ToSpisok()
    {
        return new spisok(((string)this.value).Select(selector: c => new str0(c)).ToArray());
    }

    public massiv<str0> Reqq()
    {
        return ((string)this.value).Aggregate(new massiv<str0>(), func: (acc, c) =>
        {
            acc.___Add(new str0(c));
            acc.___Add(acc);
            return acc;
        });
    }

    public RCI EtoCifra()
    {
        RCI flag = new RCI(true);
        if (this.value.Length == 0)
        {
            goto Sign;
        }

        if ((this.value.Length == 1) & ((this.value[0] == '+') | (this.value[0] == '-')))
        {
            goto Sign;
        }

        for (int i = 0; i < this.value.Length; i++)
            switch (i)
            {
                case 0 when (this.value[i] == '+') | (this.value[i] == '-') :
                    continue;
                case 0 :
                    switch (this.value[i])
                    {
                        case '0' :
                            flag *= new RCI(true);
                            goto End;
                        case '1' :
                            flag *= new RCI(true);
                            goto End;
                        case '2' :
                            flag *= new RCI(true);
                            goto End;
                        case '3' :
                            flag *= new RCI(true);
                            goto End;
                        case '4' :
                            flag *= new RCI(true);
                            goto End;
                        case '5' :
                            flag *= new RCI(true);
                            goto End;
                        case '6' :
                            flag *= new RCI(true);
                            goto End;
                        case '7' :
                            flag *= new RCI(true);
                            goto End;
                        case '8' :
                            flag *= new RCI(true);
                            goto End;
                        case '9' :
                            flag *= new RCI(true);
                            goto End;
                        default :
                            flag *= new RCI(false);
                            goto End;
                    }

                    break;
                default :
                    switch (this.value[i])
                    {
                        case '0' :
                            flag *= new RCI(true);
                            goto End;
                        case '1' :
                            flag *= new RCI(true);
                            goto End;
                        case '2' :
                            flag *= new RCI(true);
                            goto End;
                        case '3' :
                            flag *= new RCI(true);
                            goto End;
                        case '4' :
                            flag *= new RCI(true);
                            goto End;
                        case '5' :
                            flag *= new RCI(true);
                            goto End;
                        case '6' :
                            flag *= new RCI(true);
                            goto End;
                        case '7' :
                            flag *= new RCI(true);
                            goto End;
                        case '8' :
                            flag *= new RCI(true);
                            goto End;
                        case '9' :
                            flag *= new RCI(true);
                            goto End;
                        default :
                            flag *= new RCI(false);
                            goto End;
                    }

                    break;
            }

        Sign:
        return new RCI(false);

        End:
        return flag;
    }

    public static RCI EtoCifra(string value)
    {
        RCI flag = new RCI(true);
        switch (value.Length)
        {
            case 0 :
                goto Sign;
            default :
            {
                switch ((value.Length == 1) & ((value[0] == '+') | (value[0] == '-')))
                {
                    case true :
                        goto Sign;
                    default :
                    {
                        for (int i = 0; i < value.Length; i++)
                            switch (i)
                            {
                                case 0 when (value[i] == '+') | (value[i] == '-') :
                                    continue;
                                case 0 :
                                    switch (value[i])
                                    {
                                        case '0' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '1' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '2' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '3' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '4' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '5' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '6' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '7' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '8' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '9' :
                                            flag *= new RCI(true);
                                            goto End;
                                        default :
                                            flag *= new RCI(false);
                                            goto End;
                                    }

                                    break;
                                default :
                                    switch (value[i])
                                    {
                                        case '0' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '1' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '2' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '3' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '4' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '5' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '6' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '7' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '8' :
                                            flag *= new RCI(true);
                                            goto End;
                                        case '9' :
                                            flag *= new RCI(true);
                                            goto End;
                                        default :
                                            flag *= new RCI(false);
                                            goto End;
                                    }

                                    break;
                            }

                        break;
                    }
                }

                break;
            }
        }

        Sign:
        return new RCI(false);

        End:
        return flag;
    }

    public static RCI EtoCifra(str10 value)
    {
        RCI flag = new RCI(true);
        if (value.value.Length == 0)
        {
            goto Sign;
        }

        if ((value.value.Length == 1) & ((value.value[0] == '+') | (value.value[0] == '-')))
        {
            goto Sign;
        }

        for (int i = 0; i < value.value.Length; i++)
            switch (i)
            {
                case 0 when (value.value[i] == '+') | (value.value[i] == '-') :
                    continue;
                case 0 :
                    switch (value.value[i])
                    {
                        case '0' :
                            flag *= new RCI(true);
                            goto End;
                        case '1' :
                            flag *= new RCI(true);
                            goto End;
                        case '2' :
                            flag *= new RCI(true);
                            goto End;
                        case '3' :
                            flag *= new RCI(true);
                            goto End;
                        case '4' :
                            flag *= new RCI(true);
                            goto End;
                        case '5' :
                            flag *= new RCI(true);
                            goto End;
                        case '6' :
                            flag *= new RCI(true);
                            goto End;
                        case '7' :
                            flag *= new RCI(true);
                            goto End;
                        case '8' :
                            flag *= new RCI(true);
                            goto End;
                        case '9' :
                            flag *= new RCI(true);
                            goto End;
                        default :
                            flag *= new RCI(false);
                            goto End;
                    }

                    break;
                default :
                    switch (value.value[i])
                    {
                        case '0' :
                            flag *= new RCI(true);
                            goto End;
                        case '1' :
                            flag *= new RCI(true);
                            goto End;
                        case '2' :
                            flag *= new RCI(true);
                            goto End;
                        case '3' :
                            flag *= new RCI(true);
                            goto End;
                        case '4' :
                            flag *= new RCI(true);
                            goto End;
                        case '5' :
                            flag *= new RCI(true);
                            goto End;
                        case '6' :
                            flag *= new RCI(true);
                            goto End;
                        case '7' :
                            flag *= new RCI(true);
                            goto End;
                        case '8' :
                            flag *= new RCI(true);
                            goto End;
                        case '9' :
                            flag *= new RCI(true);
                            goto End;
                        default :
                            flag *= new RCI(false);
                            goto End;
                    }

                    break;
            }

        Sign:
        return new RCI(false);

        End:
        return flag;
    }

    public static RCI EtoCifra(str16 value)
    {
        RCI flag = new RCI(true);
        if (value.value.Length == 0)
        {
            goto Sign;
        }

        if ((value.value.Length == 1) & ((value.value[0] == '+') | (value.value[0] == '-')))
        {
            goto Sign;
        }

        for (int i = 0; i < value.value.Length; i++)
            switch (i)
            {
                case 0 when (value.value[i] == '+') | (value.value[i] == '-') :
                    continue;
                case 0 :
                    switch (value.value[i])
                    {
                        case '0' :
                            flag *= new RCI(true);
                            goto End;
                        case '1' :
                            flag *= new RCI(true);
                            goto End;
                        case '2' :
                            flag *= new RCI(true);
                            goto End;
                        case '3' :
                            flag *= new RCI(true);
                            goto End;
                        case '4' :
                            flag *= new RCI(true);
                            goto End;
                        case '5' :
                            flag *= new RCI(true);
                            goto End;
                        case '6' :
                            flag *= new RCI(true);
                            goto End;
                        case '7' :
                            flag *= new RCI(true);
                            goto End;
                        case '8' :
                            flag *= new RCI(true);
                            goto End;
                        case '9' :
                            flag *= new RCI(true);
                            goto End;
                        default :
                            flag *= new RCI(false);
                            goto End;
                    }

                    break;
                default :
                    switch (value.value[i])
                    {
                        case '0' :
                            flag *= new RCI(true);
                            goto End;
                        case '1' :
                            flag *= new RCI(true);
                            goto End;
                        case '2' :
                            flag *= new RCI(true);
                            goto End;
                        case '3' :
                            flag *= new RCI(true);
                            goto End;
                        case '4' :
                            flag *= new RCI(true);
                            goto End;
                        case '5' :
                            flag *= new RCI(true);
                            goto End;
                        case '6' :
                            flag *= new RCI(true);
                            goto End;
                        case '7' :
                            flag *= new RCI(true);
                            goto End;
                        case '8' :
                            flag *= new RCI(true);
                            goto End;
                        case '9' :
                            flag *= new RCI(true);
                            goto End;
                        default :
                            flag *= new RCI(false);
                            goto End;
                    }

                    break;
            }

        Sign:
        return new RCI(false);

        End:
        return flag;
    }

    public static RCI EtoCifra(str32 value)
    {
        RCI flag = new RCI(true);
        if (value.value.Length == 0)
        {
            goto Sign;
        }

        if ((value.value.Length == 1) & ((value.value[0] == '+') | (value.value[0] == '-')))
        {
            goto Sign;
        }

        for (int i = 0; i < value.value.Length; i++)
            switch (i)
            {
                case 0 when (value.value[i] == '+') | (value.value[i] == '-') :
                    continue;
                case 0 :
                    switch (value.value[i])
                    {
                        case '0' :
                            flag *= new RCI(true);
                            goto End;
                        case '1' :
                            flag *= new RCI(true);
                            goto End;
                        case '2' :
                            flag *= new RCI(true);
                            goto End;
                        case '3' :
                            flag *= new RCI(true);
                            goto End;
                        case '4' :
                            flag *= new RCI(true);
                            goto End;
                        case '5' :
                            flag *= new RCI(true);
                            goto End;
                        case '6' :
                            flag *= new RCI(true);
                            goto End;
                        case '7' :
                            flag *= new RCI(true);
                            goto End;
                        case '8' :
                            flag *= new RCI(true);
                            goto End;
                        case '9' :
                            flag *= new RCI(true);
                            goto End;
                        default :
                            flag *= new RCI(false);
                            goto End;
                    }

                    break;
                default :
                    switch (value.value[i])
                    {
                        case '0' :
                            flag *= new RCI(true);
                            goto End;
                        case '1' :
                            flag *= new RCI(true);
                            goto End;
                        case '2' :
                            flag *= new RCI(true);
                            goto End;
                        case '3' :
                            flag *= new RCI(true);
                            goto End;
                        case '4' :
                            flag *= new RCI(true);
                            goto End;
                        case '5' :
                            flag *= new RCI(true);
                            goto End;
                        case '6' :
                            flag *= new RCI(true);
                            goto End;
                        case '7' :
                            flag *= new RCI(true);
                            goto End;
                        case '8' :
                            flag *= new RCI(true);
                            goto End;
                        case '9' :
                            flag *= new RCI(true);
                            goto End;
                        default :
                            flag *= new RCI(false);
                            goto End;
                    }

                    break;
            }

        Sign:
        return new RCI(false);

        End:
        return flag;
    }

    public static RCI EtoCifra(str64 value)
    {
        RCI flag = new RCI(true);
        if (value.value.Length == 0)
        {
            goto Sign;
        }

        if ((value.value.Length == 1) & ((value.value[0] == '+') | (value.value[0] == '-')))
        {
            goto Sign;
        }

        for (int i = 0; i < value.value.Length; i++)
            switch (i)
            {
                case 0 when (value.value[i] == '+') | (value.value[i] == '-') :
                    continue;
                case 0 :
                    switch (value.value[i])
                    {
                        case '0' :
                            flag *= new RCI(true);
                            goto End;
                        case '1' :
                            flag *= new RCI(true);
                            goto End;
                        case '2' :
                            flag *= new RCI(true);
                            goto End;
                        case '3' :
                            flag *= new RCI(true);
                            goto End;
                        case '4' :
                            flag *= new RCI(true);
                            goto End;
                        case '5' :
                            flag *= new RCI(true);
                            goto End;
                        case '6' :
                            flag *= new RCI(true);
                            goto End;
                        case '7' :
                            flag *= new RCI(true);
                            goto End;
                        case '8' :
                            flag *= new RCI(true);
                            goto End;
                        case '9' :
                            flag *= new RCI(true);
                            goto End;
                        default :
                            flag *= new RCI(false);
                            goto End;
                    }

                    break;
                default :
                    switch (value.value[i])
                    {
                        case '0' :
                            flag *= new RCI(true);
                            goto End;
                        case '1' :
                            flag *= new RCI(true);
                            goto End;
                        case '2' :
                            flag *= new RCI(true);
                            goto End;
                        case '3' :
                            flag *= new RCI(true);
                            goto End;
                        case '4' :
                            flag *= new RCI(true);
                            goto End;
                        case '5' :
                            flag *= new RCI(true);
                            goto End;
                        case '6' :
                            flag *= new RCI(true);
                            goto End;
                        case '7' :
                            flag *= new RCI(true);
                            goto End;
                        case '8' :
                            flag *= new RCI(true);
                            goto End;
                        case '9' :
                            flag *= new RCI(true);
                            goto End;
                        default :
                            flag *= new RCI(false);
                            goto End;
                    }

                    break;
            }

        Sign:
        return new RCI(false);

        End:
        return flag;
    }

    public RCI EtoDrob()
    {
        string [] value = Convert.ToString(this.value).Split(".");
        switch (value.Length)
        {
            case 0 :
                goto End;
            case 1 when str10.EtoCifra(value[0]) :
                goto Success;
            case 1 :
                goto End;
            case 2 when str10.EtoCifra((string)value[0]) :
            {
                if (str10.EtoCifra((string)value[1]))
                {
                    switch ((((string)value[1])[0] != '+') & (((string)value[1])[0] != '-'))
                    {
                        case true :
                            goto Success;
                        default :
                            goto End;
                    }
                }

                goto End;
            }
            case 2 :
                goto End;
        }

        End:
        return new RCI(false);
        Success:
        return new RCI(true);
    }

    public static RCI EtoDrob(string s)
    {
        string [] value = Convert.ToString(s).Split(".");
        switch (value.Length)
        {
            case 0 :
                goto End;
            case 1 when str10.EtoCifra(value[0]) :
                goto Success;
            case 1 :
                goto End;
            case 2 when str10.EtoCifra((string)value[0]) :
            {
                if (str10.EtoCifra((string)value[1]))
                {
                    switch ((((string)value[1])[0] != '+') & (((string)value[1])[0] != '-'))
                    {
                        case true :
                            goto Success;
                        default :
                            goto End;
                    }
                }

                goto End;
            }
            case 2 :
                goto End;
        }

        End:
        return new RCI(false);
        Success:
        return new RCI(true);
    }

    public static RCI EtoDrob(str10 s)
    {
        string [] value = Convert.ToString(s.value).Split(".");
        switch (value.Length)
        {
            case 0 :
                goto End;
            case 1 when str10.EtoCifra(value[0]) :
                goto Success;
            case 1 :
                goto End;
            case 2 when str10.EtoCifra((string)value[0]) :
            {
                if (str10.EtoCifra((string)value[1]))
                {
                    switch ((((string)value[1])[0] != '+') & (((string)value[1])[0] != '-'))
                    {
                        case true :
                            goto Success;
                        default :
                            goto End;
                    }
                }

                goto End;
            }
            case 2 :
                goto End;
        }

        End:
        return new RCI(false);
        Success:
        return new RCI(true);
    }

    public static RCI EtoDrob(str16 s)
    {
        string [] value = Convert.ToString(s.value).Split(".");
        switch (value.Length)
        {
            case 0 :
                goto End;
            case 1 when str10.EtoCifra(value[0]) :
                goto Success;
            case 1 :
                goto End;
            case 2 when str10.EtoCifra((string)value[0]) :
            {
                if (str10.EtoCifra((string)value[1]))
                {
                    switch ((((string)value[1])[0] != '+') & (((string)value[1])[0] != '-'))
                    {
                        case true :
                            goto Success;
                        default :
                            goto End;
                    }
                }

                goto End;
            }
            case 2 :
                goto End;
        }

        End:
        return new RCI(false);
        Success:
        return new RCI(true);
    }

    public static RCI EtoDrob(str32 s)
    {
        string [] value = Convert.ToString(s.value).Split(".");
        switch (value.Length)
        {
            case 0 :
                goto End;
            case 1 when str10.EtoCifra(value[0]) :
                goto Success;
            case 1 :
                goto End;
            case 2 when str10.EtoCifra((string)value[0]) :
            {
                if (str10.EtoCifra((string)value[1]))
                {
                    switch ((((string)value[1])[0] != '+') & (((string)value[1])[0] != '-'))
                    {
                        case true :
                            goto Success;
                        default :
                            goto End;
                    }
                }

                goto End;
            }
            case 2 :
                goto End;
        }

        End:
        return new RCI(false);
        Success:
        return new RCI(true);
    }

    public static RCI EtoDrob(str64 s)
    {
        string [] value = Convert.ToString(s.value).Split(".");
        switch (value.Length)
        {
            case 0 :
                goto End;
            case 1 when str10.EtoCifra(value[0]) :
                goto Success;
            case 1 :
                goto End;
            case 2 when str10.EtoCifra((string)value[0]) :
            {
                if (str10.EtoCifra((string)value[1]))
                {
                    switch ((((string)value[1])[0] != '+') & (((string)value[1])[0] != '-'))
                    {
                        case true :
                            goto Success;
                        default :
                            goto End;
                    }
                }

                goto End;
            }
            case 2 :
                goto End;
        }

        End:
        return new RCI(false);
        Success:
        return new RCI(true);
    }
}