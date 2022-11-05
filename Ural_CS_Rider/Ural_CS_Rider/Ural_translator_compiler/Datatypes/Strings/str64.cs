using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Ural.Ural_translator_compiler.Datatypes.Booleans;
using Ural.Ural_translator_compiler.Datatypes.Strings;


namespace Ural.Ural_translator_compiler.Datatypes.Strings
{
    public class str64 : VOID
    {
        public const uint MaxLength = 4294967295U;

        public str64(object _value = null) : base(_value)
        {
            this.value = Convert.ToString(_value);
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