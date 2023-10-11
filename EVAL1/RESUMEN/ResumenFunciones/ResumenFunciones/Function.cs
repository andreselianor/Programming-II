namespace ResumenFunciones
{
    public class Function
    {
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

        // Funcion Auxiliar que devuelve verdadero si es un número par
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }

        // Funcion euxiliar que devuelve verdadero si es un numero impar
        public static bool IsOdd(int number)
        {
            return (number % 2 != 0);
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

        // Funcion que devuelve si un numero es Primo
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;

                // ES UN ERROR ELIMINATORIO ESCRIBIR UN RETURN DENTRO DE UN BUCLE FOR!!!!
                // return true;
            }
            return true;
        }


        // Funcion que devuelve la serie Collatz
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

        // Funcion que ejecuta un SWAP(intercambio) entre dos elementos
        public static void Swap(List<int> list)
        {
            int aux;
            aux = list[0];
            list[0] = list[1];
            list[1] = aux;
        }

        // Funcion que ejecuta un SORT(ordenar) una lista
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
                return null;

            int[] result;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (IsEven(array[i]))
                    count++;
            }

            result = new int[count];
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
    }
}
