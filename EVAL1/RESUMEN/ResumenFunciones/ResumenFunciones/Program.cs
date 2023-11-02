namespace ResumenFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] chiquis;
            chiquis = Arrays.CreateArray();
            Arrays.ListArray(chiquis);

            string[] coupling;
            string[] minisimas;
            (coupling,minisimas) = Arrays.CreateHobbies();
            Arrays.ShuffleResult(coupling,minisimas, chiquis);
        }
    }
}