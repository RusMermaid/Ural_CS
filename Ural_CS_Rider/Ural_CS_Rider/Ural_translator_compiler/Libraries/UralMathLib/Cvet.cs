
namespace Ural_CS_Rider.Ural_translator_compiler.Libraries.UralMathLib

{
    public static partial class UralMath
    {
        internal class Cvet
        {
            public const double cos16 = 0.96126169593831886191649704855706;    //Cos of 16°
            public const double sin16 = 0.2756373558169991856499715746113;     //Sin of 16°
            public const double cos26 = 0.89879404629916699278229567669579;    //Cos of 26°
            public const double sin26 = 0.43837114678907741745273454065827;    //Sin of 26°
            public const double cos50 = 0.64278760968653932632264340990726;    //Cos of 50°
            public  const double sin50 = 0.76604444311897803520239265055542;    //Sin of 50°
            
            public static int [] ryb2rgb(int [] cveta)
            {
                double w;
                double r;
                double y;
                double b;
                double g;
                double myc;
                double mgc;
                w = Math.Min(Math.Min(cveta[0], cveta[1]), cveta[2]);
                r = (double)(cveta[0]) - w;
                y = (double)(cveta[1]) - w;
                b = (double)(cveta[2]) - w;
                myc = Math.Max(Math.Max(r, y), b);
                g = Math.Min(y, b);
                y -= g;
                b -= g;
                b *= 2.0;
                g *= 2.0;
                r += y;
                g += y;
                mgc = Math.Max(Math.Max(r, g), b);
                if (mgc != 0)
                {
                    r *= (myc / mgc);
                    g *= (myc / mgc);
                    b *= (myc / mgc);
                }

                r += w;
                g += w;
                b += w;
                return new int[3] { (int)r, (int)g, (int)b };
            }

            public static int [] rgb2ryb(int [] cveta)
            {
                double w;
                double r;
                double g;
                double b;
                double y;
                double mgc;
                double myc;
                w = Math.Min(Math.Min(cveta[0], cveta[1]), cveta[2]);
                r = (double)(cveta[0]) - w;
                g = (double)(cveta[1]) - w;
                b = (double)(cveta[2]) - w;
                mgc = Math.Max(Math.Max(r, g), b);
                y = Math.Min(r, g);
                r -= y;
                g -= y;
                b /= 2.0;
                g /= 2.0;
                y += g;
                b += g;
                myc = Math.Max(Math.Max(r, g), b);
                if (myc != 0)
                {
                    r *= (mgc / myc);
                    y *= (mgc / myc);
                    b *= (mgc / myc);
                }

                r += w;
                y += w;
                b += w;
                return new int[3] { (int)r, (int)y, (int)b };
            }
        }
        
        public static int [] ryb2rybk(int [] ryb)
        {
            double k = (double)Math.Min(ryb[0], Math.Min(ryb[1], ryb[2]));
            return new int[4] { (int)((ryb[0] - k) / (1 - k)), (int)((ryb[1] - k) / (1 - k)), (int)((ryb[2] - k) / (1 - k)), (int)k };
        }
        
        public static int [] rybk2ryb(int [] ryb)
        {
            int r = (int)((1-ryb[0]) * (1-ryb[3]));
            int y = (int)((1-ryb[1]) * (1-ryb[3]));
            int b = (int)((1-ryb[2]) * (1-ryb[3]));

            return new int[3] { r, y, b };
        }
        
        public static int [] rgb2hsb(int [] cveta)
        {
            // normalize red, green and blue values
            double r = ((double)cveta[0]/255.0);
            double g = ((double)cveta[1]/255.0);
            double b = ((double)cveta[2]/255.0);

            // conversion start
            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            double h = 0.0;
            if(max==r && g>=b)
            {
                h = 60 * (g-b)/(max-min);
            }
            else if(max==r && g < b)
            {
                h = 60 * (g-b)/(max-min) + 360;
            }
            else if(max == g)
            {
                h = 60 * (b-r)/(max-min) + 120;
            }
            else if(max == b)
            {
                h = 60 * (r-g)/(max-min) + 240;
            }

            double s = (max == 0)? 0.0 : (1.0 - (min/max));

            return new int[3] { (int)h, (int)s, (int)max};
        }
        
        public static int [] hsb2rgb(int [] cveta)
        {
            double r = 0;
            double g = 0;
            double b = 0;

            if(cveta[1] == 0)
            {
                r = g = b;
            }
            else
            {
                // the color wheel consists of 6 sectors. Figure out which sector
                // you're in.
                double sectorPos = cveta[0] / 60.0;
                int sectorNumber = (int)(Math.Floor(sectorPos));
                // get the fractional part of the sector
                double fractionalSector = sectorPos - sectorNumber;

                // calculate values for the three axes of the color.
                double p = b * (1.0 - cveta[1]);
                double q = b * (1.0 - (cveta[1] * fractionalSector));
                double t = b * (1.0 - (cveta[1] * (1 - fractionalSector)));

                // assign the fractional colors to r, g, and b based on the sector
                // the angle is in.
                switch(sectorNumber)
                {
                    case 0:
                        r = b;
                        g = t;
                        b = p;
                        break;
                    case 1:
                        r = q;
                        g = b;
                        b = p;
                        break;
                    case 2:
                        r = p;
                        g = b;
                        b = t;
                        break;
                    case 3:
                        r = p;
                        g = q;
                        b = b;
                        break;
                    case 4:
                        r = t;
                        g = p;
                        b = b;
                        break;
                    case 5:
                        r = b;
                        g = p;
                        b = q;
                        break;
                }
            }

            return new int[3] { (int)(r * 255), (int)(g * 255), (int)(b * 255) };
        }
        
        
        public static int [] rgb2hsl(int [] cveta)
        {
            double h=0, s=0, l=0;

            // normalize red, green, blue values
            double r = (double)cveta[0]/255.0;
            double g = (double)cveta[1]/255.0;
            double b = (double)cveta[2]/255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            // hue
            if(max == min)
            {
                h = 0; // undefined
            }
            else if(max==r && g>=b)
            {
                h = 60.0*(g-b)/(max-min);
            }
            else if(max==r && g<b)
            {
                h = 60.0*(g-b)/(max-min) + 360.0;
            }
            else if(max==g)
            {
                h = 60.0*(b-r)/(max-min) + 120.0;
            }
            else if(max==b)
            {
                h = 60.0*(r-g)/(max-min) + 240.0;
            }

            // luminance
            l = (max+min)/2.0;

            // saturation
            if(l == 0 || max == min)
            {
                s = 0;
            }
            else if(0<l && l<=0.5)
            {
                s = (max-min)/(max+min);
            }
            else if(l>0.5)
            {
                s = (max-min)/(2 - (max+min)); //(max-min > 0)?
            }
            return new int[3] { (int)h, (int)s, (int)l};
        }
        
        public static int [] hsl2rgb(int [] cveta)
        {
            if (cveta[1] == 0)
            {
                // achromatic color (gray scale)
                return new int[3] { (int)cveta[2] * 255, (int)cveta[2] * 255, (int)cveta[2] * 255 };
            }
            else
            {
                double q = (cveta[2]<0.5)?(cveta[2] * (1.0+cveta[1])):(cveta[2]+cveta[1] - (cveta[2]*cveta[1]));
                double p = (2.0 * cveta[2]) - q;

                double Hk = cveta[0]/360.0;
                double[] T = new double[3];
                T[0] = Hk + (1.0/3.0);    // Tr
                T[1] = Hk;                // Tb
                T[2] = Hk - (1.0/3.0);    // Tg

                for(int i=0; i<3; i++)
                {
                    if(T[i] < 0) T[i] += 1.0;
                    if(T[i] > 1) T[i] -= 1.0;

                    if((T[i]*6) < 1)
                    {
                        T[i] = p + ((q-p)*6.0*T[i]);
                    }
                    else if((T[i]*2.0) < 1) //(1.0/6.0)<=T[i] && T[i]<0.5
                    {
                        T[i] = q;
                    }
                    else if((T[i]*3.0) < 2) // 0.5<=T[i] && T[i]<(2.0/3.0)
                    {
                        T[i] = p + (q-p) * ((2.0/3.0) - T[i]) * 6.0;
                    }
                    else T[i] = p;
                }

                return new int[3] { (int)T[2] * 255, (int)T[2] * 255, (int)T[2] * 255 };
            }
        }
        
        public static int [] rgb2cmyk(int [] cveta)
        {
            // normalizes red, green, blue values
            double c = (double)(255 - cveta[0])/255;
            double m = (double)(255 - cveta[1])/255;
            double y = (double)(255 - cveta[2])/255;

            double k = (double)Math.Min(c, Math.Min(m, y));

            if(k == 1.0)
            {
                return new int[4] { 0, 0, 0, 1 };
            }
            else
            {
                return new int[4] { (int)((c - k) / (1 - k)), (int)((m - k) / (1 - k)), (int)((y - k) / (1 - k)), (int)(k)};
            }
        }
        
        public static int [] cmyk2rgb(int [] cveta)
        {
            int r = (int)((1-cveta[0]) * (1-cveta[3]) * 255.0);
            int g = (int)((1-cveta[1]) * (1-cveta[3]) * 255.0);
            int b = (int)((1-cveta[2]) * (1-cveta[3]) * 255.0);

            return new int[3] { r, g, b };
        }
        
        public static double[] rgb2xyz(int [] cveta)
        {
            double x, y, z;
            // normalize red, green, blue values
            double r = (double)cveta[0]/255.0;
            double g = (double)cveta[1]/255.0;
            double b = (double)cveta[2]/255.0;

            // convert to a sRGB form
            r = (r > 0.04045)? Math.Pow((r + 0.055)/(
                1 + 0.055), 2.2) : (r/12.92);
            g = (g > 0.04045)? Math.Pow((g + 0.055)/(
                1 + 0.055), 2.2) : (g/12.92);
            b = (b > 0.04045)? Math.Pow((b + 0.055)/(
                1 + 0.055), 2.2) : (b/12.92);

            // converts
            x = r * 0.4124 + g * 0.3576 + b * 0.1805;
            y = r * 0.2126 + g * 0.7152 + b * 0.0722;
            z = r * 0.0193 + g * 0.1192 + b * 0.9505;
            return new double[3] { x, y, z };
        }
        
        public static int [] xyz2rgb(double [] cveta)
        {
            double[] rgb = new double[3];
            rgb[0] = cveta[0]*3.2410 - cveta[1]*1.5374 - cveta[2]*0.4986; // red
            rgb[1] = -cveta[0]*0.9692 + cveta[1]*1.8760 - cveta[2]*0.0416; // green
            rgb[2] = cveta[0]*0.0556 - cveta[1]*0.2040 + cveta[2]*1.0570; // blue

            for(int i=0; i<3; i++)
            {
                rgb[i] = (rgb[i]<=0.0031308)? 12.92*rgb[i] : (
                    1+0.055)* Math.Pow(rgb[i], (1.0/2.4)) - 0.055;
            }
            return new int[3] { (int)(rgb[0]*255), (int)(rgb[1]*255), (int)(rgb[2]*255) };
        }
        
    }
}
