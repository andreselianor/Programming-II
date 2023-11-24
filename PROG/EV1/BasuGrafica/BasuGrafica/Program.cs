using System.IO;
using System.Runtime.Intrinsics.X86;
using UDK;

namespace BasuGrafica
{
    internal class Program
    {
        public static void Filter(string fromPath, string toPath)
        {
            EditableImageHighPrecission source = new EditableImageHighPrecission(fromPath);
            EditableImageHighPrecission destination = new EditableImageHighPrecission(source.Width, source.Height);

            for (int y = 0; y < destination.Height; y++)
            {
                for (int x = 0; x < destination.Width; x++)
                {

                    //Todas las imagenes se generan a partir de un modelo RGBA
                    rgba_f64 color = source[x, y];

                    //Invertir Colores - Hacer el negativo
                    /*
                    color.r = 1 - color.r;
                    color.g = 1 - color.g;
                    color.b = 1 - color.b;
                    destination[x, y] = color;
                    */

                    //Fotografia en escala de grises
                    /*
                    double AverageColor = (color.r + color.g + color.b) / 3;
                    color.r = AverageColor;
                    color.g = AverageColor;
                    color.b = AverageColor;
                    destination[x, y] = color;
                    */

                    //Saturar una imagen
                    /*
                    hsla_f64 hsl = color.ToHSL();
                    double valueH = hsl.h + 0.5;
                    hsl.h = MiniminizeValue(valueH);                    
                    destination[x, y] = hsl.ToRGBA();
                    */

                    //Efecto Blur de una imagen


                    destination[x, y] = Blur(source, x, y);



                }
            }
            destination.SaveToFile(toPath);
        }

        public static double MiniminizeValue(double value)
        {
            return value > 1 ? value -= 1 : value;
        }

        public static rgba_f64 Blur(EditableImageHighPrecission source, int x, int y)
        {
            rgba_f64 result = new rgba_f64();

            if (x <= 0 && y <= 0) ;
            else if (x >= source.Width && y >= source.Height) ;
            else if (x >= source.Width && y <= 0) ;
            else if (x <= 0 && y >= source.Height) ;
            else 
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        rgba_f64 aux = source[i, j];
                        result.r += aux.r;
                        result.g += aux.g;
                        result.b += aux.b;
                    }
                }
                result.r /= 9;
                result.g /= 9;
                result.b /= 9;

            }
            return result;
        }

        static void Main(string[] args)
        {
            string path1 = "C:\\Users\\yveelilop\\Desktop\\Programacion\\Git\\Programming-II\\PROG\\EV1\\BasuGrafica\\Output\\ferrari.png";
            string path2 = "C:\\Users\\yveelilop\\Desktop\\Programacion\\Git\\Programming-II\\PROG\\EV1\\BasuGrafica\\Output\\ferrariBlur.png";

            Filter(path1, path2);
        }
    }
}