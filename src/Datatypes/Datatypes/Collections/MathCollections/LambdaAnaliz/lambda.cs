namespace Datatypes.Collections.MathCollections.LambdaAnaliz;

public class lambda<Type> : VOID
{
    public Func<Type, Type> alpha;
    public Func<Type, Type, Type> alpha2;
    public Func<Type, Type, Type, Type> alpha3;
    public Func<Type, RCI> ffilter;
    public Func<Type, Type, RCI> ffilter2;

    public int MaxLength = 2147483647;
    public massiv<Type> value;

    public lambda(Func<Type, Type> alpha, int length)
    {
        this.alpha = alpha;
        this.MaxLength = length;
    }

    public IEnumerable<Type> GetValues()
    {
        for (uint i = 0; i < this.MaxLength; i++) yield return this.alpha((Type)Convert.ChangeType(i, typeof(Type)));
    }

    public Type this[ushort index]
    {
        get => this.value[index];
        set => this.value[index] = (Type)Convert.ChangeType(value, typeof(Type));
    }

    public Type this[uint index]
    {
        get => this.value[index];
        set => this.value[index] = (Type)Convert.ChangeType(value, typeof(Type));
    }

    public Type this[ulong index]
    {
        get => this.value[index];
        set => this.value[index] = (Type)Convert.ChangeType(value, typeof(Type));
    }

    public Type this[short index]
    {
        get => this.value[index];
        set => this.value[index] = (Type)Convert.ChangeType(value, typeof(Type));
    }

    public Type this[int index]
    {
        get => this.value[index];
        set => this.value[index] = (Type)Convert.ChangeType(value, typeof(Type));
    }

    public Type this[long index]
    {
        get => this.value[(ulong)index];
        set => this.value[(ulong)index] = (Type)Convert.ChangeType(value, typeof(Type));
    }

    public Type this[natch16 index]
    {
        get => this.value[index];
        set => this.value[index] = (Type)Convert.ChangeType(value, typeof(Type));
    }

    public Type this[natch32 index]
    {
        get => this.value[index];
        set => this.value[index] = (Type)Convert.ChangeType(value, typeof(Type));
    }

    public Type this[natch64 index]
    {
        get => this.value[index];
        set => this.value[index] = (Type)Convert.ChangeType(value, typeof(Type));
    }

    public void ___Add(Func<Type, Type> alpha)
    {
        this.alpha = alpha;
    }

    public void ___Add(Func<Type, Type, Type> alpha2)
    {
        this.alpha2 = alpha2;
    }

    public void ___Add(Func<Type, Type, Type, Type> alpha3)
    {
        this.alpha3 = alpha3;
    }

    public void ___Add(Func<Type, RCI> filter)
    {
        this.ffilter = filter;
    }

    public void ___Add(Func<Type, Type, RCI> filter2)
    {
        this.ffilter2 = filter2;
    }

    public massiv<Type> Map()
    {
        this.value = new massiv<Type>(from i in this.value.value.ToArray(typeof(Type)) as Type [] select this.alpha(i));
        return this.value;
    }

    public massiv<Type> Map(Func<Type, Type> mapper)
    {
        this.value = new massiv<Type>(from i in this.value.value.ToArray(typeof(Type)) as Type [] select mapper(i));
        return this.value;
    }

    public massiv<Type> Filter()
    {
        this.value = new massiv<Type>(from i in this.value.value.ToArray(typeof(Type)) as Type [] where this.ffilter(i) select i);
        return this.value;
    }

    public massiv<Type> Filter(Func<Type, bool> filter)
    {
        this.value = new massiv<Type>(from i in this.value.value.ToArray(typeof(Type)) as Type [] where filter(i) select i);
        return this.value;
    }

    public massiv<Type> Filter(Func<Type, RCI> filter)
    {
        this.value = new massiv<Type>(from i in this.value.value.ToArray(typeof(Type)) as Type [] where (bool)filter(i) select i);
        return this.value;
    }

    public massiv<Type> Lambda()
    {
        this.value = new massiv<Type>(from i in this.value.value.ToArray(typeof(Type)) as Type [] where this.ffilter(i) select this.alpha(i));
        return this.value;
    }

    public massiv<Type> Lambda(Func<Type, Type> mapper, Func<Type, bool> filter)
    {
        this.value = new massiv<Type>(from i in this.value.value.ToArray(typeof(Type)) as Type [] where filter(i) select mapper(i));
        return this.value;
    }

    public massiv<Type> Reduce()
    {
        this.value = new massiv<Type>((this.value.value.ToArray(typeof(Type)) as Type []).Aggregate(this.alpha2));
        return this.value;
    }

    public massiv<Type> Reduce(Func<Type, Type, Type> reducer)
    {
        this.value = new massiv<Type>((this.value.value.ToArray(typeof(Type)) as Type []).Aggregate(reducer));
        return this.value;
    }

    public massiv<Type> Reduce(Type accumulator)
    {
        this.value = new massiv<Type>((this.value.value.ToArray(typeof(Type)) as Type []).Aggregate(accumulator, this.alpha2));
        return this.value;
    }

    public massiv<Type> Reduce(Type accumulator, Func<Type, Type, Type> reducer)
    {
        this.value = new massiv<Type>((this.value.value.ToArray(typeof(Type)) as Type []).Aggregate(accumulator, reducer));
        return this.value;
    }

    public static Type_Result F<Type_Result>(Delegate f, params object [] args) => (Type_Result)Convert.ChangeType(f.DynamicInvoke(args), typeof(Type_Result));
}