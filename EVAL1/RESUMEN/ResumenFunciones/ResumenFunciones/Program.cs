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

            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int> { 2, 4, 6 };
            Colecciones.RemoveValuesAlter(list1, list2);

        }
    }
}