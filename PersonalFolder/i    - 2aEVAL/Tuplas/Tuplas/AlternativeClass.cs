namespace Tuplas
{
    public class AlternativeClass
    {
        public static bool SolveEquation(double a, double b, double c, out double result1, out double result2)
        {
            result1 = double.NaN;
            result2 = double.NaN;
            if (a == 0.0)
                return false;
            double r = b * b - 4.0 * a * c;
            if (r < 0.0)
                return false;
            double root = Math.Sqrt(r);
            double denominator = 1.0 / 2.0 * a;
            result1 = (-b + root) * denominator;
            result2 = (-b - root) * denominator;

            return true;
        }
    }
}
