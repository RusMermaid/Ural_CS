using Datatypes.Numbers;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

namespace Datatypes.Collections;

public class kortezh : VOID
{
    public ulong MaxLength = 4294967295U;
    public natch64 Len = new natch64(0);
    
    
    public static explicit operator string(kortezh _value)
    {
        return _value.ToString();
    }
    
    public static explicit operator str10(kortezh _value)
    {
        return new str10(_value.ToString());
    }
    
    public static explicit operator str16(kortezh _value)
    {
        return new str16(_value.ToString());
    }
    
    public static explicit operator str32(kortezh _value)
    {
        return new str32(_value.ToString());
    }
    
    public static explicit operator str64(kortezh _value)
    {
        return new str64(_value.ToString());
    }
    
    public kortezh() : base()
    {
        this.value = new ArrayList();
        this.value.Capacity = this.MaxLength;
    }
    
    public kortezh(string _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new str64(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(bool _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new RCI(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(int _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new celch32(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(long _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new natch64(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(ushort _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new natch16(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(uint _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new natch32(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(ulong _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new natch64(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(natch16 _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new natch16(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(natch32 _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new natch32(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(natch64 _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new natch64(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(double _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new drobch64(_value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(celch16 _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new celch16(_value.value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(celch32 _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new celch32(_value.value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(celch64 _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new celch64(_value.value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(drobch16 _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new drobch16(_value.value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }

    public kortezh(drobch32 _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList { new drobch32(_value.value) };
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }

    public kortezh(drobch64 _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList {new drobch64(_value.value)};
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }

    protected static dynamic[] ParamsValidation(dynamic[] param)
    {
        for (int i = 0; i < param.Length; i++)
        {
            if (param[i] is kortezh)
            {
                param[i] = new kortezh(ParamsValidation((dynamic [])param[i]));
            }
            else if ((param[i].GetType().IsArray) | (param[i] is IList))
            {
                param[i] = new kortezh(ParamsValidation((dynamic [])param[i]));
            }
            else if (param[i] is bool)
            {
                param[i] = new RCI((bool)param[i]);
            }
            else if (param[i] is string)
            {
                param[i] = new str64((string)param[i]);
            }
            else if (param[i] is char)
            {
                param[i] = new str0((char)param[i]);
            }
            else if (param[i] is ushort)
            {
                param[i] = new natch16((ushort)param[i]);
            }
            else if (param[i] is uint)
            {
                param[i] = new natch32((uint)param[i]);
            }
            else if (param[i] is ulong)
            {
                param[i] = new natch64((ulong)param[i]);
            }
            else if (param[i] is short)
            {
                param[i] = new celch16((short)param[i]);
            }
            else if (param[i] is int)
            {
                param[i] = new celch32((int)param[i]);
            }
            else if (param[i] is long)
            {
                param[i] = new celch64((ulong)param[i]);
            }
            else if (param[i] is float)
            {
                param[i] = new drobch32((float)param[i]);
            }
            else if (param[i] is double)
            {
                param[i] = new drobch64((double)param[i]);
            }
            else if (param[i] is decimal)
            {
                param[i] = new drobch64((double)param[i]);
            }
        }

        return param;
    }

    protected static ArrayList ParamsValidation(ArrayList param)
    {
        for (int i = 0; i < param.Count; i++)
        {
            if (param[i] is kortezh)
            {
                param[i] = new kortezh(ParamsValidation((ArrayList)param[i]));
            }
            else if ((param[i].GetType().IsArray) | (param[i] is IList))
            {
                param[i] = new kortezh(ParamsValidation((ArrayList)param[i]));
            }
            else if (param[i] is bool)
            {
                param[i] = new RCI((bool)param[i]);
            }
            else if (param[i] is string)
            {
                param[i] = new str64((string)param[i]);
            }
            else if (param[i] is char)
            {
                param[i] = new str0((char)param[i]);
            }
            else if (param[i] is ushort)
            {
                param[i] = new natch16((ushort)param[i]);
            }
            else if (param[i] is uint)
            {
                param[i] = new natch32((uint)param[i]);
            }
            else if (param[i] is ulong)
            {
                param[i] = new natch64((ulong)param[i]);
            }
            else if (param[i] is short)
            {
                param[i] = new celch16((short)param[i]);
            }
            else if (param[i] is int)
            {
                param[i] = new celch32((int)param[i]);
            }
            else if (param[i] is long)
            {
                param[i] = new celch64((ulong)param[i]);
            }
            else if (param[i] is float)
            {
                param[i] = new drobch32((float)param[i]);
            }
            else if (param[i] is double)
            {
                param[i] = new drobch64((double)param[i]);
            }
            else if (param[i] is decimal)
            {
                param[i] = new drobch64((double)param[i]);
            }
        }

        return param;
    }
    
    protected static List<dynamic> ParamsValidation(List<dynamic> param)
    {
        for (int i = 0; i < param.Count; i++)
        {
            if (param[i] is kortezh)
            {
                param[i] = new kortezh(ParamsValidation((List<dynamic>)param[i]));
            }
            else if ((param[i].GetType().IsArray) | (param[i] is IList))
            {
                param[i] = new kortezh(ParamsValidation((List<dynamic>)param[i]));
            }
            else if (param[i] is bool)
            {
                param[i] = new RCI((bool)param[i]);
            }
            else if (param[i] is string)
            {
                param[i] = new str64((string)param[i]);
            }
            else if (param[i] is char)
            {
                param[i] = new str0((char)param[i]);
            }
            else if (param[i] is ushort)
            {
                param[i] = new natch16((ushort)param[i]);
            }
            else if (param[i] is uint)
            {
                param[i] = new natch32((uint)param[i]);
            }
            else if (param[i] is ulong)
            {
                param[i] = new natch64((ulong)param[i]);
            }
            else if (param[i] is short)
            {
                param[i] = new celch16((short)param[i]);
            }
            else if (param[i] is int)
            {
                param[i] = new celch32((int)param[i]);
            }
            else if (param[i] is long)
            {
                param[i] = new celch64((ulong)param[i]);
            }
            else if (param[i] is float)
            {
                param[i] = new drobch32((float)param[i]);
            }
            else if (param[i] is double)
            {
                param[i] = new drobch64((double)param[i]);
            }
            else if (param[i] is decimal)
            {
                param[i] = new drobch64((double)param[i]);
            }
        }

        return param;
    }
    
    protected static dynamic ParamsValidation(dynamic param)
    {
        for (int i = 0; i < param.Count; i++)
        {
            if (param is kortezh)
            {
                param = new kortezh(ParamsValidation((List<dynamic>)param));
            }
            else if ((param.GetType().IsArray) | (param is IList))
            {
                param = new kortezh(ParamsValidation((List<dynamic>)param));
            }
            else if (param is bool)
            {
                param = new RCI((bool)param);
            }
            else if (param is string)
            {
                param = new str64((string)param);
            }
            else if (param is char)
            {
                param = new str0((char)param);
            }
            else if (param is ushort)
            {
                param = new natch16((ushort)param);
            }
            else if (param is uint)
            {
                param = new natch32((uint)param);
            }
            else if (param is ulong)
            {
                param = new natch64((ulong)param);
            }
            else if (param is short)
            {
                param = new celch16((short)param);
            }
            else if (param is int)
            {
                param = new celch32((int)param);
            }
            else if (param is long)
            {
                param = new celch64((ulong)param);
            }
            else if (param is float)
            {
                param = new drobch32((float)param);
            }
            else if (param is double)
            {
                param = new drobch64((double)param);
            }
            else if (param is decimal)
            {
                param = new drobch64((double)param);
            }
        }

        return param;
    }
    
    
    //Array Overloads
    
    public kortezh(params  dynamic[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(kortezh.ParamsValidation(_value));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(kortezh _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(kortezh.ParamsValidation((ArrayList)_value.value));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(ArrayList _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(kortezh.ParamsValidation(_value));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(string[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new str64(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<string> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new str64(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(bool[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new RCI(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<bool> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new RCI(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(short[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new celch16(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<short> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new celch16(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(int[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new celch32(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<int> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new celch32(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(long[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new celch64(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<long> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new celch64(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<ushort> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new natch16(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<uint> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new natch32(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(ulong[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new natch64(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<ulong> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new natch64(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(float[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new drobch32(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<float> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new drobch32(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(double[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new drobch64(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<double> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(c => new drobch64(c)));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<dynamic> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(kortezh.ParamsValidation(_value));
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(VOID[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<VOID> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(str0[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<str0> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(str10[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<str10> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(str16[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<str16> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(str32[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<str32> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(str64[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<str64> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(natch16[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<natch16> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(natch32[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<natch32> _value) : base(_value)
    {
        this.value.Capacity = this.MaxLength;
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(natch64[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<natch64> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(celch16[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<celch16> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(celch32[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<celch32> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(celch64[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<celch64> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(drobch16[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<drobch16> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(drobch32[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<drobch32> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(drobch64[] _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public kortezh(List<drobch64> _value) : base(_value)
    {
        if (this.Len.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.value = new KortezhOutOfRangeError(0, 0);
        }
    }

    public dynamic this[int index]
    {
        get => (this.value)[index];
        set => this.value[index] = value;
    }

    public dynamic this[ushort index]
    {
        get => (this.value)[index];
        set => this.value[index] = value;
    }

    public dynamic this[uint index]
    {
        get => (this.value)[index];
        set => this.value[index] = value;
    }

    public dynamic this[ulong index]
    {
        get => (this.value)[index];
        set => this.value[index] = value;
    }

    public dynamic this[natch16 index]
    {
        get => (this.value)[index.value];
        set => this.value[index] = value;
    }

    public dynamic this[natch32 index]
    {
        get => (this.value)[index.value];
        set => this.value[index] = value;
    }

    public dynamic this[natch64 index]
    {
        get => (this.value)[index.value];
        set => this.value[index] = value;
    }
    
    public kortezh this[int start, int stop]
        {
            get => new kortezh(Slice(this.value.ToArray(), start, stop));
        }

    public kortezh this[int start, natch16 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value));
    }

    public kortezh this[int start, natch32 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value));
    }

    public kortezh this[int start, natch64 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value));
    }

    public kortezh this[natch16 start, int stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop));
    }

    public kortezh this[natch16 start, natch16 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));
    }

    public kortezh this[natch16 start, natch32 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));
    }

    public kortezh this[natch16 start, natch64 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));
    }

    public kortezh this[natch32 start, int stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop));
    }

    public kortezh this[natch32 start, natch16 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));
    }

    public kortezh this[natch32 start, natch32 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));
    }

    public kortezh this[natch32 start, natch64 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));
    }

    public kortezh this[natch64 start, int stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop));
    }

    public kortezh this[natch64 start, natch16 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));
    }

    public kortezh this[natch64 start, natch32 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));
    }

    public kortezh this[natch64 start, natch64 stop]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));
    }
    
    public kortezh this[int start, int stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, stop, step));
    }

    public kortezh this[int start, int stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, stop, (int)step.value));
    }

    public kortezh this[int start, int stop, natch32 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, stop, (int)step.value));
    }

    public kortezh this[int start, int stop, natch64 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, stop, (int)step.value));
    }

    public kortezh this[int start, natch16 stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, step));
    }

    public kortezh this[int start, natch16 stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));
    }

    public kortezh this[int start, natch16 stop, natch32 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));
    }

    public kortezh this[int start, natch16 stop, natch64 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));
    }

    public kortezh this[int start, natch32 stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, step));
    }

    public kortezh this[int start, natch32 stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));
    }

    public kortezh this[int start, natch32 stop, natch32 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));
    }

    public kortezh this[int start, natch32 stop, natch64 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));
    }

    public kortezh this[int start, natch64 stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, step));
    }

    public kortezh this[int start, natch64 stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));
    }

    public kortezh this[int start, natch64 stop, natch32 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));
    }

    public kortezh this[int start, natch64 stop, natch64 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch16 start, int stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop, step));
    }

    public kortezh this[natch16 start, int stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));
    }

    public kortezh this[natch16 start, int stop, natch32 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));
    }

    public kortezh this[natch16 start, int stop, natch64 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));
    }

    public kortezh this[natch16 start, natch16 stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));
    }

    public kortezh this[natch16 start, natch16 stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch16 start, natch16 stop, natch32 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch16 start, natch16 stop, natch64 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch16 start, natch32 stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));
    }

    public kortezh this[natch16 start, natch32 stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch16 start, natch32 stop, natch32 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch16 start, natch32 stop, natch64 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch16 start, natch64 stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));
    }

    public kortezh this[natch16 start, natch64 stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch16 start, natch64 stop, natch32 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch16 start, natch64 stop, natch64 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch32 start, int stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop, step));
    }

    public kortezh this[natch32 start, int stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));
    }

    public kortezh this[natch32 start, int stop, natch32 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));
    }

    public kortezh this[natch32 start, int stop, natch64 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));
    }

    public kortezh this[natch32 start, natch16 stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));
    }

    public kortezh this[natch32 start, natch16 stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch32 start, natch16 stop, natch32 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch32 start, natch16 stop, natch64 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }

    public kortezh this[natch32 start, natch32 stop, int step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));
    }

    public kortezh this[natch32 start, natch32 stop, natch16 step]
    {
        get => new kortezh(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));
    }
    
    public KortezhOutOfRangeError? ___Add(dynamic el)
    {
        if (this.Len + 1 > this.MaxLength)
        {
            return new KortezhOutOfRangeError(0, 0);
        }
        this.value.Add(kortezh.ParamsValidation(el));
        return null;
    }
    
    public KortezhOutOfRangeError? ___Add(in IList el)
    {
        if (this.Len + el.Count > this.MaxLength)
        {
            return new KortezhOutOfRangeError(0, 0);
        }
        this.value.Add(kortezh.ParamsValidation(el));
        return null;
    }
    
    public KortezhOutOfRangeError? ___Add(in Array el)
    {
        if (this.Len + el.Length > this.MaxLength)
        {
            return new KortezhOutOfRangeError(0, 0);
        }
        this.value.Add(kortezh.ParamsValidation(el));
        return null;
    }
    
    public KortezhOutOfRangeError? ___Add(in VOID el)
    {
        if (this.Len + 1 > this.MaxLength)
        {
            return new KortezhOutOfRangeError(0, 0);
        }
        this.value.Add(kortezh.ParamsValidation(el));
        return null;
    }
    
    public KortezhOutOfRangeError? ___Add(kortezh el)
    {
        if (this.Len + el.Len > this.MaxLength)
        {
            return new KortezhOutOfRangeError(0, 0);
        }
        this.value.Add(kortezh.ParamsValidation(el));
        return null;
    }
    
    public KortezhOutOfRangeError? ___Add(spisok el)
    {
        if (this.Len + el.Len > this.MaxLength)
        {
            return new KortezhOutOfRangeError(0, 0);
        }
        this.value.Add(kortezh.ParamsValidation(el));
        return null;
    }
    
    public  RCI IsMaxLength()
    {
        if (this.Len > new natch64(this.MaxLength))
        {
            return new RCI(true);
        }
        else
        {
            return new RCI(false);
        }
    }
    
    public static dynamic Slice(dynamic[] _value, int start)
    {
        if ((start >= 0u) & (start <= _value.Length))
        {
            return _value.Skip(start).ToArray();
        }
        else
        {
            return new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public static dynamic Slice(dynamic[] _value, int start, int end)
    {
        if ((start >= 0u) & (start <= _value.Length) & (end >= 0u) & (end <= _value.Length) &
            (start <= end))
        {
            return _value.Skip(start).Take(end - start).ToArray();
        }
        else if (start > end)
        {
            return VOID.Reverse(_value.Skip(start).Take(end - start).ToArray());
        }
        else
        {
            return new KortezhOutOfRangeError(0, 0);
        }
    }
    
    public static dynamic Slice(dynamic[] data, int start, int end, int step)
    {
        if ((start >= 0) & (start <= data.Length) & (end >= 0) & (end <= data.Length) & (start <= end))
        {
            return data.Skip(start).Take(end-start).Where((val, index) => index % step == 0).ToArray();
        }
        else if (start > end)
        {
            return Reverse(data.Skip(end).Take(start-end).Where((val, index) => index % step == 0).ToArray());
        }
        else
        {
            return new KortezhOutOfRangeError(0, 0);
        }
    }

    
    public kortezh Rolling(Func<double, double, double> f)
    {
        double [] data = new double [] {this.value.ToArray().Select(new Func<object, double>(i => (double)i))};
        var windows = Enumerable.Range(0, data.Length - 1).Select(i => data.Skip(i).Take(2).Select(x=> (double)x).ToArray()).Select(x => x.Aggregate(f));
        return new kortezh(windows.Select(i => new drobch64(i)).ToArray());
    }
    
    public kortezh Rolling(int h, Func<double, double, double> f)
    {
        double [] data = new double [] {this.value.ToArray().Select(new Func<object, double>(i => (double)i))};
        var windows = Enumerable.Range(0, data.Length - h + 1).Select(i => data.Skip(i).Take(h).Select(x=> (double)x).ToArray()).Select(x => x.Aggregate(f));
        return new kortezh(windows.Select(i => new drobch64(i)).ToArray());
    }
    
    public kortezh Rolling(int h, ulong min_periods, Func<double, double, double> f)
    {
        double [] data = new double [] {this.value.ToArray().Select(new Func<object, double>(i => (double)i))};
        var windows = Enumerable.Range(0, data.Length - h + 1)
            .Select(i => data.Skip(i).Take(h).Select(x=> (double)x).ToArray())
            .Where(x => (ulong)x.Count() >= min_periods).Select(x => x.Aggregate(f));
        return new kortezh(windows.Select(i => new drobch64(i)).ToArray());
    }

    public string ToString(string left_b = "[", string right_b = "]", string sep = ",", string str = "\"")
    {
        string _out = left_b;
        for (int i = 0; i < this.value.Count; i++)
        {
            if (this.value[i] is kortezh)
            {
                _out += this.value[i].ToString(left_b, right_b, sep);
            }
            else if ((this.value[i].GetType().IsArray) | (this.value[i] is IList))
            {
                _out += new kortezh(this.value[i]).ToString(left_b, right_b, sep);
            }
            else if (this.value[i] is bool)
            {
                _out += new RCI(this.value[i]);
            }
            else if ((this.value[i] is string) | (this.value[i] is str0) | (this.value[i] is str10) | (this.value[i] is str16) | (this.value[i] is str32) | (this.value[i] is str64))
            {
                _out += $"{str}{this.value[i]}{str}";
            }
            else
            {
                _out += this.value[i].ToString();
            }
            if (i != this.value.Count - 1)
            {
                _out += $"{sep} ";
            }
        }

        return _out + right_b;
    }
}