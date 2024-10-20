#region

using Errors.SyntaxInvalidError.ErrorDatatypes;

#endregion

namespace Datatypes;

public interface Interface_Ural_Datatype
{
}

public class VOID : object, Interface_Ural_Datatype
{
    public dynamic value;
    public dynamic subvalue;

    public VOID(dynamic _value = null, dynamic _subvalue = null)
    {
        if (_value is null)
        {
            _value = "ВОИД";
        }

        this.value = _value;

        if (_subvalue is null)
        {
            _subvalue = "НУЛЛ";
        }

        this.subvalue = _subvalue;
    }

    public static RCI operator ==(in VOID x, in VOID y)
    {
        if (x.value == y.value)
        {
            return new RCI(true);
        }

        dynamic castY = y;
        if ((castY != null) & x.GetType().IsInstanceOfType(castY))
        {
            if (x.value == castY.value)
            {
                return new RCI(true);
            }

            goto failcast;
        }

        failcast:
        return new RCI(false);
    }

    public static RCI operator !=(in VOID x, in VOID y)
    {
        if (x.value != y.value)
        {
            return new RCI(true);
        }

        dynamic castY = y;
        if ((castY != null) & x.GetType().IsInstanceOfType(castY))
        {
            if (x.value != castY.value)
            {
                return new RCI(true);
            }

            goto failcast;
        }

        failcast:
        return new RCI(false);
    }

    public static RCI operator >(in VOID x, in VOID y)
    {
        if (x.value > y.value)
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI operator >(in VOID x, in object y)
    {
        if (x.value > y)
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI operator <(in VOID x, in VOID y)
    {
        if (x.value < y.value)
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI operator <(in VOID x, in object y)
    {
        if (x.value < y)
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public override string ToString() => this.value.ToString();

    protected float trunc(float num) => (float)Math.Truncate(num);

    protected double trunc(double num) => Math.Truncate(num);

    public double pow(double num1, double num2) => Math.Pow(num1, num2);

    public static string Reverse(string text)
    {
        char [] cArray = text.ToCharArray();
        string reverse = string.Empty;
        for (int i = cArray.Length - 1; i > -1; i--) reverse += cArray[i];

        return reverse;
    }

    public static dynamic [] Reverse(dynamic [] data)
    {
        Enumerable.Range(0, (data.Length + 1) / 2).ToList().ForEach(action: i => { (data[i], data[data.Length - 1 - i]) = (data[data.Length - 1 - i], data[i]); });
        return data;
    }


    public static dynamic Slice(string _value, int start)
    {
        if ((start >= 0u) & (start <= _value.Length))
        {
            int len = _value.Length - start;
            return _value.Substring(start, len);
        }

        return new StrIndexOutOfRangeError(0, 0);
    }

    public static dynamic Slice(string _value, int start, int end)
    {
        if ((start >= 0u) & (start <= _value.Length) & (end >= 0u) & (end <= _value.Length) &
            (start <= end))
        {
            return _value.Substring(start, end - start);
        }

        if (start > end)
        {
            return Reverse(_value.Substring(end, end - start));
        }

        return new StrIndexOutOfRangeError(0, 0);
    }

    public static dynamic Slice(string _value, int start, int end, int step)
    {
        if ((start >= 0u) & (start <= _value.Length) & (end >= 0u) & (end <= _value.Length) &
            (start <= end))
        {
            int len = end - start;
            _value = _value.Substring(start, len);
            string str_step = new string(_value.Where(predicate: (ch, index) => index % step == 0).ToArray());
            return str_step;
        }

        if (start > end)
        {
            int len = start - end;
            _value = _value.Substring(start, len);
            string str_step = new string(_value.Where(predicate: (ch, index) => index % step == 0).ToArray());
            return Reverse(str_step);
        }

        return new StrIndexOutOfRangeError(0, 0);
    }


    public static dynamic Slice(string _value, ulong start)
    {
        if ((start >= 0u) & (start <= (ulong)_value.Length))
        {
            string result = "";
            ulong counter = 0;
            foreach (char chr in _value)
            {
                if (counter >= start)
                {
                    result += chr.ToString();
                }

                counter += 1;
            }

            return result;
        }

        return new StrIndexOutOfRangeError(0, 0);
    }

    public static dynamic Slice(string _value, ulong start, ulong end)
    {
        if ((start >= 0u) & (start <= (ulong)_value.Length) & (end >= 0u) & (end <= (ulong)_value.Length) &
            (start <= end))
        {
            string result = "";
            ulong counter = 0;
            if (start <= end)
            {
                foreach (char chr in _value)
                {
                    if ((counter >= start) & (counter < end))
                    {
                        result += chr.ToString();
                    }

                    if (counter > end)
                    {
                        break;
                    }

                    counter += 1;
                }
            }
            else
            {
                foreach (char chr in _value)
                {
                    if ((counter >= end) & (counter < start))
                    {
                        result += chr.ToString();
                    }

                    if (counter > end)
                    {
                        break;
                    }

                    counter += 1;
                }

                result = Reverse(result);
            }

            return result;
        }

        return new StrIndexOutOfRangeError(0, 0);
    }

    public static dynamic Slice(string _value, ulong start, ulong end, ulong step)
    {
        if ((start >= 0u) & (start <= (ulong)_value.Length) & (end >= 0u) & (end <= (ulong)_value.Length) &
            (start <= end))
        {
            string result = "";
            ulong counter = 0;

            if (start <= end)
            {
                foreach (char chr in _value)
                {
                    if ((counter >= start) & (counter < end))
                    {
                        if ((counter - start) % step == 0)
                        {
                            result += chr.ToString();
                        }
                    }

                    if (counter > end)
                    {
                        break;
                    }

                    counter += 1;
                }
            }

            else
            {
                foreach (char chr in _value)
                {
                    if ((counter >= end) & (counter < start))
                    {
                        if ((counter - end) % step == 0)
                        {
                            result += chr.ToString();
                        }
                    }

                    if (counter > start)
                    {
                        break;
                    }

                    counter += 1;
                }

                result = Reverse(result);
            }

            return result;
        }

        return new StrIndexOutOfRangeError(0, 0);
    }

    public static void ShellSort(int [] arr)
    {
        int i, j, inc, temp;
        inc = 3;
        while (inc > 0)
        {
            for (i = 0; i < arr.Length; i++)
            {
                j = i;
                temp = arr[i];
                while ((j >= inc) && (arr[j - inc] > temp))
                {
                    arr[j] = arr[j - inc];
                    j = j - inc;
                }

                arr[j] = temp;
            }

            if (inc / 2 != 0)
            {
                inc = inc / 2;
            }
            else if (inc == 1)
            {
                inc = 0;
            }
            else
            {
                inc = 1;
            }
        }
    }

    public static void CocktailSort(int [] arr)
    {
        for (int k = arr.Length - 1; k > 0; k--)
        {
            bool swapped = false;
            for (int i = k; i > 0; i--)
                if (arr[i] < arr[i - 1])
                {
                    // swap
                    (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                    swapped = true;
                }

            for (int i = 0; i < k; i++)
                if (arr[i] > arr[i + 1])
                {
                    // swap
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapped = true;
                }

            if (!swapped)
            {
                break;
            }
        }
    }

    public static RCI IsStringFull(dynamic dt)
    {
        if (dt is str10 | dt is str16 | dt is str32 | dt is str64 | dt is string)
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI IsString(dynamic dt)
    {
        if (dt is str10 | dt is str16 | dt is str32 | dt is str64)
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI IsNumericFull(dynamic dt)
    {
        if (dt is binch | dt is kvalia | dt is shesch | dt is vosch | dt is natch16 | dt is natch32 |
            dt is natch64 | dt is celch16 | dt is celch32 | dt is celch64 | dt is drobch16 |
            dt is drobch32 | dt is drobch64 | dt is short | dt is int | dt is long | dt is float |
            dt is double)
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI IsNumeric(dynamic dt)
    {
        if (dt is natch64 | dt is celch16 | dt is celch32 | dt is celch64 | dt is drobch16 |
            dt is drobch32 | dt is drobch64 | dt is short | dt is int | dt is long | dt is float |
            dt is double)
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    protected static dynamic StrMultiply(string str, ulong n)
    {
        string stradd = str;
        for (ulong i = 1; i < n; i++) str = str + stradd;

        return str;
    }

    protected static List<List<dynamic>> Transpose(List<List<dynamic>> grid)
    {
        // Transpose the list
        dynamic [] [] transposed_list = grid.OfType<List<List<dynamic>>>()
            .Select(selector: row => row.OfType<dynamic>().ToArray()).ToArray();
        return Array2List_2D(transposed_list);
    }

    protected static dynamic [] [] List2Array_2D(List<List<dynamic>> grid)
    {
        return grid.Select(selector: a => a.ToArray()).ToArray();
    }

    public static List<List<dynamic>> Array2List_2D(dynamic [] [] grid)
    {
        return grid.Cast<dynamic>().Select(selector: (x, i) => new { x, index = i / grid.GetLength(1) }).GroupBy(keySelector: x => x.index)
            .Select(selector: x => x.Select(selector: s => s.x).ToList()).ToList();
    }

    protected static ArrayList Array2ArrayList_2D(dynamic [] [] grid)
    {
        ArrayList arrlist_grid = new ArrayList();
        List<List<dynamic>> list_grid = grid.Cast<dynamic>()
            .Select(selector: (x, i) => new { x, index = i / grid.GetLength(1) }).GroupBy(keySelector: x => x.index)
            .Select(selector: x => x.Select(selector: s => s.x).ToList()).ToList();
        foreach (List<dynamic> i in list_grid) arrlist_grid.Add(List2ArrayList(i));

        return arrlist_grid; //Weird C#
    }

    protected static List<dynamic> Array2List(dynamic [] arr) => arr.OfType<dynamic>().ToList();

    protected static ArrayList List2ArrayList(List<dynamic> list) => new ArrayList(list);

    protected static ArrayList Array2ArrayList(dynamic [] arr)
    {
        ArrayList arrlist = new ArrayList();
        arrlist.AddRange(arr);
        return arrlist; //Unable to make it into a 1 liner
    }
}