namespace BegginersFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeras Funciones");

            // Pruebas de funciones

            int test1 = Functions.GetMinor(5, 10);
            Console.WriteLine("El menor de dos numeros, 5, 10:\n" + test1);

            bool test2 = Functions.IsEven(5);
            Console.WriteLine("Es par el numero 5:\n" + test2);

            int test3 = Functions.GetMinest(10, 5, 15);
            Console.WriteLine("El menor de 3 numeros, 10, 5, 15:\n" + test3);

            Console.WriteLine("Serie del numero 20");
            Functions.PrintSerie(20);

            bool test5 = Functions.IsPrime(18);
            Console.WriteLine("Es primo 18: " + test5);

            Console.WriteLine("Serie Collatz de 39");
            Functions.Collatz(39);

            int test6 = Functions.GetSummatory(10);
            Console.WriteLine("Sumatorio de 10:\n" + test6);

            int test7 = Functions.GetProductory(10);
            Console.WriteLine("Productorio de 10:\n" + test7);
        }
    }
}