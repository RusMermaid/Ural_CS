#region

using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

#endregion

namespace Datatypes.Collections;

public class spisok : VOID, IEnumerable, /*Interface_UCollection*/ Interface_Ural_Datatype
{
    public ulong MaxLength = 1024U;
    private static ulong MaxLimitLength = 18446744073709551615U;
    public natch64 Count = new natch64(0);

    public static explicit operator string(spisok _value) => _value.ToString();

    public static explicit operator str10(spisok _value) => new str10(_value.ToString());

    public static explicit operator str16(spisok _value) => new str16(_value.ToString());

    public static explicit operator str32(spisok _value) => new str32(_value.ToString());

    public static explicit operator str64(spisok _value) => new str64(_value.ToString());


    public static explicit operator spisok(massiv<Type> _value) => new spisok((ArrayList)_value.value);

    public static explicit operator spisok(kortezh _value) => new spisok((ArrayList)_value.value);

    public static explicit operator spisok(ArrayList _value) => new spisok(ParamsValidation(_value));

    public static explicit operator ArrayList(spisok _value) => (ArrayList)_value.value;

    public spisok()
    {
        this.value = new ArrayList();
        this.value.Capacity = this.MaxLength;
    }

    public spisok(string _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new str64(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(bool _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new RCI(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(int _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new celch32(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(long _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch64(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(ushort _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch16(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(uint _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch32(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(ulong _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch64(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(natch16 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch16(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(natch32 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch32(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(natch64 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch64(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(double _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new drobch64(_value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(celch16 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new celch16(_value.value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(celch32 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new celch32(_value.value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(celch64 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new celch64(_value.value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(drobch16 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new drobch16(_value.value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(drobch32 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new drobch32(_value.value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    public spisok(drobch64 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new drobch64(_value.value) };
        }
        else
        {
            this.value = new SpisokOutOfRangeError(0, 0);
        }
    }

    protected static dynamic [] ParamsValidation(dynamic [] param)
    {
        for (int i = 0; i < param.Length; i++)
            switch (param[i])
            {
                case spisok :
                case massiv<Type> :
                    param[i] = new spisok(ParamsValidation((dynamic [])param[i]));
                    break;
                case kortezh :
                    param[i] = new kortezh(ParamsValidation((dynamic [])param[i]));
                    break;
                default :
                {
                    if (param[i].GetType().IsArray | param[i] is IList)
                    {
                        param[i] = new spisok(ParamsValidation((dynamic [])param[i]));
                    }
                    else
                    {
                        switch (param[i])
                        {
                            case bool :
                                param[i] = new RCI((bool)param[i]);
                                break;
                            case string :
                                param[i] = new str64((string)param[i]);
                                break;
                            case char :
                                param[i] = new str0((char)param[i]);
                                break;
                            case ushort :
                                param[i] = new natch16((ushort)param[i]);
                                break;
                            case uint :
                                param[i] = new natch32((uint)param[i]);
                                break;
                            case ulong :
                                param[i] = new natch64((ulong)param[i]);
                                break;
                            case short :
                                param[i] = new celch16((short)param[i]);
                                break;
                            case int :
                                param[i] = new celch32((int)param[i]);
                                break;
                            case long :
                                param[i] = new celch64((ulong)param[i]);
                                break;
                            case float :
                                param[i] = new drobch32((float)param[i]);
                                break;
                            case double :
                            case decimal :
                                param[i] = new drobch64((double)param[i]);
                                break;
                        }
                    }

                    break;
                }
            }

        return param;
    }

    protected static ArrayList ParamsValidation(ArrayList param)
    {
        for (int i = 0; i < param.Count; i++)
            switch (param[i])
            {
                case spisok :
                case massiv<Type> :
                    param[i] = new spisok(ParamsValidation((ArrayList)param[i]));
                    break;
                case kortezh :
                    param[i] = new kortezh(ParamsValidation((ArrayList)param[i]));
                    break;
                default :
                {
                    switch (param[i].GetType().IsArray | param[i] is IList)
                    {
                        case true :
                            param[i] = new spisok(ParamsValidation((ArrayList)param[i]));
                            break;
                        default :
                            switch (param[i])
                            {
                                case bool :
                                    param[i] = new RCI((bool)param[i]);
                                    break;
                                case string :
                                    param[i] = new str64((string)param[i]);
                                    break;
                                case char :
                                    param[i] = new str0((char)param[i]);
                                    break;
                                case ushort :
                                    param[i] = new natch16((ushort)param[i]);
                                    break;
                                case uint :
                                    param[i] = new natch32((uint)param[i]);
                                    break;
                                case ulong :
                                    param[i] = new natch64((ulong)param[i]);
                                    break;
                                case short :
                                    param[i] = new celch16((short)param[i]);
                                    break;
                                case int :
                                    param[i] = new celch32((int)param[i]);
                                    break;
                                case long :
                                    param[i] = new celch64((ulong)param[i]);
                                    break;
                                case float :
                                    param[i] = new drobch32((float)param[i]);
                                    break;
                                case double :
                                case decimal :
                                    param[i] = new drobch64((double)param[i]);
                                    break;
                            }

                            break;
                    }

                    break;
                }
            }

        return param;
    }

    protected static List<dynamic> ParamsValidation(List<dynamic> param)
    {
        for (int i = 0; i < param.Count; i++)
            switch (param[i])
            {
                case spisok :
                case massiv<Type> :
                    param[i] = new spisok(ParamsValidation((List<dynamic>)param[i]));
                    break;
                case kortezh :
                    param[i] = new kortezh(ParamsValidation((List<dynamic>)param[i]));
                    break;
                default :
                {
                    if (param[i].GetType().IsArray | param[i] is IList)
                    {
                        param[i] = new spisok(ParamsValidation((List<dynamic>)param[i]));
                    }
                    else
                    {
                        switch (param[i])
                        {
                            case bool :
                                param[i] = new RCI((bool)param[i]);
                                break;
                            case string :
                                param[i] = new str64((string)param[i]);
                                break;
                            case char :
                                param[i] = new str0((char)param[i]);
                                break;
                            case ushort :
                                param[i] = new natch16((ushort)param[i]);
                                break;
                            case uint :
                                param[i] = new natch32((uint)param[i]);
                                break;
                            case ulong :
                                param[i] = new natch64((ulong)param[i]);
                                break;
                            case short :
                                param[i] = new celch16((short)param[i]);
                                break;
                            case int :
                                param[i] = new celch32((int)param[i]);
                                break;
                            case long :
                                param[i] = new celch64((ulong)param[i]);
                                break;
                            case float :
                                param[i] = new drobch32((float)param[i]);
                                break;
                            case double :
                            case decimal :
                                param[i] = new drobch64((double)param[i]);
                                break;
                        }
                    }

                    break;
                }
            }

        return param;
    }

    protected static dynamic ParamsValidation(dynamic param)
    {
        for (int i = 0; i < (int)param.Count; i++)
            if (param is spisok || param[i] is massiv<Type>)
            {
                param = new spisok(ParamsValidation((List<dynamic>)param));
            }
            else
            {
                switch (param[i])
                {
                    case kortezh :
                        param = new kortezh(ParamsValidation((List<dynamic>)param));
                        break;
                    default :
                    {
                        if (param.GetType().IsArray | param is IList)
                        {
                            param = new spisok(ParamsValidation((List<dynamic>)param));
                        }
                        else
                        {
                            switch (param)
                            {
                                case bool b :
                                    param = new RCI(b);
                                    break;
                                case string s :
                                    param = new str64(s);
                                    break;
                                case char c :
                                    param = new str0(c);
                                    break;
                                case ushort @ushort :
                                    param = new natch16(@ushort);
                                    break;
                                case uint u :
                                    param = new natch32(u);
                                    break;
                                case ulong @ulong :
                                    param = new natch64(@ulong);
                                    break;
                                case short s :
                                    param = new celch16(s);
                                    break;
                                case int i1 :
                                    param = new celch32(i1);
                                    break;
                                case long :
                                    param = new celch64((ulong)param);
                                    break;
                                case float f :
                                    param = new drobch32(f);
                                    break;
                                case double :
                                case decimal :
                                    param = new drobch64((double)param);
                                    break;
                            }
                        }

                        break;
                    }
                }
            }

        return param;
    }


    //Array Overloads

    public spisok(params dynamic [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation(_value));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation(_value));
        }
    }

    public spisok(spisok _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation((ArrayList)_value.value));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation((ArrayList)_value.value));
        }
    }

    public spisok(massiv<Type> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation((ArrayList)_value.value));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation((ArrayList)_value.value));
        }
    }

    public spisok(kortezh _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation((ArrayList)_value.value));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation((ArrayList)_value.value));
        }
    }

    public spisok(ArrayList _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation(_value));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation(_value));
        }
    }

    public spisok(string [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new str64(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new str64(c)));
        }
    }

    public spisok(List<string> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new str64(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new str64(c)));
        }
    }

    public spisok(bool [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new RCI(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new RCI(c)));
        }
    }

    public spisok(List<bool> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new RCI(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new RCI(c)));
        }
    }

    public spisok(short [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch16(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch16(c)));
        }
    }

    public spisok(List<short> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch16(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch16(c)));
        }
    }

    public spisok(int [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch32(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch32(c)));
        }
    }

    public spisok(List<int> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch32(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch32(c)));
        }
    }

    public spisok(long [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch64(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch64(c)));
        }
    }

    public spisok(List<long> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch64(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch64(c)));
        }
    }

    public spisok(List<ushort> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch16(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch16(c)));
        }
    }

    public spisok(List<uint> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch32(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch32(c)));
        }
    }

    public spisok(ulong [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch64(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch64(c)));
        }
    }

    public spisok(List<ulong> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch64(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch64(c)));
        }
    }

    public spisok(float [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch32(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch32(c)));
        }
    }

    public spisok(List<float> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch32(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch32(c)));
        }
    }

    public spisok(double [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch64(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch64(c)));
        }
    }

    public spisok(List<double> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch64(c)));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch64(c)));
        }
    }

    public spisok(List<dynamic> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation(_value));
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation(_value));
        }
    }

    public spisok(VOID [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<VOID> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(str0 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<str0> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(str10 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<str10> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(str16 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<str16> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(str32 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<str32> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(str64 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<str64> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(natch16 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<natch16> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(natch32 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<natch32> _value) : base(_value)
    {
        this.value.Capacity = this.MaxLength;
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(natch64 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<natch64> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(celch16 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<celch16> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(celch32 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<celch32> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(celch64 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<celch64> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(drobch16 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<drobch16> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(drobch32 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<drobch32> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(drobch64 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public spisok(List<drobch64> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else
        {
            this.MaxLength *= 2;
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
    }

    public dynamic this[int index]
    {
        get => this.value[index];
        set => this.value[index] = value;
    }

    public dynamic this[ushort index]
    {
        get => this.value[index];
        set => this.value[index] = value;
    }

    public dynamic this[uint index]
    {
        get => this.value[index];
        set => this.value[index] = value;
    }

    public dynamic this[ulong index]
    {
        get => this.value[index];
        set => this.value[index] = value;
    }

    public dynamic this[natch16 index]
    {
        get => this.value[index.value];
        set => this.value[index] = value;
    }

    public dynamic this[natch32 index]
    {
        get => this.value[index.value];
        set => this.value[index] = value;
    }

    public dynamic this[natch64 index]
    {
        get => this.value[index.value];
        set => this.value[index] = value;
    }

    public spisok this[int start, int stop] => new spisok(Slice(this.value.ToArray(), start, stop));

    public spisok this[int start, natch16 stop] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value));

    public spisok this[int start, natch32 stop] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value));

    public spisok this[int start, natch64 stop] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value));

    public spisok this[natch16 start, int stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop));

    public spisok this[natch16 start, natch16 stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public spisok this[natch16 start, natch32 stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public spisok this[natch16 start, natch64 stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public spisok this[natch32 start, int stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop));

    public spisok this[natch32 start, natch16 stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public spisok this[natch32 start, natch32 stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public spisok this[natch32 start, natch64 stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public spisok this[natch64 start, int stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop));

    public spisok this[natch64 start, natch16 stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public spisok this[natch64 start, natch32 stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public spisok this[natch64 start, natch64 stop] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public spisok this[int start, int stop, int step] => new spisok(Slice(this.value.ToArray(), start, stop, step));

    public spisok this[int start, int stop, natch16 step] => new spisok(Slice(this.value.ToArray(), start, stop, (int)step.value));

    public spisok this[int start, int stop, natch32 step] => new spisok(Slice(this.value.ToArray(), start, stop, (int)step.value));

    public spisok this[int start, int stop, natch64 step] => new spisok(Slice(this.value.ToArray(), start, stop, (int)step.value));

    public spisok this[int start, natch16 stop, int step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, step));

    public spisok this[int start, natch16 stop, natch16 step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public spisok this[int start, natch16 stop, natch32 step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public spisok this[int start, natch16 stop, natch64 step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public spisok this[int start, natch32 stop, int step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, step));

    public spisok this[int start, natch32 stop, natch16 step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public spisok this[int start, natch32 stop, natch32 step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public spisok this[int start, natch32 stop, natch64 step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public spisok this[int start, natch64 stop, int step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, step));

    public spisok this[int start, natch64 stop, natch16 step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public spisok this[int start, natch64 stop, natch32 step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public spisok this[int start, natch64 stop, natch64 step] => new spisok(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public spisok this[natch16 start, int stop, int step] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop, step));

    public spisok this[natch16 start, int stop, natch16 step] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public spisok this[natch16 start, int stop, natch32 step] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public spisok this[natch16 start, int stop, natch64 step] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public spisok this[natch16 start, natch16 stop, int step] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));

    public spisok this[natch16 start, natch16 stop, natch16 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch16 start, natch16 stop, natch32 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch16 start, natch16 stop, natch64 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch16 start, natch32 stop, int step] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));

    public spisok this[natch16 start, natch32 stop, natch16 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch16 start, natch32 stop, natch32 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch16 start, natch32 stop, natch64 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch16 start, natch64 stop, int step] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));

    public spisok this[natch16 start, natch64 stop, natch16 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch16 start, natch64 stop, natch32 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch16 start, natch64 stop, natch64 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch32 start, int stop, int step] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop, step));

    public spisok this[natch32 start, int stop, natch16 step] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public spisok this[natch32 start, int stop, natch32 step] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public spisok this[natch32 start, int stop, natch64 step] => new spisok(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public spisok this[natch32 start, natch16 stop, int step] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));

    public spisok this[natch32 start, natch16 stop, natch16 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch32 start, natch16 stop, natch32 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch32 start, natch16 stop, natch64 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public spisok this[natch32 start, natch32 stop, int step] => new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));

    public spisok this[natch32 start, natch32 stop, natch16 step] =>
        new spisok(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < (int)this.Count; i++) yield return (Type)this.value[i];
    }

    public SpisokOutOfRangeError? ___Add(dynamic el)
    {
        if ((this.Count + 1 > this.MaxLength) & (this.Count + 1 < ((MaxLimitLength - 1) / 2) - 1))
        {
            if (2 * (this.Count + 1) > ((MaxLimitLength - 1) / 2) - 1)
            {
                this.MaxLength = ((MaxLimitLength - 1) / 2) - 1;
                SpisokOutOfRangeError err = new SpisokOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            this.MaxLength = (ulong)(2 * (this.Count + el.Count));
            this.value.Add(ParamsValidation(el));
            return null;
        }

        this.value.Add(ParamsValidation(el));
        return null;
    }

    public SpisokOutOfRangeError? ___Add(in IList el)
    {
        if ((this.Count + el.Count > this.MaxLength) &
            (this.Count + el.Count < ((MaxLimitLength - 1) / 2) - 1))
        {
            if (2 * (this.Count + el.Count) > ((MaxLimitLength - 1) / 2) - 1)
            {
                this.MaxLength = ((MaxLimitLength - 1) / 2) - 1;
                SpisokOutOfRangeError err = new SpisokOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            this.MaxLength = (ulong)(2 * (this.Count + el.Count));
            this.value.Add(ParamsValidation(el));
            return null;
        }

        this.value.Add(ParamsValidation(el));
        return null;
    }

    public SpisokOutOfRangeError? ___Add(in Array el)
    {
        if ((this.Count + el.Length > this.MaxLength) &
            (this.Count + el.Length < ((MaxLimitLength - 1) / 2) - 1))
        {
            if (2 * (this.Count + el.Length) > ((MaxLimitLength - 1) / 2) - 1)
            {
                this.MaxLength = ((MaxLimitLength - 1) / 2) - 1;
                SpisokOutOfRangeError err = new SpisokOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            this.MaxLength = (ulong)(2 * (this.Count + el.Length));
            this.value.Add(ParamsValidation(el));
            return null;
        }

        this.value.Add(ParamsValidation(el));
        return null;
    }

    public SpisokOutOfRangeError? ___Add(in VOID el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            SpisokOutOfRangeError err = new SpisokOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.Add(ParamsValidation(el));
        return null;
    }

    public SpisokOutOfRangeError? ___Add(massiv<Type> el)
    {
        if ((this.Count + el.Count > this.MaxLength) &
            (this.Count + el.Count < ((MaxLimitLength - 1) / 2) - 1))
        {
            if (2 * (this.Count + el.Count) > ((MaxLimitLength - 1) / 2) - 1)
            {
                this.MaxLength = ((MaxLimitLength - 1) / 2) - 1;
                SpisokOutOfRangeError err = new SpisokOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            this.MaxLength = (ulong)(2 * (this.Count + el.Count));
            this.value.Add(ParamsValidation(el));
            return null;
        }

        this.value.Add(ParamsValidation(el));
        return null;
    }

    public SpisokOutOfRangeError? ___Add(spisok el)
    {
        if ((this.Count + el.Count > this.MaxLength) &
            (this.Count + el.Count < ((MaxLimitLength - 1) / 2) - 1))
        {
            if (2 * (this.Count + el.Count) > ((MaxLimitLength - 1) / 2) - 1)
            {
                this.MaxLength = ((MaxLimitLength - 1) / 2) - 1;
                SpisokOutOfRangeError err = new SpisokOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            this.MaxLength = (ulong)(2 * (this.Count + el.Count));
            this.value.Add(ParamsValidation(el));
            return null;
        }

        this.value.Add(ParamsValidation(el));
        return null;
    }


    public static dynamic Slice(dynamic [] _value, int start)
    {
        switch ((start >= 0u) & (start <= _value.Length))
        {
            case true :
                return _value.Skip(start).ToArray();
            default :
            {
                SpisokOutOfRangeError err = new SpisokOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public static dynamic Slice(dynamic [] _value, int start, int end)
    {
        switch ((start >= 0u) & (start <= _value.Length) & (end >= 0u) & (end <= _value.Length) &
                (start <= end))
        {
            case true :
                return _value.Skip(start).Take(end - start).ToArray();
            default :
            {
                if (start > end)
                {
                    return Reverse(_value.Skip(start).Take(end - start).ToArray());
                }

                SpisokOutOfRangeError err = new SpisokOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }

    public static dynamic Slice(dynamic [] data, int start, int end, int step)
    {
        switch ((start >= 0) & (start <= data.Length) & (end >= 0) & (end <= data.Length) & (start <= end))
        {
            case true :
                return data.Skip(start).Take(end - start).Where(predicate: (val, index) => index % step == 0).ToArray();
            default :
            {
                if (start > end)
                {
                    return Reverse(data.Skip(end).Take(start - end).Where(predicate: (val, index) => index % step == 0).ToArray());
                }

                SpisokOutOfRangeError err = new SpisokOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }
        }
    }


    public spisok Rolling(Func<double, double, double> f)
    {
        double [] data = { this.value.ToArray().Select(new Func<object, double>(i => (double)i)) };
        IEnumerable<double>? windows = Enumerable.Range(0, data.Length - 1)
            .Select(selector: i => data.Skip(i).Take(2).Select(selector: x => x).ToArray()).Select(selector: x => x.Aggregate(f));
        return new spisok(windows.Select(selector: i => new drobch64(i)).ToArray());
    }

    public spisok Rolling(int h, Func<double, double, double> f)
    {
        double [] data = { this.value.ToArray().Select(new Func<object, double>(i => (double)i)) };
        IEnumerable<double>? windows = Enumerable.Range(0, data.Length - h + 1)
            .Select(selector: i => data.Skip(i).Take(h).Select(selector: x => x).ToArray()).Select(selector: x => x.Aggregate(f));
        return new spisok(windows.Select(selector: i => new drobch64(i)).ToArray());
    }

    public spisok Rolling(int h, ulong min_periods, Func<double, double, double> f)
    {
        double [] data = { this.value.ToArray().Select(new Func<object, double>(i => (double)i)) };
        IEnumerable<double>? windows = Enumerable.Range(0, data.Length - h + 1)
            .Select(selector: i => data.Skip(i).Take(h).Select(selector: x => x).ToArray())
            .Where(predicate: x => (ulong)x.Count() >= min_periods).Select(selector: x => x.Aggregate(f));
        return new spisok(windows.Select(selector: i => new drobch64(i)).ToArray());
    }

    public override string ToString() => this.ToString();

    public string ToString(string left_b = "[", string right_b = "]", string sep = ",", string str = "\"")
    {
        string _out = left_b;
        for (int i = 0; i < this.value.Count; i++)
        {
            switch (this.value[i])
            {
                case spisok :
                    _out += this.value[i].ToString(left_b, right_b, sep);
                    break;
                case massiv<Type> :
                    _out += new spisok(this.value[i]).ToString(left_b, right_b, sep);
                    break;
                case kortezh :
                    _out += new kortezh(this.value[i]).ToString(left_b, right_b, sep);
                    break;
                case matrica :
                    _out += "\n" + this.value[i].ToString();
                    break;
                default :
                {
                    if (this.value[i].GetType().IsArray | this.value[i] is IList)
                    {
                        _out += new spisok(this.value[i]).ToString(left_b, right_b, sep);
                    }
                    else
                    {
                        _out += this.value[i] switch
                        {
                            bool => new RCI(this.value[i]),
                            _ => (this.value[i] is string | this.value[i] is str0 | this.value[i] is str10 |
                                  this.value[i] is str16 | this.value[i] is str32 |
                                  this.value[i] is str64) switch
                            {
                                true => $"{str}{this.value[i]}{str}",
                                _ => this.value[i].ToString()
                            }
                        };
                    }

                    break;
                }
            }

            if (i != this.value.Count - 1)
            {
                _out += $"{sep} ";
            }
            else
            {
                switch (this.value[i])
                {
                    case matrica :
                        _out += "\n";
                        break;
                }
            }
        }

        return _out + right_b;
    }
}