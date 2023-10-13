namespace TryCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                int d1 = Divide.DivideBy(1, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            */

            int d2 = Divide.DivideBy(1, 0);
        }
    }

    public class Divide
    {
        public static int DivideBy(int number1, int number2)
        {
            if (number2 == 0)
                return Excepcion("Division entre cero");
            return number1/number2;
        }

        public static int Excepcion(string text)
        {
            Console.WriteLine(text);
            return 0;
        }
    }
}