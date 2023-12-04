using UDK;

namespace BasuGrafica
{
    public class Filter
    {
        // Esta función realiza una inversion de colores. 
        // Para ello calculamos el valor inverso de cada canal de color.
        public static void InvertFilter(string fromPath, string toPath)
        {
            EditableImageHighPrecission source = new EditableImageHighPrecission(fromPath);
            EditableImageHighPrecission destination = new EditableImageHighPrecission(source.Width, source.Height);

            for (int y = 0; y < destination.Height; y++)
            {
                for (int x = 0; x < destination.Width; x++)
                {
                    rgba_f64 color = source[x, y];                    

                    color.r = 1 - color.r;
                    color.g = 1 - color.g;
                    color.b = 1 - color.b;
                    destination[x, y] = color;
                }
            }

            destination.SaveToFile(toPath);
        }

        // Filtro que guarda una imagen en escala de grises.
        public static void GreyscaleFilter(string fromPath, string toPath)
        {
            EditableImageHighPrecission source = new EditableImageHighPrecission(fromPath);
            EditableImageHighPrecission destination = new EditableImageHighPrecission(source.Width, source.Height);
            double AverageColor;

            for (int y = 0; y < destination.Height; y++)
            {
                for (int x = 0; x < destination.Width; x++)
                {
                    rgba_f64 color = source[x, y];

                    AverageColor = (color.r + color.g + color.b) / 3;
                    color.r = AverageColor;
                    color.g = AverageColor;
                    color.b = AverageColor;
                    destination[x, y] = color;
                }
            }

            destination.SaveToFile(toPath);
        }

        // Filtro que satura los canales de color de una imagen.
        public static void SaturateFilter(string fromPath, string toPath, double saturation)
        {
            EditableImageHighPrecission source = new EditableImageHighPrecission(fromPath);
            EditableImageHighPrecission destination = new EditableImageHighPrecission(source.Width, source.Height);
            double valueH;

            for (int y = 0; y < destination.Height; y++)
            {
                for (int x = 0; x < destination.Width; x++)
                {
                    rgba_f64 color = source[x, y];

                    hsla_f64 hsl = color.ToHSL();

                    valueH = hsl.h + saturation;

                    hsl.h = GetValidHueValue(valueH);

                    destination[x, y] = hsl.ToRGBA();                    
                }
            }

            destination.SaveToFile(toPath);
        }

        public static double GetValidHueValue(double value)
        {
            while(value > 1)
            {
                value -= 1;
            }

            return value;
        }


        // Filtro que desenfoca una imagen
        public static rgba_f64 BlurFilter(EditableImageHighPrecission source, int x, int y)
        {
            rgba_f64 result = new rgba_f64();

            if(x >= 0 && y >= 0 && x <= source.Width && y <= source.Height)
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
    }
}
