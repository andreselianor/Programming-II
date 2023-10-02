namespace SerieFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie de Fibonacci");
            string Fibonacci = Function.Fibonacci1(7);
            Console.WriteLine(Fibonacci);

            string Fibonacci2 = Function.Fibonacci2(3);
            Console.WriteLine(Fibonacci2);
        }
    }
}