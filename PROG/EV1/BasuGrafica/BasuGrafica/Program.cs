using System.IO;
using System.Runtime.Intrinsics.X86;
using UDK;

namespace BasuGrafica
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            string path1 = "C:\\Users\\yveelilop\\Desktop\\imagenesFiltros\\ferrari.png";
            string path2 = "C:\\Users\\yveelilop\\Desktop\\imagenesFiltros\\ferrariFiltro.png";

            Filter.InvertFilter(path1, path2);
            Filter.GreyscaleFilter(path1, path2);
            Filter.SaturateFilter(path1, path2, 0.25);
        }
    }
}