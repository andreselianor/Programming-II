namespace Functions
{
    public class Functions
    {
        // Funcion Sumatory con un bucle WHILE
        public static int GetSumatory1(int number)
        {
            int result = 0;
            int i = 1;

            while (i <= number)
            {
                result += i;
                i++;
            }
            return result;
        }

        // Funcion Sumatory con un bucle FOR
        public static int GetSumatory2(int number)
        {
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }

        // Funcion Auxiliar que devuelve un verdadero para un número par
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }

        // Funcion Secuencia con un bucle WHILE
        public static void GetSequence(int number)
        {
            int count = 0;
            int result = 0;
            int resultCounter = 0;

            while (resultCounter < number)
            {
                if (IsEven(count))
                {
                    result = count * 2 * (1);
                }
                else
                {
                    result = count * 2 * (-1);
                }
                Console.WriteLine(result);
                resultCounter = Math.Abs(result);
                count++;
            }
        }

        // Funcion Secuencia con un bucle FOR
        public static void GetSequence2(int number)
        {
            int result = 0;

            for (int i = 1; i <= number / 2; ++i)
            {
                if (IsEven(i))
                {
                    result = i * 2 * (1);
                }
                else
                {
                    result = i * 2 * (-1);
                }

                Console.WriteLine(result);
            }
        }

        // Funcion Secuencia con una funcion reservada MATH.POW
        public static void GetSequence3(int number)
        {
            int result = -2, printNumber, count = 0;

            while (result < number)
            {
                result += 2;
                printNumber = result * (int)Math.Pow(-1, count);
                Console.WriteLine(printNumber);
                count++;
            }
        }        
    }
}