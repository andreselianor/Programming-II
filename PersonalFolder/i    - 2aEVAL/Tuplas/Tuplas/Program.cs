namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (double number1, double number2) = TuplaClass.GetEquationResult(1.0, -5.0, 6.0);

            double memory1;
            double memory2;

            bool result = AlternativeClass.SolveEquation(1.0, -5.0, 6.0, out memory1, out memory2);

        }
    }
}