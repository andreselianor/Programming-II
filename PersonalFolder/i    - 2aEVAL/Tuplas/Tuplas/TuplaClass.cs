namespace Tuplas
{
    public class TuplaClass
    {
        public static int GetResultsNumber(double a, double b, double c)
        {
            double discriminante = (b * b) - (4 * a * c);
            if (discriminante > 0)
                return 2;
            if (discriminante == 0)
                return 1;
            return 0;
        }

        public static (double, double) GetEquationResult(double a, double b, double c)
        {
            double raiz = (b * b) - (4 * a * c);
            double denominator = 2 * a;

            if( denominator == 0)
                return (double.NaN,double.NaN);

            double result1 = (-b + Math.Sqrt(raiz)) / denominator;
            double result2 = (-b - Math.Sqrt(raiz)) / denominator;

            return (result1, result2);
        }

        public static double GetFirstResultEquation(double a, double b, double c)
        {
            var result = GetEquationResult(a, b, c);

            return result.Item1;
        }

        public static double GetSecondtResultEquation(double a, double b, double c)
        {
            var result = GetEquationResult(a, b, c);

            return result.Item2;
        }
    }
}
