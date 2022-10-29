using System;
namespace Ural_CS_Rider.Ural_translator_compiler.Libraries.UralMathLib;


public static partial class UralMath
{
    internal class Cvet
    {
        public static int[] ryb2rgb(int[] cveta)
        {
            double w; double r;  double y;  double b; double g; double myc; double mgc;
            w = Math.Min(Math.Min(cveta[0], cveta[1]), cveta[2]);
            r = (double)(cveta[0]) - w;
            y = (double)(cveta[1]) - w;
            b = (double)(cveta[2]) - w;
            myc = Math.Max(Math.Max(r, y), b);
            g = Math.Min(y, b);
            y -= g; b -= g;
            b *= 2.0; g *= 2.0;
            r += y; g += y;
            mgc = Math.Max(Math.Max(r, g), b);
            if (mgc != 0)
            {
                r *= (myc / mgc);
                g *= (myc / mgc);
                b *= (myc / mgc);
            }
            
            r += w; g += w; b += w;
            return new int[3] {(int)r, (int)g, (int)b};
        }
        
        public static int[] rgb2ryb(int[] cveta)
        {
            double w; double r;  double g;  double b; double y; double mgc; double myc;
            w = Math.Min(Math.Min(cveta[0], cveta[1]), cveta[2]);
            r = (double)(cveta[0]) - w;
            g = (double)(cveta[1]) - w;
            b = (double)(cveta[2]) - w;
            mgc = Math.Max(Math.Max(r, g), b);
            y = Math.Min(r, g);
            r -= y; g -= y;
            b /= 2.0; g /= 2.0;
            y += g; b += g;
            myc = Math.Max(Math.Max(r, g), b);
            if (myc != 0)
            {
                r *= (mgc / myc);
                y *= (mgc / myc);
                b *= (mgc / myc);
            }
            
            r += w; y += w; b += w;
            return new int[3] {(int)r, (int)y, (int)b};
        }
    }
}
