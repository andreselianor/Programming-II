using DAMLib;
using System.Text.Json;

namespace DAMLibTest
{
    public class Program
    {
        // Test de caja blanca
        public static Test1Resultados Test1(DAMLib.ISet<string> set)
        {
            Test1Resultados test1 = new Test1Resultados();
            {
                set.Add("libreria");
                test1.Count = set.Count;
            }
            return test1;
        }        

        public class Test1Resultados
        {
            public int Count { get; set; }
            public bool IsEmpty { get; set; }
            public bool Contains { get; set; }
        }

        static void Main(string[] args)
        {
            Set<string> set1 = new Set<string>();

            Test1Resultados pruebaTest1 = Test1(set1);
            string resultado1 = JsonSerializer.Serialize(pruebaTest1);            
        }
    }

    /*
    public class Program
    {
        static void Main(string[] args)
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
    }

    public class Prueba<T>
    {
        public T value;
        public override int GetHashCode()
        {
            return 10;
            //return  5 * base.GetHashCode();
            //return  GetHashCode();
        }
    }

    public class Prueba2
    {
        public int number;

        public override int GetHashCode()
        {
            return 10;
            //return  5 * base.GetHashCode();
            //return  GetHashCode();
        }
    }*/
}