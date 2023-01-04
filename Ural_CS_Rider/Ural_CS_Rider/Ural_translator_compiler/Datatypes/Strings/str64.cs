using Ural_CS_Rider.Ural_translator_compiler.Errors;
using Ural_CS_Rider.Ural_translator_compiler.Errors.SyntaxInvalidError;
using Ural_CS_Rider.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes;
using Ural_CS_Rider.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOverloadDatatype;
using Ural_CS_Rider.Ural_translator_compiler.Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

namespace Ural_CS_Rider.Ural_translator_compiler.Datatypes.Strings
{
    public class str64 : VOID
    {
        public const ulong MaxLength = 18446744073709551615U;
        public const string DefaultValue = "";
        public readonly natch64 Len;

        public str64(string _value = "") : base(_value)
        {
            this.value = Convert.ToString(_value);
            this.Len = new natch64(this.value.Length);
        }
        
        public str64(char _value) : base(_value)
        {
            this.value = Convert.ToString(_value);
            this.Len = new natch64(this.value.Length);
        }
        
        public str64(str0 _value) : base(_value)
        {
            this.value = Convert.ToString(_value.value);
            this.Len = new natch64(this.value.Length);
        }
        
        public str64(str10 _value ) : base(_value)
        {
            this.value = _value.value;
            this.Len = new natch64(this.value.Length);
        }
        
        public str64(str16 _value ) : base(_value)
        {
            this.value = _value.value;
            this.Len = new natch64(this.value.Length);
        }
        
        public str64(str32 _value ) : base(_value)
        {
            this.value = _value.value;
            this.Len = new natch64(this.value.Length);
        }
        
        public str64(str64 _value ) : base(_value)
        {
            this.value = _value.value;
            this.Len = new natch64(this.value.Length);
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

        public str64 this[int start, int stop]
        {
            get => new str64(Slice((string)this.value, start, stop));
        }

        public str64 this[int start, natch16 stop]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value));
        }

        public str64 this[int start, natch32 stop]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value));
        }

        public str64 this[int start, natch64 stop]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value));
        }

        public str64 this[natch16 start, int stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop));
        }

        public str64 this[natch16 start, natch16 stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));
        }

        public str64 this[natch16 start, natch32 stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));
        }

        public str64 this[natch16 start, natch64 stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));
        }

        public str64 this[natch32 start, int stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop));
        }

        public str64 this[natch32 start, natch16 stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));
        }

        public str64 this[natch32 start, natch32 stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));
        }

        public str64 this[natch32 start, natch64 stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));
        }

        public str64 this[natch64 start, int stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop));
        }

        public str64 this[natch64 start, natch16 stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));
        }

        public str64 this[natch64 start, natch32 stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));
        }

        public str64 this[natch64 start, natch64 stop]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value));
        }

        public str64 this[int start, int stop, int step]
        {
            get => new str64(Slice((string)this.value, start, stop, step));
        }

        public str64 this[int start, int stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, start, stop, (int)step.value));
        }

        public str64 this[int start, int stop, natch32 step]
        {
            get => new str64(Slice((string)this.value, start, stop, (int)step.value));
        }

        public str64 this[int start, int stop, natch64 step]
        {
            get => new str64(Slice((string)this.value, start, stop, (int)step.value));
        }

        public str64 this[int start, natch16 stop, int step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, step));
        }

        public str64 this[int start, natch16 stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));
        }

        public str64 this[int start, natch16 stop, natch32 step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));
        }

        public str64 this[int start, natch16 stop, natch64 step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));
        }

        public str64 this[int start, natch32 stop, int step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, step));
        }

        public str64 this[int start, natch32 stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));
        }

        public str64 this[int start, natch32 stop, natch32 step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));
        }

        public str64 this[int start, natch32 stop, natch64 step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));
        }

        public str64 this[int start, natch64 stop, int step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, step));
        }

        public str64 this[int start, natch64 stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));
        }

        public str64 this[int start, natch64 stop, natch32 step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));
        }

        public str64 this[int start, natch64 stop, natch64 step]
        {
            get => new str64(Slice((string)this.value, start, (int)stop.value, (int)step.value));
        }

        public str64 this[natch16 start, int stop, int step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop, step));
        }

        public str64 this[natch16 start, int stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));
        }

        public str64 this[natch16 start, int stop, natch32 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));
        }

        public str64 this[natch16 start, int stop, natch64 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));
        }

        public str64 this[natch16 start, natch16 stop, int step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, step));
        }

        public str64 this[natch16 start, natch16 stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch16 start, natch16 stop, natch32 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch16 start, natch16 stop, natch64 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch16 start, natch32 stop, int step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, step));
        }

        public str64 this[natch16 start, natch32 stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch16 start, natch32 stop, natch32 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch16 start, natch32 stop, natch64 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch16 start, natch64 stop, int step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, step));
        }

        public str64 this[natch16 start, natch64 stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch16 start, natch64 stop, natch32 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch16 start, natch64 stop, natch64 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch32 start, int stop, int step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop, step));
        }

        public str64 this[natch32 start, int stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));
        }

        public str64 this[natch32 start, int stop, natch32 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));
        }

        public str64 this[natch32 start, int stop, natch64 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, stop, (int)step.value));
        }

        public str64 this[natch32 start, natch16 stop, int step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, step));
        }

        public str64 this[natch32 start, natch16 stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch32 start, natch16 stop, natch32 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch32 start, natch16 stop, natch64 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }

        public str64 this[natch32 start, natch32 stop, int step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, step));
        }

        public str64 this[natch32 start, natch32 stop, natch16 step]
        {
            get => new str64(Slice((string)this.value, (int)start.value, (int)stop.value, (int)step.value));
        }
        
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
        
        public static explicit operator string(str64 str)
        {
            return (string)str.value;
        }
        
        public dynamic ___Add(dynamic _value)
        {
            if (VOID.IsNumericFull(_value))
            {
                return new SyntaxInvalidOverloadStrNumericError(0, 0);
            }
            else if (_value is str0)
            {
                return this.___Add(_value.ToString());
            }
            else
            {
                string str = this.value + Convert.ToString(_value);
                if ((ulong)str.Length < str64.MaxLength)
                {
                    return new str64(str);
                }
                else
                {
                    return new Str64OutOfRangeError(0, 0);
                }
            }
        }
        
        public dynamic ___Add(string _value)
        {
            string str = this.value + Convert.ToString(_value);
            if (str.Length < str10.MaxLength)
            {
                return new str10(str);
            }
            else if ((str.Length >= str10.MaxLength) & (str.Length < str16.MaxLength))
            {
                return new str16(str);
            }
            else if ((str.Length >= str16.MaxLength) & (str.Length < str32.MaxLength))
            {
                return new str32(str);
            }
            else if ((str.Length >= str32.MaxLength) & ((ulong)str.Length < str64.MaxLength))
            {
                return new str64(str);
            }
            else
            {
                return new Str64OutOfRangeError(0, 0);
            }
        }
        
        public str64 ___Minus(string str2)
        {
            // Convert str1 to a char array
            char[] s = this.value.ToCharArray();

            // Loop through each character in str2
            foreach (char c in str2)
            {
                // Remove c from set1 if it is present
                s = ((string)this.value).Where(val => val != c).ToArray();
            }
            // Create a new string from the remaining characters in set1
            return new str64(new string(s));
        }
        
        public str64 ___Multiply(str10 str)
        {
            List<ulong> cnv = new List<ulong>();

            foreach (char c1 in this.value)
            {
                foreach (char c2 in str.value)
                {
                    cnv.Add(((ulong)c1 * (ulong)c2) / (this.Len + str.Len));
                }
            }

            char[] result = cnv.Select(c => (char)c).ToArray();

            return new str64(new string(result));
        }
        
        public str64 ___Multiply(str16 str)
        {
            List<ulong> cnv = new List<ulong>();

            foreach (char c1 in this.value)
            {
                foreach (char c2 in str.value)
                {
                    cnv.Add(((ulong)c1 * (ulong)c2) / (this.Len + str.Len));
                }
            }

            char[] result = cnv.Select(c => (char)c).ToArray();

            return new str64(new string(result));
        }
        
        public str64 ___Multiply(str32 str)
        {
            List<ulong> cnv = new List<ulong>();

            foreach (char c1 in this.value)
            {
                foreach (char c2 in str.value)
                {
                    cnv.Add(((ulong)c1 * (ulong)c2) / (this.Len + str.Len));
                }
            }

            char[] result = cnv.Select(c => (char)c).ToArray();

            return new str64(new string(result));
        }
        
        public str64 ___Multiply(str64 str)
        {
            List<ulong> cnv = new List<ulong>();

            foreach (char c1 in this.value)
            {
                foreach (char c2 in str.value)
                {
                    cnv.Add((ulong)c1 * (ulong)c2);
                }
            }

            char[] result = cnv.Select(c => (char)c).ToArray();

            return new str64(new string(result));
        }
        
        public dynamic ___Multiply(natch16 _value)
        {
            string str = VOID.StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
            if ((ulong)str.Length < str64.MaxLength)
            {
                return new str64(str);
            }
            else
            {
                return new Str64OutOfRangeError(0, 0);
            }
        }
        
        public dynamic ___Multiply(natch32 _value)
        {
            string str = VOID.StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
            if ((ulong)str.Length < str64.MaxLength)
            {
                return new str64(str);
            }
            else
            {
                return new Str64OutOfRangeError(0, 0);
            }
        }
        
        public dynamic ___Multiply(natch64 _value)
        {
            string str = VOID.StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
            if ((ulong)str.Length < str64.MaxLength)
            {
                return new str64(str);
            }
            else
            {
                return new Str64OutOfRangeError(0, 0);
            }
        }
        
        public dynamic ___Multiply(celch16 _value)
        {
            if (_value.value > 0)
            {
                string str = VOID.StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
                if ((ulong)str.Length < str64.MaxLength)
                {
                    return new str64(str);
                }
                else
                {
                    return new Str64OutOfRangeError(0, 0);
                }
            }
            else
            {
                ulong n = Convert.ToUInt64((-1)*_value.value);
                string str = Convert.ToString(this.value);
                if (n < (ulong)str.Length)
                {
                    str = Slice(str, 0, (ulong)(n+1));
                    str = VOID.StrMultiply(str, n);
                    if ((ulong)str.Length < str64.MaxLength)
                    {
                        return new str64(str);
                    }
                    else
                    {
                        return new Str64OutOfRangeError(0, 0);
                    }
                }
                else
                {
                    return new StrIndexOutOfRangeError(0, 0);
                }
            }
        }
        
        public dynamic ___Multiply(celch32 _value)
        {
            if (_value.value > 0)
            {
                string str = VOID.StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
                if ((ulong)str.Length < str64.MaxLength)
                {
                    return new str64(str);
                }
                else
                {
                    return new Str64OutOfRangeError(0, 0);
                }
            }
            else
            {
                ulong n = Convert.ToUInt64((-1)*_value.value);
                string str = Convert.ToString(this.value);
                if (n < (ulong)str.Length)
                {
                    str = Slice(str, 0, (ulong)(n+1));
                    str = VOID.StrMultiply(str, n);
                    if ((ulong)str.Length < str64.MaxLength)
                    {
                        return new str64(str);
                    }
                    else
                    {
                        return new Str64OutOfRangeError(0, 0);
                    }
                }
                else
                {
                    return new StrIndexOutOfRangeError(0, 0);
                }
            }
        }
        
        public dynamic ___Multiply(celch64 _value)
        {
            if (_value.value > 0)
            {
                string str = VOID.StrMultiply(Convert.ToString(this.value), Convert.ToUInt64(_value.value));
                if ((ulong)str.Length < str64.MaxLength)
                {
                    return new str64(str);
                }
                else
                {
                    return new Str64OutOfRangeError(0, 0);
                }
            }
            else
            {
                ulong n = Convert.ToUInt64((-1)*_value.value);
                string str = Convert.ToString(this.value);
                if (n < (ulong)str.Length)
                {
                    str = Slice(str, 0, (ulong)(n+1));
                    str = VOID.StrMultiply(str, n);
                    if ((ulong)str.Length < str64.MaxLength)
                    {
                        return new str64(str);
                    }
                    else
                    {
                        return new Str64OutOfRangeError(0, 0);
                    }
                }
                else
                {
                    return new StrIndexOutOfRangeError(0, 0);
                }
            }
        }
        
        public str64 Reverse()
        {
            char[] dop = this.value.ToCharArray();
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
            return new string(_value.Where((ch, index) => index % (step) == (0)).ToArray());
        }
        
        public static string Range(str10 _value, int step)
        {
            string value = _value.value;
            return new string(value.Where((ch, index) => index % (step) == (0)).ToArray());
        }
        
        public static string Range(str16 _value, int step)
        {
            string value = _value.value;
            return new string(value.Where((ch, index) => index % (step) == (0)).ToArray());
        }
        
        public static string Range(str32 _value, int step)
        {
            string value = _value.value;
            return new string(value.Where((ch, index) => index % (step) == (0)).ToArray());
        }
        
        public static string Range(str64 _value, int step)
        {
            string value = _value.value;
            return new string(value.Where((ch, index) => index % (step) == (0)).ToArray());
        }
        
        public string Range(int step)
        {
            string value = this.value;
            return new string(value.Where((ch, index) => index % (step) == (0)).ToArray());
        }
        
        public str64 Slice(int start)
        {
            int len = this.value.Length - start;
            return new str64(this.value.Substring(start, len));
        }

        public str64 Slice(int start, int end)
        {
            return new str64(this.value.Substring(start, end - start));
        }

        public str64 Slice(int start, int end, int step)
        {
            string value = this.value.Substring(start, end - start);
            string str_step = new string(value.Where((ch, index) => index % (step) == (0)).ToArray());
            return new str64(str_step);
        }
        public RCI EtoCifra()
        {
            RCI flag = new RCI(true);
            if (this.value.Length == 0)
            {
                goto Sign;
            }
            else if (this.value.Length == 1 & (this.value[0] == '+' | this.value[0] == '-'))
            {
                goto Sign;
            }
            else
            {
                for (int i = 0; i < this.value.Length; i++)
                {
                    if (i == 0)
                    {
                        if (this.value[i] == '+' | this.value[i] == '-')
                        {
                            continue;
                        }
                        else
                        {
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
                                default:
                                    flag *= new RCI(false);
                                    goto End;
                            }
                        }
                    }
                    else
                    {
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
                            default:
                                flag *= new RCI(false);
                                goto End;
                        }
                    }
                }
            }
            Sign:
                return new RCI(false);
            
            End:
                return flag;
        }
        
        public static RCI EtoCifra(string value)
        {
            RCI flag = new RCI(true);
            if (value.Length == 0)
            {
                goto Sign;
            }
            else if (value.Length == 1 & (value[0] == '+' | value[0] == '-'))
            {
                goto Sign;
            }
            else
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (i == 0)
                    {
                        if (value[i] == '+' | value[i] == '-')
                        {
                            continue;
                        }
                        else
                        {
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
                                default:
                                    flag *= new RCI(false);
                                    goto End;
                            }
                        }
                    }
                    else
                    {
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
                            default:
                                flag *= new RCI(false);
                                goto End;
                        }
                    }
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
            else if (value.value.Length == 1 & (value.value[0] == '+' | value.value[0] == '-'))
            {
                goto Sign;
            }
            else
            {
                for (int i = 0; i < value.value.Length; i++)
                {
                    if (i == 0)
                    {
                        if (value.value[i] == '+' | value.value[i] == '-')
                        {
                            continue;
                        }
                        else
                        {
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
                                default:
                                    flag *= new RCI(false);
                                    goto End;
                            }
                        }
                    }
                    else
                    {
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
                            default:
                                flag *= new RCI(false);
                                goto End;
                        }
                    }
                }
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
            else if (value.value.Length == 1 & (value.value[0] == '+' | value.value[0] == '-'))
            {
                goto Sign;
            }
            else
            {
                for (int i = 0; i < value.value.Length; i++)
                {
                    if (i == 0)
                    {
                        if (value.value[i] == '+' | value.value[i] == '-')
                        {
                            continue;
                        }
                        else
                        {
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
                                default:
                                    flag *= new RCI(false);
                                    goto End;
                            }
                        }
                    }
                    else
                    {
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
                            default:
                                flag *= new RCI(false);
                                goto End;
                        }
                    }
                }
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
            else if (value.value.Length == 1 & (value.value[0] == '+' | value.value[0] == '-'))
            {
                goto Sign;
            }
            else
            {
                for (int i = 0; i < value.value.Length; i++)
                {
                    if (i == 0)
                    {
                        if (value.value[i] == '+' | value.value[i] == '-')
                        {
                            continue;
                        }
                        else
                        {
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
                                default:
                                    flag *= new RCI(false);
                                    goto End;
                            }
                        }
                    }
                    else
                    {
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
                            default:
                                flag *= new RCI(false);
                                goto End;
                        }
                    }
                }
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
            else if (value.value.Length == 1 & (value.value[0] == '+' | value.value[0] == '-'))
            {
                goto Sign;
            }
            else
            {
                for (int i = 0; i < value.value.Length; i++)
                {
                    if (i == 0)
                    {
                        if (value.value[i] == '+' | value.value[i] == '-')
                        {
                            continue;
                        }
                        else
                        {
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
                                default:
                                    flag *= new RCI(false);
                                    goto End;
                            }
                        }
                    }
                    else
                    {
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
                            default:
                                flag *= new RCI(false);
                                goto End;
                        }
                    }
                }
            }
            Sign:
                return new RCI(false);
            
            End:
                return flag;
        }

        public RCI EtoDrob()
        {
            string[] value = (Convert.ToString(this.value)).Split(".");
            if (value.Length == 0)
            {
                goto End;
            }
            else if (value.Length == 1)
            {
                if (str10.EtoCifra(value[0]))
                {
                    goto Success;
                }
                else
                {
                    goto End;
                }
            }
            else if (value.Length == 2)
            {
                if (str10.EtoCifra((string)value[0]))
                {
                    if (str10.EtoCifra((string)value[1]))
                    {
                        if ((((string)value[1])[0] != '+') & ((string)value[1])[0] != '-')
                        {
                            goto Success;
                        }
                        else
                        {
                            goto End;
                        }
                    }
                    else
                    {
                        goto End;
                    }
                }
                else
                {
                    goto End;
                }
            }
            End:
                return new RCI(false);
            Success:
                return new RCI(true);
        }
        
        public static RCI EtoDrob(string s)
        {
            string[] value = (Convert.ToString(s)).Split(".");
            if (value.Length == 0)
            {
                goto End;
            }
            else if (value.Length == 1)
            {
                if (str10.EtoCifra(value[0]))
                {
                    goto Success;
                }
                else
                {
                    goto End;
                }
            }
            else if (value.Length == 2)
            {
                if (str10.EtoCifra((string)value[0]))
                {
                    if (str10.EtoCifra((string)value[1]))
                    {
                        if ((((string)value[1])[0] != '+') & ((string)value[1])[0] != '-')
                        {
                            goto Success;
                        }
                        else
                        {
                            goto End;
                        }
                    }
                    else
                    {
                        goto End;
                    }
                }
                else
                {
                    goto End;
                }
            }
            End:
            return new RCI(false);
            Success:
            return new RCI(true);
        }
        
        public static RCI EtoDrob(str10 s)
        {
            string[] value = (Convert.ToString(s.value)).Split(".");
            if (value.Length == 0)
            {
                goto End;
            }
            else if (value.Length == 1)
            {
                if (str10.EtoCifra(value[0]))
                {
                    goto Success;
                }
                else
                {
                    goto End;
                }
            }
            else if (value.Length == 2)
            {
                if (str10.EtoCifra((string)value[0]))
                {
                    if (str10.EtoCifra((string)value[1]))
                    {
                        if ((((string)value[1])[0] != '+') & ((string)value[1])[0] != '-')
                        {
                            goto Success;
                        }
                        else
                        {
                            goto End;
                        }
                    }
                    else
                    {
                        goto End;
                    }
                }
                else
                {
                    goto End;
                }
            }
            End:
            return new RCI(false);
            Success:
            return new RCI(true);
        }
        
        public static RCI EtoDrob(str16 s)
        {
            string[] value = (Convert.ToString(s.value)).Split(".");
            if (value.Length == 0)
            {
                goto End;
            }
            else if (value.Length == 1)
            {
                if (str10.EtoCifra(value[0]))
                {
                    goto Success;
                }
                else
                {
                    goto End;
                }
            }
            else if (value.Length == 2)
            {
                if (str10.EtoCifra((string)value[0]))
                {
                    if (str10.EtoCifra((string)value[1]))
                    {
                        if ((((string)value[1])[0] != '+') & ((string)value[1])[0] != '-')
                        {
                            goto Success;
                        }
                        else
                        {
                            goto End;
                        }
                    }
                    else
                    {
                        goto End;
                    }
                }
                else
                {
                    goto End;
                }
            }
            End:
            return new RCI(false);
            Success:
            return new RCI(true);
        }
        
        public static RCI EtoDrob(str32 s)
        {
            string[] value = (Convert.ToString(s.value)).Split(".");
            if (value.Length == 0)
            {
                goto End;
            }
            else if (value.Length == 1)
            {
                if (str10.EtoCifra(value[0]))
                {
                    goto Success;
                }
                else
                {
                    goto End;
                }
            }
            else if (value.Length == 2)
            {
                if (str10.EtoCifra((string)value[0]))
                {
                    if (str10.EtoCifra((string)value[1]))
                    {
                        if ((((string)value[1])[0] != '+') & ((string)value[1])[0] != '-')
                        {
                            goto Success;
                        }
                        else
                        {
                            goto End;
                        }
                    }
                    else
                    {
                        goto End;
                    }
                }
                else
                {
                    goto End;
                }
            }
            End:
            return new RCI(false);
            Success:
            return new RCI(true);
        }
        
        public static RCI EtoDrob(str64 s)
        {
            string[] value = (Convert.ToString(s.value)).Split(".");
            if (value.Length == 0)
            {
                goto End;
            }
            else if (value.Length == 1)
            {
                if (str10.EtoCifra(value[0]))
                {
                    goto Success;
                }
                else
                {
                    goto End;
                }
            }
            else if (value.Length == 2)
            {
                if (str10.EtoCifra((string)value[0]))
                {
                    if (str10.EtoCifra((string)value[1]))
                    {
                        if ((((string)value[1])[0] != '+') & ((string)value[1])[0] != '-')
                        {
                            goto Success;
                        }
                        else
                        {
                            goto End;
                        }
                    }
                    else
                    {
                        goto End;
                    }
                }
                else
                {
                    goto End;
                }
            }
            End:
            return new RCI(false);
            Success:
            return new RCI(true);
        }
    }
}