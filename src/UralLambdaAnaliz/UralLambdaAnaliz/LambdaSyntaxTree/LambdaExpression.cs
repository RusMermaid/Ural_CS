#region

using Datatypes.Booleans;
using Datatypes.Numbers;
using Datatypes.Numbers.OtherNumbers.Binary;
using Datatypes.Strings;
using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

#endregion

namespace Datatypes.Collections.MathCollections.LambdaAnaliz.LambdaSyntaxTree;

/// <summary>
/// Provides a parent for the Root term
/// </summary>
public class LambdaExpression : LambdaTerm
{
    public LambdaTerm Root;

    public LambdaExpression(LambdaTerm root)
    {
        root.Parent = this;
        this.Root = root;
    }

    public override RCI BetaReduce()
    {
        bool toEnd = true;

        //Loop until we can b-reduce no more
        while (toEnd)
            try { toEnd = this.Root.BetaReduce(); }
            catch { toEnd = true; }

        return false;
    }

    internal override void Replace(LambdaVariable what, LambdaTerm with)
    {
        this.Root.Replace(what, with);
    }

    private List<string> FreeVariables = new List<string>();

    public override celch64 GetDeBruijnIndex(string name = "")
    {
        if (!this.FreeVariables.Contains(name))
        {
            this.FreeVariables.Add(name);
        }

        return new celch64(-1 - this.FreeVariables.IndexOf(name));
    }

    public override string ToString() => this.Root.ToString();

    public override str10 PrintDeBruijn() => this.Root.PrintDeBruijn();

    public override str10 PrintBinary()
    {
        InnerLambdaTerm print_DeBruijn = InnerParse.ParseStream(new str10(this.Root.PrintDeBruijn().value.Replace(@".", "")));
        return print_DeBruijn.BruijnBinary();
    }

    public override binch ToBinary() => new binch(this.PrintBinary());

    internal class InnerLambdaTerm
    {
        public enum NodeType { Index, Abstraction, Application }

        public NodeType Type {get; set;}
        public int IndexValue {get; set;} // For indices
        public InnerLambdaTerm Left {get; set;} // For applications
        public InnerLambdaTerm Right {get; set;} // For applications
        public InnerLambdaTerm Body {get; set;} // For abstractions

        // Recursively convert to binary
        public string BruijnBinary()
        {
            switch (this.Type)
            {
                case NodeType.Index :
                    return new string('1', this.IndexValue) + "0";
                case NodeType.Abstraction :
                    return "00" + this.Body.BruijnBinary();
                case NodeType.Application :
                    return "01" + this.Left.BruijnBinary() + this.Right.BruijnBinary();
                default :
                    BinchOutOfRangeMaxError err = new BinchOutOfRangeMaxError(0, 0);
                    err.Execute();
                    return err.ToString();
            }
        }

        public binch ToBinary() => new binch(this.BruijnBinary());
    }

    internal class InnerPeekable
    {
        private IEnumerator<string> stream;
        private string head;

        public InnerPeekable(IEnumerable<string> s)
        {
            this.stream = s.GetEnumerator();
        }

        internal string Peek()
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

            return this.head;
        }

        internal string Next()
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

    internal class InnerParse
    {
        private static readonly IDictionary<char, char> Padding = new Dictionary<char, char>
        {
            { '(', ' ' },
            { ')', ' ' },
            { 'λ', ' ' }
        };

        internal static InnerLambdaTerm ParseStream(string stream)
        {
            InnerPeekable tokenizedStream = new InnerPeekable(Tokenize(stream));
            InnerLambdaTerm result = Impl(tokenizedStream);
            if (tokenizedStream.Peek() != null)
            {
                BinchOutOfRangeMaxError err = new BinchOutOfRangeMaxError(0, 0);
                err.Execute();
            }

            return result;
        }

        internal static InnerLambdaTerm ParseStream(str10 stream) => ParseStream((string)stream.value);

        internal static InnerLambdaTerm ParseStream(str16 stream) => ParseStream((string)stream.value);

        internal static InnerLambdaTerm ParseStream(str32 stream) => ParseStream((string)stream.value);

        internal static InnerLambdaTerm ParseStream(str64 stream) => ParseStream((string)stream.value);

        private static IEnumerable<string> Tokenize(string s)
        {
            Dictionary<char, string>? replacements = new Dictionary<char, string>
            {
                { '(', " ( " },
                { ')', " ) " },
                { 'λ', " λ " }
            };
            string replacedString = new string(s.Select(selector: c => replacements.ContainsKey(c) ? replacements[c] : c.ToString())
                .SelectMany(selector: str => str)
                .ToArray());
            return replacedString.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }


        private static InnerLambdaTerm Impl(InnerPeekable stream)
        {
            InnerLambdaTerm? func = Atom(stream);
            if (func == null)
            {
                return null;
            }

            InnerLambdaTerm? arg = Atom(stream);
            while (arg != null)
            {
                func = new InnerLambdaTerm
                {
                    Type = InnerLambdaTerm.NodeType.Application,
                    Left = func,
                    Right = arg
                };
                arg = Atom(stream);
            }

            return func;
        }

        private static InnerLambdaTerm Atom(InnerPeekable stream)
        {
            string? peek = stream.Peek();

            switch (peek)
            {
                case "(" :
                    stream.Next();
                    InnerLambdaTerm result = Impl(stream);
                    if (stream.Next() == ")")
                    {
                        return result;
                    }

                    BinchOutOfRangeMaxError err = new BinchOutOfRangeMaxError(0, 0);
                    err.Execute();

                    return result;

                case "λ" :
                    stream.Next();
                    InnerLambdaTerm? body = Impl(stream);
                    return body == null ? null : new InnerLambdaTerm { Type = InnerLambdaTerm.NodeType.Abstraction, Body = body };

                default :
                    if ((peek == null) || !int.TryParse(peek, out int number))
                    {
                        return null;
                    }

                    stream.Next();
                    return new InnerLambdaTerm { Type = InnerLambdaTerm.NodeType.Index, IndexValue = number };
            }
        }
    }
}