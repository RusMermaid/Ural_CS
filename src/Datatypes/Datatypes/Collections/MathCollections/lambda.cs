using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

namespace Datatypes.Collections.MathCollections
{
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
            this.value = new massiv<Type>(from i in this.value.value.ToArray(typeof(Type)) as Type [] where ffilter(i) select this.alpha(i));
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

        public static Type_Result F<Type_Result>(Delegate f, params object [] args)
        {
            return (Type_Result)Convert.ChangeType(f.DynamicInvoke(args), typeof(Type_Result));
        }


        public class LambdaTerm
        {
            public enum NodeType
            {
                Index,
                Abstraction,
                Application
            }

            public NodeType Type {get; set;}
            public int IndexValue {get; set;} // For indices
            public LambdaTerm Left {get; set;} // For applications
            public LambdaTerm Right {get; set;} // For applications
            public LambdaTerm Body {get; set;} // For abstractions

            // Recursively convert to binary
            public str10 BruijnBinary()
            {
                switch (this.Type)
                {
                    case NodeType.Index :
                        return new str10(new string('1', this.IndexValue) + "0");
                    case NodeType.Abstraction :
                        return new str10("00" + this.Body.BruijnBinary());
                    case NodeType.Application :
                        return new str10("01" + this.Left.BruijnBinary() + this.Right.BruijnBinary());
                    default :
                        BinchOutOfRangeMaxError err = new BinchOutOfRangeMaxError(0, 0);
                        err.Execute();
                        return new str10(err.ToString());
                }
            }

            public binch ToBinary()
            {
                return new binch((string)this.BruijnBinary().value);
            }
        }

        public class Peekable
        {
            private IEnumerator<string> stream;
            private string head;

            public Peekable(IEnumerable<string> s)
            {
                this.stream = s.GetEnumerator();
            }

            public string Peek()
            {
                switch (this.head)
                {
                    case null :
                    {
                        if (this.stream.MoveNext())
                        {
                            this.head = this.stream.Current;
                        }

                        break;
                    }
                }

                return head;
            }

            public string Next()
            {
                if (this.head != null)
                {
                    string temp = this.head;
                    this.head = null;
                    return temp;
                }

                this.stream.MoveNext();
                return this.stream.Current;
            }
        }

        public class Parse
        {
            private static readonly IDictionary<char, char> Padding = new Dictionary<char, char>
            {
                { '(', ' ' },
                { ')', ' ' },
                { 'λ', ' ' }
            };

            public static LambdaTerm ParseStream(string stream)
            {
                Peekable tokenizedStream = new Peekable(Tokenize(stream));
                LambdaTerm result = Impl(tokenizedStream);
                if (tokenizedStream.Peek() != null)
                {
                    BinchOutOfRangeMaxError err = new BinchOutOfRangeMaxError(0, 0);
                    err.Execute();
                }

                return result;
            }

            public static LambdaTerm ParseStream(str10 stream)
            {
                return ParseStream((string)stream.value);
            }

            public static LambdaTerm ParseStream(str16 stream)
            {
                return ParseStream((string)stream.value);
            }

            public static LambdaTerm ParseStream(str32 stream)
            {
                return ParseStream((string)stream.value);
            }

            public static LambdaTerm ParseStream(str64 stream)
            {
                return ParseStream((string)stream.value);
            }

            private static IEnumerable<string> Tokenize(string s)
            {
                var replacements = new Dictionary<char, string>
                {
                    { '(', " ( " },
                    { ')', " ) " },
                    { 'λ', " λ " }
                };
                string replacedString = new string(s.Select(c => replacements.ContainsKey(c) ? replacements[c] : c.ToString())
                    .SelectMany(str => str)
                    .ToArray());
                return replacedString.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }


            private static LambdaTerm Impl(Peekable stream)
            {
                LambdaTerm? func = Atom(stream);
                if (func == null)
                {
                    return null;
                }

                LambdaTerm? arg = Atom(stream);
                while (arg != null)
                {
                    func = new LambdaTerm
                    {
                        Type = LambdaTerm.NodeType.Application,
                        Left = func,
                        Right = arg
                    };
                    arg = Atom(stream);
                }

                return func;
            }

            private static LambdaTerm Atom(Peekable stream)
            {
                string? peek = stream.Peek();

                switch (peek)
                {
                    case "(" :
                        stream.Next();
                        LambdaTerm result = Impl(stream);
                        if (stream.Next() != ")")
                        {
                            BinchOutOfRangeMaxError err = new BinchOutOfRangeMaxError(0, 0);
                            err.Execute();
                        }

                        return result;

                    case "λ" :
                        stream.Next();
                        LambdaTerm? body = Impl(stream);
                        return body == null ? null : new LambdaTerm { Type = LambdaTerm.NodeType.Abstraction, Body = body };

                    default :
                        if (peek != null && int.TryParse(peek, out int number))
                        {
                            stream.Next();
                            return new LambdaTerm { Type = LambdaTerm.NodeType.Index, IndexValue = number };
                        }

                        return null;
                }
            }
        }
    }
}
