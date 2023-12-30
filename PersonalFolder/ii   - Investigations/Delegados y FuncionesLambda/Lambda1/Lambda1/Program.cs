namespace Lambda1
{
    public delegate int DelegatePow(int number);
    public delegate double DelegateSqrt(int number);
    public delegate int DelegateSum(int number1, int number2);


    public class Program
    {
        static void Main(string[] args)
        {
            /*
            int result1 = OperacionesMatematicas.CalculatePow(2);
            Console.WriteLine(result1);

            double result2 = OperacionesMatematicas.CalculateSqrt(4);
            Console.WriteLine(result2);

            int result3 = OperacionesMatematicas.CalculateSum(5, 6);
            Console.WriteLine(result3);

            DelegatePow delegado1 = new DelegatePow(OperacionesMatematicas.CalculatePow);
            int result11 = delegado1(4);
            Console.WriteLine(result11);

            DelegateSqrt delegado2 = new DelegateSqrt(OperacionesMatematicas.CalculateSqrt);
            double result21 = delegado2(4);
            Console.WriteLine(result21);

            DelegateSum delegado3 = new DelegateSum(OperacionesMatematicas.CalculateSum);
            int result31 = delegado3(4,6);
            Console.WriteLine(result31);
            */

            DelegatePow delegado1 = new DelegatePow(number1 => number1 * number1);
            int result11 = delegado1(4);
            Console.WriteLine(result11);

            DelegateSqrt delegado2 = new DelegateSqrt(number1 => Math.Sqrt(number1));
            double result21 = delegado2(4);
            Console.WriteLine(result21);

            DelegateSum delegado3 = new DelegateSum((number1, number2) => number1 + number2);
            int result31 = delegado3(4, 6);
            Console.WriteLine(result31);

        }
    }

    public class OperacionesMatematicas
    {
        public static int CalculatePow(int number)
        {
            return number * number;
        }

        public static double CalculateSqrt(int number)
        {
            return Math.Sqrt(number);
        }

        public static int CalculateSum(int number1, int number2)
        {
            {
                return number1 + number2;
            }
        }

    }
}