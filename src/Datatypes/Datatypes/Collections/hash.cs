namespace Datatypes.Collections;

public class hash<Type1, Type2>
{
    private readonly Dictionary<Type1, Type2> forward;
    private readonly Dictionary<Type2, Type1> backward;

    public hash()
    {
        this.forward = new Dictionary<Type1, Type2>();
        this.backward = new Dictionary<Type2, Type1>();
    }

    public void Add(Type1 key1, Type2 key2)
    {
        if (!this.forward.ContainsKey(key1) && !this.backward.ContainsKey(key2))
        {
            this.forward.Add(key1, key2);
            this.backward.Add(key2, key1);
        }
        else { throw new ArgumentException("Key already exists in the hash."); }
    }

    public KeyValuePair<Type1, Type2> GetByType1(Type1 key1)
    {
        if (this.forward.ContainsKey(key1))
        {
            return new KeyValuePair<Type1, Type2>(key1, this.forward[key1]);
        }

        throw new KeyNotFoundException($"Key '{key1}' not found in the hash.");
    }

    public KeyValuePair<Type2, Type1> GetByType2(Type2 key2)
    {
        if (this.backward.ContainsKey(key2))
        {
            return new KeyValuePair<Type2, Type1>(key2, this.backward[key2]);
        }

        throw new KeyNotFoundException($"Key '{key2}' not found in the hash.");
    }
}