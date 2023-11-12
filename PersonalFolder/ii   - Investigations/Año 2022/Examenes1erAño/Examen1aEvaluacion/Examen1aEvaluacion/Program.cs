namespace Examen1aEvaluacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Examen 1a Evaluacion");

            double testRecursive = Function.GetRecursive(4);
            Console.WriteLine(testRecursive);

            double testPosition = Function.calculatePosition(9);
            Console.WriteLine(testPosition);
        }
    }
}