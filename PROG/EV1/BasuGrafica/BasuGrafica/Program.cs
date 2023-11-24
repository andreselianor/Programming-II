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
                    rgba_f64 color = source[x, y];
                    color.r = 1 - color.r;
                    color.g = 1 - color.g;
                    color.b = 1 - color.b;
                    destination[x, y] = color;
                }
            }

            destination.SaveToFile(toPath);
        }

        static void Main(string[] args)
        {
            string path1 = "C:\\Users\\yveelilop\\Desktop\\Programacion\\Git\\Programming-II\\PROG\\EV1\\BasuGrafica\\Output\\image1.png";
            string path2 = "C:\\Users\\yveelilop\\Desktop\\Programacion\\Git\\Programming-II\\PROG\\EV1\\BasuGrafica\\Output\\imageCopyInvertido.png";

            Filter(path1, path2);
        }
    }
}