namespace FiltrosGraficos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = "..\\..\\..\\..\\resources\\okeeffe.png";
            string path2 = "..\\..\\..\\..\\resources\\okeeffeMOD.png";

            Filtros.Filter(path1, path2);
        }
    }
}