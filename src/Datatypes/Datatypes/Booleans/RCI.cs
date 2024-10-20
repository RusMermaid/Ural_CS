namespace Datatypes.Booleans;

public class RCI : VOID, Interface_Ural_Datatype
{
    public const bool DefaultValue = false;

    public const string logop_ne = "НЕ";

    public const string logop_ne_discription =
        "Унитарная операция 'НЕ': возвращает 'ИСТИНА' если 'ЛОЖЬ', иначе возвращает 'ЛОЖЬ' если 'ИСТИНА'.";

    public const string logop_zero = "ЛОЖЬ";
    public const string logop_zero_discription = "Унитарная операция 'ЛОЖЬ': всегда возвращает 'ЛОЖЬ'.";

    public const string logop_nor = "НОР";

    public const string logop_nor_discription =
        "Логическая операция 'НОР' (НЕ ИЛИ): возвращает 'ИСТИНА' тогда и только тогда, когда оба операнда 'ЛОЖЬ'. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_nar = "НАР";

    public const string logop_nar_discription =
        "Логическая операция 'НАР' (ВТОРАЯ ЛОЖЬ): возвращает 'ИСТИНА' тогда и только тогда, когда первый операнд 'ЛОЖЬ', а второй - 'ИСТИНА'. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_ntol = "НТОЛ";

    public const string logop_ntol_discription =
        "Унитарная операция 'НТОЛ' (НЕ ТОЛЬКО): возвращает 'ИСТИНА', когда первый операнд - 'ЛОЖЬ'. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_ar = "АР";

    public const string logop_ar_discription =
        "Логическая операция 'АР' (ПЕРВАЯ ЛОЖЬ / АНТИ ИМПЛИКАЦИЯ): возвращает 'ИСТИНА' тогда и только тогда, когда первый операнд - 'ИСТИНА', а второй - 'ЛОЖЬ'. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_nvop = "НВОП";

    public const string logop_nvop_discription =
        "Унитарная операция 'НВОП' (НЕ ВОПРОС): возвращает 'ИСТИНА' тогда и только тогда, когда второй операнд - 'ЛОЖЬ'. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_xor = "КСОР";

    public const string logop_xor_discription =
        "Логическая операция 'КСОР' (ЭКСКЛЮЗИВНОЕ ИЛИ / АНТИ ЭКВИВАЛЕНТНОСТЬ): возвращает 'ИСТИНА' тогда и только тогда, когда оба операнда не равны друг другу. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_ni = "НИ";

    public const string logop_ni_discription =
        "Логическая операция 'НИ' (НЕ И): возвращает 'ИСТИНА' тогда и только тогда, когда хотя бы один из операндов - 'ЛОЖЬ'. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_i = "И";

    public const string logop_i_discription =
        "Логическая операция 'И' (ЛОГИЧЕСКОЕ УМНОЖЕНИЕ): возвращает 'ИСТИНА' тогда и только тогда, когда оба операнда - 'ИСТИНА'. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_ekv = "ЭКВ";

    public const string logop_ekv_discription =
        "Логическая операция 'ЭКВ' (ЭКВИВАЛЕНТНОСТЬ / ТОЖДЕСТВО / РАВЕНСТВО): возвращает 'ИСТИНА' тогда и только тогда, когда оба операнда равны друг другу. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_vop = "ВОП";

    public const string logop_vop_discription =
        "Унитарная операция 'ВОП' (ЛОГИЧЕСКИЙ ВОПРОС): возвращает 'ИСТИНА' тогда и только тогда, когда второй оператор - 'ИСТИНА'. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_imp = "ИМП";

    public const string logop_imp_discription =
        "Логическая операция 'ИМП' (ИМПЛИКАЦИЯ / ЛОГИЧЕСКОЕ СЛЕДСТВИЕ): возвращает 'ИСТИНА', если оба операнда - 'ИСТИНА', либо первый операнд - 'ЛОЖЬ'. Если первый операнд - 'ИСТИНА', а второй операнд - 'ЛОЖЬ', то возвращает 'ЛОЖЬ'.";

    public const string logop_tol = "ТОЛ";

    public const string logop_tol_discription =
        "Унитарная операция 'ТОЛ' (ЛОГИЧЕСКОЕ ТОЛЬКО): возвращает 'ИСТИНА' тогда и только тогда, когда первый операнд - 'ИСТИНА'. Во всех остальных случаях - 'ЛОЖЬ'.";

    public const string logop_togd = "ТОГД";

    public const string logop_togd_discription =
        "Логическая операция 'ТОГД' (ТОГДА, ЕСЛИ / ИНВЕРСИВНАЯ ИМПЛИКАЦИЯ): возвращает 'ИСТИНА', если оба операнда - 'ЛОЖЬ', либо первый операнд - 'ИСТИНА'. Если первый операнд - 'ЛОЖЬ', а второй операнд - 'ИСТИНА', то возвращает 'ЛОЖЬ'.";

    public const string logop_ili = "ИЛИ";

    public const string logop_ili_discription =
        "Логическая операция 'ИЛИ' (ЛОГИЧЕСКОЕ СЛОЖЕНИЕ): возвращает 'ИСТИНА', если хотя бы один из операндов - 'ИСТИНА'. Если оба операнда - 'ЛОЖЬ', то возвращает 'ЛОЖЬ'.";

    public const string logop_ist = "ИСТ";
    public const string logop_ist_discription = "Унитарная операция 'ИСТИНА': всегда возвращает 'ИСТИНА'.";

    public RCI(string _value) : base(_value)
    {
        this.value = _value switch
        {
            "ИСТИНА" => "ИСТИНА",
            "ЛОЖЬ" => "ЛОЖЬ",
            _ => "ЛОЖЬ"
        };
    }

    public RCI(int _value) : base(_value)
    {
        this.value = _value switch
        {
            1 => "ИСТИНА",
            0 => "ЛОЖЬ",
            _ => "ЛОЖЬ"
        };
    }

    public RCI(short _value) : base(_value)
    {
        this.value = _value switch
        {
            1 => "ИСТИНА",
            0 => "ЛОЖЬ",
            _ => "ЛОЖЬ"
        };
    }

    public RCI(long _value) : base(_value)
    {
        this.value = _value switch
        {
            1 => "ИСТИНА",
            0 => "ЛОЖЬ",
            _ => "ЛОЖЬ"
        };
    }

    public RCI(float _value) : base(_value)
    {
        this.value = _value switch
        {
            1 => "ИСТИНА",
            0 => "ЛОЖЬ",
            _ => "ЛОЖЬ"
        };
    }

    public RCI(double _value) : base(_value)
    {
        this.value = _value switch
        {
            1 => "ИСТИНА",
            0 => "ЛОЖЬ",
            _ => "ЛОЖЬ"
        };
    }

    public RCI(bool _value) : base(_value)
    {
        this.value = _value switch
        {
            true => "ИСТИНА",
            false => "ЛОЖЬ"
        };
    }

    public RCI(RCI _value) : base(_value)
    {
        this.value = _value.value;
    }

    protected bool ConvertToLogicBool() => (string)this.value == "ИСТИНА";

    public static bool operator true(RCI value) => value.ConvertToLogicBool();

    public static bool operator false(RCI value) => !value.ConvertToLogicBool();

    public static implicit operator bool(RCI _value) => (string)_value.value == "ИСТИНА";

    public static implicit operator RCI(bool _value) => new RCI(_value);

    //NE (logical NOT) = логическое отрицание; не.
    public RCI NE() => this ? new RCI(false) : new RCI(true);

    public static RCI NE(bool _value) => _value ? new RCI(false) : new RCI(true);

    public static RCI NE(RCI _value) => _value ? new RCI(false) : new RCI(true);

    public static RCI operator +(RCI l, RCI r) => ILI(l, r);

    public static RCI operator +(RCI l, bool r) => ILI(l, r);

    public static RCI operator *(RCI l, RCI r) => I(l, r);

    public static RCI operator *(RCI l, bool r) => I(l, r);

    public static RCI operator <=(RCI l, RCI r) => IMP(l, r);

    public static RCI operator <=(RCI l, bool r) => IMP(l, r);

    public static RCI operator >=(RCI l, RCI r) => TOGD(l, r);

    public static RCI operator >=(RCI l, bool r) => TOGD(l, r);

    public static RCI operator ^(RCI l, RCI r) => XOR(l, r);

    public static RCI operator ^(RCI l, bool r) => XOR(l, r);

    public static RCI operator |(RCI l, RCI r) => NOR(l, r);

    public static RCI operator |(RCI l, bool r) => NOR(l, r);

    public static RCI operator >(RCI l, RCI r) => NI(l, r);

    public static RCI operator >(RCI l, bool r) => NI(l, r);

    public static RCI operator <(RCI l, RCI r) => AR(l, r);

    public static RCI operator <(RCI l, bool r) => AR(l, r);

    public static RCI operator ~(RCI l) => NE(l);

    public static RCI operator -(RCI l, RCI r) => NAR(l, r);

    public static RCI operator -(RCI l, bool r) => NAR(l, r);

    public static RCI operator ==(RCI l, RCI r) => EKV(l, r);

    public static RCI operator ==(RCI l, bool r) => EKV(l, r);

    public static RCI operator !=(RCI l, RCI r) => XOR(l, r);

    public static RCI operator !=(RCI l, bool r) => XOR(l, r);

    public static RCI operator /(RCI l, RCI r) => TOL(l, r);

    public static RCI operator /(RCI l, bool r) => TOL(l, r);

    //ZERO - только нули
    public RCI ZERO(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public RCI ZERO(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    //NOR - логическое "НЕ ИЛИ"
    public RCI NOR(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public RCI NOR(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    //NAR - вторая ложь
    public RCI NAR(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public RCI NAR(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    //NTOL - логическое "НЕ ТОЛЬКО"
    public RCI NTOL(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public RCI NTOL(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    //AR - первая ложь
    public RCI AR(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public RCI AR(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    //NVOP - логический "НЕ ВОПРОС"
    public RCI NVOP(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public RCI NVOP(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    //XOR - исключительное или
    public RCI XOR(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public RCI XOR(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    //NI - логическое "НЕ И"
    public RCI NI(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public RCI NI(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    //I - логическое "И"
    public RCI I(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public RCI I(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    //EKV - эквивалентность/тождество
    public RCI EKV(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public RCI EKV(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    //VOP - логический вопрос
    public RCI VOP(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public RCI VOP(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    //IMP - импликация
    public RCI IMP(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public RCI IMP(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    //TOL - логическое "ТОЛЬКО"
    public RCI TOL(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public RCI TOL(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    //TOGD - логическое "ТОГДА"
    public RCI TOGD(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public RCI TOGD(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    //ILI - логическое "ИЛИ"
    public RCI ILI(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public RCI ILI(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    //IST - истина
    public RCI IST(bool _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public RCI IST(RCI _value)
    {
        bool bool1 = this.ConvertToLogicBool();
        bool bool2 = _value.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    //
    public static RCI ZERO(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI ZERO(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI ZERO(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI ZERO(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    //
    public static RCI NOR(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NOR(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NOR(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NOR(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    //
    public static RCI NAR(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI NAR(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI NAR(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI NAR(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    //
    public static RCI NTOL(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NTOL(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NTOL(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NTOL(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    //
    public static RCI AR(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI AR(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI AR(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI AR(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    //
    public static RCI NVOP(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NVOP(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NVOP(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NVOP(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    //
    public static RCI XOR(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI XOR(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI XOR(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI XOR(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    //
    public static RCI NI(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NI(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NI(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI NI(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(false),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    //
    public static RCI I(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI I(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI I(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI I(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    //
    public static RCI EKV(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI EKV(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI EKV(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI EKV(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    //
    public static RCI VOP(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI VOP(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI VOP(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI VOP(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    //
    public static RCI IMP(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI IMP(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI IMP(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI IMP(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(false),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    //
    public static RCI TOL(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI TOL(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI TOL(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI TOL(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(false)
                }
            }
        };
    }

    //
    public static RCI TOGD(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI TOGD(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI TOGD(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI TOGD(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(false),
                    _ => new RCI(true)
                }
            }
        };
    }

    //
    public static RCI ILI(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI ILI(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI ILI(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    public static RCI ILI(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(false)
                }
            }
        };
    }

    //
    public static RCI IST(bool _value1, bool _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI IST(bool _value1, RCI _value2)
    {
        bool bool1 = _value1;
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI IST(RCI _value1, bool _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2;
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }

    public static RCI IST(RCI _value1, RCI _value2)
    {
        bool bool1 = _value1.ConvertToLogicBool();
        bool bool2 = _value2.ConvertToLogicBool();
        return (bool1 & bool2) switch
        {
            true => new RCI(true),
            _ => (bool1 & (bool2 == false)) switch
            {
                true => new RCI(true),
                _ => ((bool1 == false) & bool2) switch
                {
                    true => new RCI(true),
                    _ => new RCI(true)
                }
            }
        };
    }
}