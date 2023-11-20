using System;

namespace ResumenFunciones
{    
    public class FunctionsClaseMarin
    {

        #region Funciones Principiantes
        // FUNCION 1 ·
        // Funcion que devuelve el menor de dos numeros.
        public static int GetMinor(int number1, int number2)
        {
            if (number1 <= number2)
                return number1;
            return number2;
        }

        // FUNCION 2 ·
        // Funcion que devuelve verdadero si un numero es par.
        public static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }

        // FUNCION 3 ·
        // Funcion que devuelve el menor de tres numeros.
        public static int GetMinest(int number1, int number2, int number3)
        {
            if (number1 <= number2 && number1 <= number3)
                return number1;
            if (number2 <= number3)
                return number2;
            else
                return number3;
        }

        // FUNCION 4 ·
        // Serie que imprime por consola la serie 0, -2, 4, -6, 8.
        public static void PrintSerie(int number)
        {
            int result;

            for (int i = 0; i <= number / 2; i++)
            {
                if (IsEven(i))
                    result = (2 * i);
                else
                    result = (-2 * i);
                Console.WriteLine(result);
            }
        }

        // FUNCION 5 ·
        // TODO: [EXAMEN] Funcion 'bool' si un numero es primo.
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // FUNCION 6 ·
        // Funcion que imprime en consola los valores de la serie Collatz.
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


        // FUNCION 7 ·
        // Funcion que devuelve el sumatorio de un numero.
        public static int GetSummatory(int number)
        {
            int result = 0;

            for (int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }


        // FUNCION 8 ·
        // Funcion que devuelve el productorio de un numero.
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

        #region Funciones Elementales

        // FUNCION 9 ·
        // Devuelve un 'bool' si un número es MENOR que otro.
        public static bool IsMinor(int number1, int number2)
        {
            return number1 < number2;
        }

        // FUNCION 10 ·
        // Devuelve un 'bool' si un número es MAYOR que otro.
        public static bool IsMajor(int number1, int number2)
        {
            return number1 > number2;
        }

        // FUNCION 11 ·
        // Funcion auxiliar que devuelve un 'bool' si un número PAR.
        public static bool IsEvenAlternative(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }

        // FUNCION 12 ·
        // Funcion auxiliar que devuelve un 'bool' si un numero es IMPAR.
        public static bool IsOdd(int number)
        {
            return (number % 2 != 0);
        }
        #endregion

        #region Funciones de bucles
        // FUNCION 13 ·
        // Funcion Sumatory con un bucle WHILE.
        public static int GetSumatoryWhile(int number)
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

        // FUNCION 14 ·
        // Funcion Sumatory con un bucle FOR.
        public static int GetSumatoryFor(int number)
        {
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }

        // FUNCION 15 ·
        // Funcion Secuencia con un bucle WHILE.
        public static void GetSequenceWhile(int number)
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

        // FUNCION 16 ·
        // Funcion Secuencia con un bucle FOR.
        public static void GetSequenceFor(int number)
        {
            int result;

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
        #endregion
       
        #region Funciones Repaso
        // FUNCION 17 ·
        // Devuelve el menor de dos numeros.
        public static int GetMinorAlternative(int number1, int number2)
        {
            if (number1 <= number2)
                return number1;
            return number2;
        }

        // FUNCION 18 ·
        // Funcion anterior con operador ternario.
        public static int GetMinorTernary(int number1, int number2)
        {
            return number1 < number2 ? number1 : number2;
        }

        // FUNCION 19 ·
        // Devuelve el menor de tres numeros.
        public static int GetMinestAlternative(int number1, int number2, int number3)
        {
            if (number1 <= number2 && number1 <= number3)
                return number1;
            if (number2 <= number3)
                return number2;
            else
                return number3;
        }

        // FUNCION 20 ·
        // Devuelve un 'bool' si un numero es primo.
        public static bool IsPrimeFirst(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        //FUNCION 21 ·
        //Imprime en consola los valores de la serie Collatz.
        public static void CollatzV2(int number)
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

        // FUNCION 22 ·
        // Devuelve el sumatorio de un numero.
        public static int GetSummatoryAlternative(int number)
        {
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }

        //FUNCION 23 ·
        //Devuelve el productorio de un numero.
        public static int GetProductoryAlternative(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion

        #region Funciones series
        // FUNCION 24 ·
        // Funcion Secuencia con un metodo reservado 'MATH.POW'.
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

        // FUNCION 25 ·
        // Devuelve 'bool' si un numero es Primo.
        public static bool IsPrimeAlternative(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        // FUNCION 26 ·
        // Devuelve la serie Collatz.
        public static List<int> CollatzAlternative(int number)
        {
            List<int> list = new List<int>();
            int result = number;

            list.Add(number);

            while (result != 1)
            {
                if (IsEven(result))
                    result /= 2;
                else
                    result = (result * 3) + 1;
                list.Add(result);
            }

            return list;
        }

        // FUNCION 27 ·
        // Serie de Fibonacci con un numero determinado de resultados
        // TODO: [EXAMEN] Serie Fibonacci.
        public static string FibonacciFOR(int number)
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

        // FUNCION 28 ·
        // Serie de Fibonacci mientras sea menor que un numero de resultados.
        public static string FibonacciWHILE(int number)
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
        #endregion

        #region Ordenar listas
        // FUNCION 29 ·
        // Funcion que ejecuta un 'SWAP' entre dos elementos.
        // TODO: [EXAMEN] Funcion Swap. 
        public static void Swap(List<int> list)
        {
            int aux;
            aux = list[0];
            list[0] = list[1];
            list[1] = aux;
        }

        // FUNCION 30 ·
        // Funcion que ejecuta un metodo 'SORT' una lista.
        // TODO: [EXAMEN] Funcion Sort.
        public static void Sort(List<int> list)
        {
            if (list == null || list.Count == 0)
                return;

            int aux;
            int n1 = list.Count - 1;
            int n2 = list.Count;

            for (int i = 0; i < n1; i++)
            {
                for (int j = i + 1; j < n2; j++)
                {
                    if (list[i] > list[j])
                    {
                        aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                }
            }
        }

        // FUNCION 31 ·
        // Devuelve los elementos pares de una lista.
        public static List<int> GetListOdd(List<int> list)
        {
            if (list == null)
                return null;

            if (list.Count == 0)
                return new List<int>() { 0 };

            List<int> result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (IsEven(list[i]))
                    result.Add(i);
            }
            return result;
        }

        // FUNCION 32 ·
        // Devuelve los elementos pares de un array.
        // [EXAMEN] Posible ejercicio de arrays.
        public static int[] GetListOdd(int[] array)
        {
            if (array == null)
                return new int[0];            

            int[] result;
            int count = 0;

            // Buscamos los numeros pares y guardamos el conteo total
            for (int i = 0; i < array.Length; i++)
            {
                if (IsEven(array[i]))
                    count++;
            }

            // Creamos un array cuya longitud es igual al numero de pares encontrados
            result = new int[count];

            // Introducimos los elementos pares dentro de un nuevo array
            int contador = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (IsEven(array[i]))
                {
                    result[contador] = array[i];
                    contador++;
                }
            }

            return result;
        }
        #endregion        

        #region Funciones Varias
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        return true;
                    return false;
                }
                return true;
            }
            return false;
        }

        public static string FunctionTernary(int number)
        {
            string result = "";
            result = (number > 5) ? "Mas de cinco" : "Menos de cinco";
            return result;
        }

        public enum DayWeek
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }

        public static int GetDayWeek(DayOfWeek dayWeek) => (int)dayWeek;

        public DayWeek dia;
        public int numero;

        #endregion
    }
}
