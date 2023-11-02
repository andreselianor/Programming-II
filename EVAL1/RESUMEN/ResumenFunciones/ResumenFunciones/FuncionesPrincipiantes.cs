namespace ResumenFunciones
{
    public class FuncionesPrincipiantes
    {
        #region Funcion 1 · Funcion que devuelve el menor de dos numeros

        public static int GetMinor(int number1, int number2)
        {
            if (number1 <= number2)
                return number1;
            return number2;
        }

        #endregion

        #region Funcion 2 · Funcion que devuelve verdadero si un numero es par

        public static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }

        #endregion

        #region Funcion 3 · Funcion que devuelve el menor de tres numeros

        public static int GetMinest(int number1, int number2, int number3)
        {
            if (number1 <= number2 && number1 <= number3)
                return number1;
            if (number2 <= number3)
                return number2;
            else
                return number3;
        }
        #endregion

        #region Funcion 4 · Serie que imprime por consola la serie 0, -2, 4, -6, 8

        public static void PrintSerie(int number)
        {
            int result = 0;

            for (int i = 0; i <= number / 2; i++)
            {
                if (IsEven(i))
                    result = (2 * i);
                else
                    result = (-2 * i);
                Console.WriteLine(result);
            }
        }
        #endregion

        #region Funcion 5 · Funcion que devuelve verdadero si un numero es primo

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        #endregion

        #region Funcion 6 · Funcion que imprime en consola los valores de la serie Collatz

        public static void Collatz(int number)
        {
            int result = number;
            Console.WriteLine(result);
            while (result != 1)
            {
                if (IsEven(result))
                    result /= 2;
                else
                    result = (result * 3) + 1;
                Console.WriteLine(result);
            }
        }
        #endregion

        #region Funcion 7 · Funcion que devuelve el sumatorio de un numero

        public static int GetSummatory(int number)
        {
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }
        #endregion

        #region Funcion 8 · Funcion que devuelve el productorio de un numero

        public static int GetProductory(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion
    }
}
