#region

using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOverloadDatatype;

#endregion

namespace Datatypes.Collections;

public interface Interface_UCollection
{
    dynamic? ___Add(ushort el);
    dynamic? ___Add(uint el);
    dynamic? ___Add(ulong el);
    dynamic? ___Add(short el);
    dynamic? ___Add(int el);
    dynamic? ___Add(long el);

    dynamic? ___Add(string el);
    dynamic? ___Add(bool el);
    dynamic? ___Add(Array el);

    /*
    dynamic? ___Add(List<Type> el);
    dynamic? ___Add(IList<Type> el);
    */

    //TODO IN OTHER COLLECTIONS!!!
    dynamic? ___Add(in VOID el);
    dynamic? ___Add(natch16 el);
    dynamic? ___Add(natch32 el);
    dynamic? ___Add(natch64 el);
    dynamic? ___Add(celch16 el);
    dynamic? ___Add(celch32 el);
    dynamic? ___Add(celch64 el);
    dynamic? ___Add(drobch16 el);
    dynamic? ___Add(drobch32 el);
    dynamic? ___Add(drobch64 el);

    dynamic? ___Add(binch el);
    dynamic? ___Add(vosch el);
    dynamic? ___Add(shesch el);
    dynamic? ___Add(kvalia el);

    dynamic? ___Add(str0 el);
    dynamic? ___Add(str10 el);
    dynamic? ___Add(str16 el);
    dynamic? ___Add(str32 el);
    dynamic? ___Add(str64 el);
    dynamic? ___Add(RCI el);

    dynamic? ___Add(massiv<Type> el);
    dynamic? ___Add(spisok el);
    dynamic? ___Add(kortezh el);


    RCI IsMaxLength();
}

public class massiv<Type> : VOID, IEnumerable<Type>, Interface_UCollection, Interface_Ural_Datatype
{
    public ulong MaxLength = 4294967295U;
    public natch64 Count = new natch64(0);


    public static explicit operator string(massiv<Type> _value) => _value.ToString();

    public static explicit operator str10(massiv<Type> _value) => new str10(_value.ToString());

    public static explicit operator str16(massiv<Type> _value) => new str16(_value.ToString());

    public static explicit operator str32(massiv<Type> _value) => new str32(_value.ToString());

    public static explicit operator str64(massiv<Type> _value) => new str64(_value.ToString());


    public static explicit operator massiv<Type>(spisok _value) => new massiv<Type>((ArrayList)_value.value);

    public static explicit operator massiv<Type>(kortezh _value) => new massiv<Type>((ArrayList)_value.value);

    public static explicit operator massiv<Type>(ArrayList _value) => new massiv<Type>(ParamsValidation(_value));

    public static explicit operator ArrayList(massiv<Type> _value) => (ArrayList)_value.value;

    public massiv()
    {
        this.value = new ArrayList();
    }

    public massiv(string _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new str64(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(bool _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new RCI(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(int _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new celch32(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(long _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch64(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(ushort _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch16(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(uint _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch32(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(ulong _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch64(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(natch16 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch16(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(natch32 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch32(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(natch64 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new natch64(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(double _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new drobch64(_value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(celch16 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new celch16(_value.value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(celch32 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new celch32(_value.value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(celch64 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new celch64(_value.value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(drobch16 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new drobch16(_value.value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(drobch32 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new drobch32(_value.value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    public massiv(drobch64 _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList { new drobch64(_value.value) };
        }
        else
        {
            this.value = new MassivOutOfRangeError(0, 0);
        }
    }

    protected static dynamic [] ParamsValidation(dynamic [] param)
    {
        for (int i = 0; i < param.Length; i++)
            switch (param[i])
            {
                case massiv<Type> :
                case spisok :
                case kortezh :
                    param[i] = new massiv<Type>(ParamsValidation((dynamic [])param[i]));
                    break;
                default :
                {
                    if (param[i].GetType().IsArray | param[i] is IList)
                    {
                        param[i] = new massiv<Type>(ParamsValidation((dynamic [])param[i]));
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
                case massiv<Type> :
                case spisok :
                    param[i] = new massiv<Type>(ParamsValidation((ArrayList)param[i]));
                    break;
                case kortezh :
                    param[i] = new kortezh(ParamsValidation((ArrayList)param[i]));
                    break;
                default :
                {
                    switch (param[i].GetType().IsArray | param[i] is IList)
                    {
                        case true :
                            param[i] = new massiv<Type>(ParamsValidation((ArrayList)param[i]));
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
                case massiv<Type> :
                case spisok :
                    param[i] = new massiv<Type>(ParamsValidation((List<dynamic>)param[i]));
                    break;
                case kortezh :
                    param[i] = new kortezh(ParamsValidation(param));
                    break;
                default :
                {
                    if (param[i].GetType().IsArray | param[i] is IList)
                    {
                        param[i] = new massiv<Type>(ParamsValidation((List<dynamic>)param[i]));
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
            if (param is massiv<Type> || param[i] is spisok)
            {
                param = new massiv<Type>(ParamsValidation((List<dynamic>)param));
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
                            param = new massiv<Type>(ParamsValidation((List<dynamic>)param));
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

    public massiv(params dynamic [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation(_value));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(massiv<Type> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation((ArrayList)_value.value));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(spisok _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation((ArrayList)_value.value));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(kortezh _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation((ArrayList)_value.value));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(ArrayList _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation(_value));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(string [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new str64(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<string> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new str64(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(bool [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new RCI(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<bool> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new RCI(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(short [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch16(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<short> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch16(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(int [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch32(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<int> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch32(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(long [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch64(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<long> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new celch64(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<ushort> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch16(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<uint> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch32(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(ulong [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch64(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<ulong> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new natch64(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(float [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch32(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<float> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch32(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(double [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch64(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<double> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value.Select(selector: c => new drobch64(c)));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<dynamic> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(ParamsValidation(_value));
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(VOID [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<VOID> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(str0 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<str0> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(str10 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<str10> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(str16 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<str16> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(str32 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<str32> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(str64 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<str64> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(natch16 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<natch16> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(natch32 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<natch32> _value) : base(_value)
    {
        this.value.Capacity = this.MaxLength;
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(natch64 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<natch64> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(celch16 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<celch16> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(celch32 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<celch32> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(celch64 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<celch64> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(drobch16 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<drobch16> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(drobch32 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<drobch32> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(drobch64 [] _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public massiv(List<drobch64> _value) : base(_value)
    {
        if (this.Count.value <= this.MaxLength)
        {
            this.value = new ArrayList();
            this.value.AddRange(_value);
        }
        else { this.value = new MassivOutOfRangeError(0, 0); }
    }

    public dynamic this[int index]
    {
        get => this.value[index];
        set => this.value[index] = value;
    }

    public dynamic this[ushort index]
    {
        get => this.value[(short)index];
        set => this.value[index] = value;
    }

    public dynamic this[uint index]
    {
        get => this.value[(int)index];
        set => this.value[index] = value;
    }

    public dynamic this[ulong index]
    {
        get => this.value[(long)index];
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

    public massiv<Type> this[int start, int stop] => new massiv<Type>(Slice(this.value.ToArray(), start, stop));

    public massiv<Type> this[int start, natch16 stop] => new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value));

    public massiv<Type> this[int start, natch32 stop] => new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value));

    public massiv<Type> this[int start, natch64 stop] => new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value));

    public massiv<Type> this[natch16 start, int stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop));

    public massiv<Type> this[natch16 start, natch16 stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public massiv<Type> this[natch16 start, natch32 stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public massiv<Type> this[natch16 start, natch64 stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public massiv<Type> this[natch32 start, int stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop));

    public massiv<Type> this[natch32 start, natch16 stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public massiv<Type> this[natch32 start, natch32 stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public massiv<Type> this[natch32 start, natch64 stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public massiv<Type> this[natch64 start, int stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop));

    public massiv<Type> this[natch64 start, natch16 stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public massiv<Type> this[natch64 start, natch32 stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public massiv<Type> this[natch64 start, natch64 stop] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value));

    public massiv<Type> this[int start, int stop, int step] => new massiv<Type>(Slice(this.value.ToArray(), start, stop, step));

    public massiv<Type> this[int start, int stop, natch16 step] => new massiv<Type>(Slice(this.value.ToArray(), start, stop, (int)step.value));

    public massiv<Type> this[int start, int stop, natch32 step] => new massiv<Type>(Slice(this.value.ToArray(), start, stop, (int)step.value));

    public massiv<Type> this[int start, int stop, natch64 step] => new massiv<Type>(Slice(this.value.ToArray(), start, stop, (int)step.value));

    public massiv<Type> this[int start, natch16 stop, int step] => new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, step));

    public massiv<Type> this[int start, natch16 stop, natch16 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public massiv<Type> this[int start, natch16 stop, natch32 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public massiv<Type> this[int start, natch16 stop, natch64 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public massiv<Type> this[int start, natch32 stop, int step] => new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, step));

    public massiv<Type> this[int start, natch32 stop, natch16 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public massiv<Type> this[int start, natch32 stop, natch32 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public massiv<Type> this[int start, natch32 stop, natch64 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public massiv<Type> this[int start, natch64 stop, int step] => new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, step));

    public massiv<Type> this[int start, natch64 stop, natch16 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public massiv<Type> this[int start, natch64 stop, natch32 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public massiv<Type> this[int start, natch64 stop, natch64 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), start, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch16 start, int stop, int step] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop, step));

    public massiv<Type> this[natch16 start, int stop, natch16 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public massiv<Type> this[natch16 start, int stop, natch32 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public massiv<Type> this[natch16 start, int stop, natch64 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public massiv<Type> this[natch16 start, natch16 stop, int step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));

    public massiv<Type> this[natch16 start, natch16 stop, natch16 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch16 start, natch16 stop, natch32 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch16 start, natch16 stop, natch64 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch16 start, natch32 stop, int step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));

    public massiv<Type> this[natch16 start, natch32 stop, natch16 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch16 start, natch32 stop, natch32 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch16 start, natch32 stop, natch64 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch16 start, natch64 stop, int step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));

    public massiv<Type> this[natch16 start, natch64 stop, natch16 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch16 start, natch64 stop, natch32 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch16 start, natch64 stop, natch64 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch32 start, int stop, int step] => new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop, step));

    public massiv<Type> this[natch32 start, int stop, natch16 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public massiv<Type> this[natch32 start, int stop, natch32 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public massiv<Type> this[natch32 start, int stop, natch64 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, stop, (int)step.value));

    public massiv<Type> this[natch32 start, natch16 stop, int step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));

    public massiv<Type> this[natch32 start, natch16 stop, natch16 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch32 start, natch16 stop, natch32 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch32 start, natch16 stop, natch64 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public massiv<Type> this[natch32 start, natch32 stop, int step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, step));

    public massiv<Type> this[natch32 start, natch32 stop, natch16 step] =>
        new massiv<Type>(Slice(this.value.ToArray(), (int)start.value, (int)stop.value, (int)step.value));

    public static RCI operator ==(massiv<Type> x, massiv<Type> y) => x.___Equals(y);


    public static RCI operator !=(massiv<Type> x, massiv<Type> y) => x.___Equals(y).NE();

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < (int)this.Count; i++) yield return (Type)this.value[i];
    }

    IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
    {
        for (int i = 0; i < (int)this.Count; i++) yield return (Type)this.value[i];
    }

    public RCI ___Equals(massiv<Type> _value) => ((ArrayList)this.value).Equals((ArrayList)_value.value) ? new RCI(true) : new RCI(false);

    public dynamic? ___Add(short el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(int el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(long el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(ushort el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(uint el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(ulong el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(float el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(double el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(string el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(bool el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(Array el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        try { this.value = (el as List<Type>).AsParallel().Select(selector: inner_el => this.value.Add(ParamsValidation(inner_el ?? inner_el))); }
        catch (Exception er)
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(List<Type> el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        try { this.value = el.AsParallel().Select(selector: inner_el => this.value.Add(ParamsValidation(inner_el ?? inner_el))); }
        catch (Exception er)
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(IList<Type> el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.Add(ParamsValidation(el));
        return null;
    }

    public dynamic? ___Add(natch16 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(natch32 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(natch64 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(celch16 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(celch32 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(celch64 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(drobch16 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(drobch32 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(drobch64 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadStrNumericError err = new SyntaxInvalidOverloadStrNumericError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(str0 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadNumbericStrError err = new SyntaxInvalidOverloadNumbericStrError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(str10 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadNumbericStrError err = new SyntaxInvalidOverloadNumbericStrError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(str16 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadNumbericStrError err = new SyntaxInvalidOverloadNumbericStrError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(str32 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadNumbericStrError err = new SyntaxInvalidOverloadNumbericStrError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(str64 el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadNumbericStrError err = new SyntaxInvalidOverloadNumbericStrError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(RCI el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(VOID el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(dynamic el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.Add(ParamsValidation(el));
        return null;
    }

    public RCI ___Equals(ArrayList _value) => ((ArrayList)this.value).Equals(_value) ? new RCI(true) : new RCI(false);

    public dynamic? ___Add(in IList el)
    {
        if (this.Count + el.Count > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        try { this.value = (el as List<Type>).AsParallel().Select(selector: inner_el => this.value.Add(ParamsValidation(inner_el))); }
        catch (Exception er)
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(in Array el)
    {
        if (this.Count + el.Length > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        try { this.value = (el as List<Type>).AsParallel().Select(selector: inner_el => this.value.Add(ParamsValidation(inner_el))); }
        catch (Exception er)
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(in VOID el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.Add(ParamsValidation(el));
        return null;
    }

    public dynamic? ___Add(massiv<System.Type> el)
    {
        if (this.Count + el.Count > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        try { this.value = ((List<Type>)el.value).AsParallel().Select(selector: inner_el => this.value.Add(ParamsValidation(inner_el))); }
        catch (Exception er)
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(spisok el)
    {
        if (this.Count + el.Count > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        try { this.value = ((List<Type>)el.value).AsParallel().Select(selector: inner_el => this.value.Add(ParamsValidation(inner_el))); }
        catch (Exception er)
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(kortezh el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        try { this.value = ((List<Type>)el.value).AsParallel().Select(selector: inner_el => this.value.Add(ParamsValidation(inner_el))); }
        catch (Exception er)
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(binch el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(vosch el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(shesch el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(kvalia el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Add(Type el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        if (el.GetType() == typeof(Type)) { this.value.Add(ParamsValidation(el)); }
        else if (el is Type [] or IList<Type>)
        {
            foreach (Type inner_el in (IList<Type>)el) this.value.Add(ParamsValidation(inner_el));
        }
        else
        {
            SyntaxInvalidOverloadCastMassivError err = new SyntaxInvalidOverloadCastMassivError(0, 0);
            err.Execute();
        }

        return null;
    }

    public dynamic? ___Dobavit(Type el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.Add(ParamsValidation(el));

        return null;
    }

    public dynamic? ___Dobavit(Type [] el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.Add(ParamsValidation(el));

        return null;
    }

    public dynamic? ___Dobavit(massiv<Type> el)
    {
        if (this.Count + 1 > this.MaxLength)
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.Add(el);

        return null;
    }

    public dynamic? ___Pop()
    {
        if ((this.Count == 0) || (this.value.Count == 0))
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.RemoveAt(this.value.Count - 1);

        return null;
    }

    public dynamic? ___Pop(ushort i)
    {
        if ((this.Count == 0) || (this.value.Count == 0))
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.RemoveAt((int)i);

        return null;
    }

    public dynamic? ___Pop(uint i)
    {
        if ((this.Count == 0) || (this.value.Count == 0))
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.RemoveAt((int)i);

        return null;
    }

    public dynamic? ___Pop(ulong i)
    {
        if ((this.Count == 0) || (this.value.Count == 0))
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.RemoveAt((int)i);

        return null;
    }

    public dynamic? ___Pop(short i)
    {
        if ((this.Count == 0) || (this.value.Count == 0))
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.RemoveAt((int)i);

        return null;
    }

    public dynamic? ___Pop(int i)
    {
        if ((this.Count == 0) || (this.value.Count == 0))
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.RemoveAt(i);

        return null;
    }

    public dynamic? ___Pop(long i)
    {
        if ((this.Count == 0) || (this.value.Count == 0))
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.RemoveAt((int)i);

        return null;
    }

    public dynamic? ___Pop(natch16 i)
    {
        if ((this.Count == 0) || (this.value.Count == 0))
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.RemoveAt((int)i);

        return null;
    }

    public dynamic? ___Pop(natch32 i)
    {
        if ((this.Count == 0) || (this.value.Count == 0))
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.RemoveAt((int)i);

        return null;
    }

    public dynamic? ___Pop(natch64 i)
    {
        if ((this.Count == 0) || (this.value.Count == 0))
        {
            MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
            err.Execute();
        }

        this.value.RemoveAt((int)i);

        return null;
    }

    public RCI IsMaxLength() => this.Count > new natch64(this.MaxLength) ? new RCI(true) : new RCI(false);

    public static dynamic Slice(dynamic [] _value, int start)
    {
        switch ((start >= 0u) & (start <= _value.Length))
        {
            case true :
                return _value.Skip(start).ToArray();
            default :
            {
                MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
                err.Execute();
                return 0;
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

                MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
                err.Execute();
                return 0;
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

                MassivOutOfRangeError err = new MassivOutOfRangeError(0, 0);
                err.Execute();
                return 0;
            }
        }
    }


    public massiv<Type> Rolling(Func<double, double, double> f)
    {
        double [] data = { this.value.ToArray().Select(new Func<object, double>(i => (double)i)) };
        IEnumerable<double>? windows = Enumerable.Range(0, data.Length - 1)
            .Select(selector: i => data.Skip(i).Take(2).Select(selector: x => x).ToArray()).Select(selector: x => x.Aggregate(f));
        return new massiv<Type>(windows.Select(selector: i => new drobch64(i)).ToArray());
    }

    public massiv<Type> Rolling(int h, Func<double, double, double> f)
    {
        double [] data = { this.value.ToArray().Select(new Func<object, double>(i => (double)i)) };
        IEnumerable<double>? windows = Enumerable.Range(0, data.Length - h + 1)
            .Select(selector: i => data.Skip(i).Take(h).Select(selector: x => x).ToArray()).Select(selector: x => x.Aggregate(f));
        return new massiv<Type>(windows.Select(selector: i => new drobch64(i)).ToArray());
    }

    public massiv<Type> Rolling(int h, ulong min_periods, Func<double, double, double> f)
    {
        double [] data = { this.value.ToArray().Select(new Func<object, double>(i => (double)i)) };
        IEnumerable<double>? windows = Enumerable.Range(0, data.Length - h + 1)
            .Select(selector: i => data.Skip(i).Take(h).Select(selector: x => x).ToArray())
            .Where(predicate: x => (ulong)x.Count() >= min_periods).Select(selector: x => x.Aggregate(f));
        return new massiv<Type>(windows.Select(selector: i => new drobch64(i)).ToArray());
    }

    public override string ToString() => this.ToString();

    public string ToString(string left_b = "[", string right_b = "]", string sep = ",", string str = "\"")
    {
        string _out = left_b;
        for (int i = 0; i < this.value.Count; i++)
        {
            switch (this.value[i])
            {
                case massiv<Type> :
                    _out += this.value[i].ToString(left_b, right_b, sep);
                    break;
                case spisok :
                    _out += new massiv<Type>(this.value[i]).ToString(left_b, right_b, sep);
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
                        _out += new massiv<Type>(this.value[i]).ToString(left_b, right_b, sep);
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