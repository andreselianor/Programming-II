namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funciones de Clase");

            bool sentence1 = Functions.IsGreaterSecondValue4(20, 5);
            Console.WriteLine(sentence1);

            int number1 = Functions.GetMajorNumber(5, -9, 0);
            Console.WriteLine(number1);

            bool sentence2 = Functions.IsEven(40);
            Console.WriteLine(sentence2);
        }
    }
}