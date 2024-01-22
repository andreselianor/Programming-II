using DAMLib;
using System.Text.Json;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Set<string> set1 = new Set<string>();

            {
                TestUnidad pruebaTest1 = TestUnidad.Test1(set1);
                string resultado1 = JsonSerializer.Serialize(pruebaTest1);
                string path = "../../../resultados1.json";
                File.WriteAllText(path, resultado1);
            }

            /* Codigo Antiguo
            {
                Prueba<string> prueba1 = new Prueba<string>();
                prueba1.value = "estadio";
                int result1 = prueba1.GetHashCode();

                Prueba2 prueba2 = new Prueba2();
                prueba2.number = 50;
                int result2 = prueba2.GetHashCode();

                OrderedSet<int> orden1 = new OrderedSet<int>();
                orden1.Add(100);
                orden1.Add(50);

                int number = orden1.BinarySearch(100);
            } 
            */
        }
    }
}