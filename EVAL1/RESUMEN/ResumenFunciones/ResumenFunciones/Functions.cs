using System;

namespace ResumenFunciones
{
    public class Functions
    {

        // Funcion que devuelve 'true' o 'false' si un número es MENOR que otro
        public static bool IsMinor(int number1, int number2)
        {
            return number1 < number2;
        }

        // Funcion que devuelve 'true' o 'false' si un número es MAYOR que otro
        public static bool IsMajor(int number1, int number2)
        {
            return number1 > number2;
        }

        // Funcion auxiliar que devuelve verdadero si es un número PAR
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }

        // Funcion auxiliar que devuelve verdadero si es un numero IMPAR
        public static bool IsOdd(int number)
        {
            return (number % 2 != 0);
        }


        // Funcion Sumatory con un bucle WHILE
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

        // Funcion Sumatory con un bucle FOR
        public static int GetSumatoryFor(int number)
        {
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }

        // Funcion Secuencia con un bucle WHILE
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

        // Funcion Secuencia con un bucle FOR
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

        // Funcion que devuelve si un numero es Primo
        // TODO: Numero Primo
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;

                // ES UN ERROR FATAL ESCRIBIR UN RETURN DENTRO DE UN BUCLE FOR!!!!                
            }
            return true;
        }

        #region Funciones Repaso
        // FUNCION que devuelve el menor de dos numeros
        public static int GetMinor(int number1, int number2)
        {
            if (number1 <= number2)
                return number1;
            return number2;
        }

        // FUNCION que devuelve el menor de tres numeros
        public static int GetMinest(int number1, int number2, int number3)
        {
            if (number1 <= number2 && number1 <= number3)
                return number1;
            if (number2 <= number3)
                return number2;
            else
                return number3;
        }

        // FUNCION que imprime por consola la serie 0, -2, 4, -6, 8
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

        // FUNCION que devuelve verdadero si un numero es primo
        public static bool IsPrimeFirst(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        //FUNCION que imprime en consola los valores de la serie Collatz
        public static void Collatz0(int number)
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


        // FUNCION que devuelve el sumatorio de un numero
        public static int GetSummatory(int number)
        {
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }


        //FUNCION que devuelve el productorio de un numero
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


        // Funcion que concatena strings. Devuelve un 'string'
        public static string StringFunction1(string a, string b)
        {
            return a + b;
        }

        public static string StringFunction2(int number)
        {
            string result = "0";
            for (int i = 0; i < number; i++)
            {
                result += "," + (i + 1);
            }
            return result;
        }

        public static string StringFunction3(int number)
        {
            string result = "1";
            int aux = 1;
            for (int i = 0; i < number; i++)
            {
                aux *= 2;
                result += "," + aux;
            }
            return result;
        }

        public static void Concatenate(string text1, string text2, string text3)
        {
            Console.WriteLine("Frase1 , 2 y 3");
            Console.WriteLine(text1 + ", " + text2 + ", " + text3);

            Console.WriteLine("Frase1 y 2");
            Console.WriteLine("{0} , {1}", text1, text2);

            Console.WriteLine("Frase2 y 3");
            Console.WriteLine($"{text2} , {text3}");
        }


        // Funcion que devuelve la serie Collatz
        // TODO: Funcion Collatz
        public static List<int> Collatz(int number)
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

        // Serie de Fibonacci con un numero determinado de resultados
        // TODO: Serie Fibonacci
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

        // Serie de Fibonacci mientras sea menor que un numero de resultados
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

        // Funcion que ejecuta un SWAP(intercambio) entre dos elementos
        // TODO: Funcion Swap
        public static void Swap(List<int> list)
        {
            int aux;
            aux = list[0];
            list[0] = list[1];
            list[1] = aux;
        }

        // Funcion que ejecuta un SORT(ordenar) una lista
        // TODO: Funcion Sort
        public static void Sort(List<int> list)
        {
            if (list == null)
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

        // Funcion que devuelve los elementos pares de una lista
        public static List<int> GetListOdd(List<int> list)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (IsEven(list[i]))
                    result.Add(i);
            }
            return result;
        }

        // Funcion que devuelve los elementos pares de un array
        // OJO NIVEL MEDIO EXAMEN
        public static int[] GetListOdd(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Error de validacion. Array introducida es null");
                return new int[0];
            }
                               

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
            int contador = 0;


            // Introducimos los elementos pares dentro de un nuevo array
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
    }
}
