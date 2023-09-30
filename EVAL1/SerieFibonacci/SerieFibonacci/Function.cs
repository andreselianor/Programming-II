namespace SerieFibonacci
{
    public class Function
    {
        public static string Fibonacci1(int number)
        {
            string result = "0,1";
            int n1 = 0;
            int n2 = 1;
            int sumNumbers;

            for (int i = 0; i < number - 2; i++)
            {
                sumNumbers = n1 + n2;
                result += "," + sumNumbers;
                n1 = n2;
                n2 = sumNumbers;
            }
            return result;
        }

        public static string Fibonacci2(int number)
        {
            string result = "0,1";
            int n1 = 0;
            int n2 = 1;
            int sumNumbers = n1 + n2;
            while (sumNumbers <= number)
            {
                sumNumbers = n1 + n2;
                result += "," + sumNumbers;
                n1 = n2;
                n2 = sumNumbers;
            }
            return result;
        }
    }
}
