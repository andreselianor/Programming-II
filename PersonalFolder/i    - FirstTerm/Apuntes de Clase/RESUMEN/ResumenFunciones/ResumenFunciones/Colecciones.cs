namespace ResumenFunciones
{
    public class Colecciones
    {
        // FUNCION que devuelve el numero de los valores de una lista mayores de 0
        public static int GetGreaterThanZero(List<double> list)
        {
            if (list == null || list.Count == 0)
                return 0;

            int result = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                    result++;
            }
            return result;
        }

        // FUNCION que devuelve el numero de los valores de un array mayores de 0
        public static int GetGreaterThanZero(double[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    result++;
            }
            return result;
        }

        // FUNCION que devuelve true si una lista contiene un numero dado
        public static bool ContainsNumber(List<int> list, int number)
        {
            if (list == null)
                return false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == number)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Como documentar funciones:
        /// Funcion que devuelve el mayor valor de una lista de enteros
        /// </summary>
        /// <param name="list">lista de enteros</param>
        /// <returns>numero mas alto, si l es igual a null, devuelve int.MinValue</returns>
        public static int GetMajor(List<int> list)
        {
            if (list == null || list.Count == 0)
                return int.MinValue;                //  retorno de valor minimo para numeros dentro de la lista

            int result = list[0];
            for (int i = 0; i < list.Count; i++)    //  cuidado con inicializar el for => for(int i = 1; i < list.Count; i++)
            {
                if (list[i] > result)
                    result = list[i];
            }
            return result;
        }

        public static int GetMinor(List<int> list)
        {
            if (list == null || list.Count == 0)
                return 0;

            int result = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < result)
                    result = list[i];
            }
            return result;
        }

        // FUNCION que devuelve el índice del numero mayor de una lista
        public static int GetIndexMajor(List<int> list)
        {
            if (list == null || list.Count == 0)
                return -1;                          //  retorno de -1 para indices

            int index = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GetMajor(list))      // recorre la lista y luego la vuelve a recorrer. Esto no es del todo correcto
                    index = i;
            }
            return index;
        }

        public static int GetIndexMajor2(List<int> list)
        {
            if (list == null || list.Count == 0)
                return -1;

            int index = 0;
            int aux = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > aux)
                {
                    index = i;
                    aux = list[i];
                }
            }
            return index;
        }


        // FUNCION que devuelve true si una lista está ordenada de forma ascendente
        public static bool IsOrdered(List<int> list)
        {
            if (list == null || list.Count == 0)
                return false;

            bool result = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                    result = false;
            }
            return result;
        }


        // FUNCION que ordena una lista de forma ascendente
        // TODO: Ordenar una lista de forma ascendente
        public static List<int>? SortPersonal(List<int> list)
        {
            if (list == null || list.Count == 0)
                return null;

            List<int> result = new List<int>();
            int aux;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = list.Count - 1; j > 0; j--)
                {
                    if (list[j] < list[j - 1])
                    {
                        aux = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = aux;
                    }
                }
                result.Add(list[i]);
            }

            return result;
        }

        // FUNCION Binary Search con listas
        // TODO: Binary Search
        public static bool BinarySearch(List<int> list, int number)
        {
            if (list == null || list.Count == 0)
                return false;

            int minPosition = 0;
            int maxPosition = list.Count - 1;
            int midPosition;

            while (minPosition <= maxPosition)
            {
                midPosition = (minPosition + maxPosition) / 2;

                if (list[midPosition] == number)
                    return true;

                if (number > list[midPosition])
                    minPosition = midPosition + 1;
                else
                    maxPosition = midPosition - 1;
            }
            return false;
        }

        // FUNCION Binary search con arrays
        public static bool BinarySearch(double[] array, double number)
        {
            if (array == null || array.Length == 0)
                return false;

            int minPosition = 0;
            int maxPosition = array.Length - 1;
            int midPosition;

            while (minPosition <= maxPosition)
            {
                midPosition = (minPosition + maxPosition) / 2;

                if (array[midPosition] == number)
                    return true;

                if (number > array[midPosition])
                    minPosition = midPosition + 1;
                else
                    maxPosition = midPosition - 1;
            }
            return false;
        }

        // FUNCION que devuelve el valor medio de un array
        public static double GetAverage(double[] array)
        {
            if (array == null || array.Length == 0)
                return double.NaN;

            double aux = 0.0;

            for (int i = 0; i < array.Length; i++)
            {
                aux += array[i];
            }
            return aux / array.Length;
        }

        // FUNCION que devuelve el mayor medio de los elementos de un array que superen el threshold
        public static double GetThresholdAverage(double[] array, double Threshold)
        {
            if (array == null || array.Length == 0)
                return double.NaN;

            double aux = 0.0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Threshold)
                {
                    aux += array[i];
                    count++;
                }
            }

            if (count == 0)
                return double.NaN;

            return aux / count;
        }

        // FUNCION que devuelve el numero de repeticiones de valores de una lista
        public static int GetMaxNumberRepeated(List<int> list)
        {
            int result = 0;
            int maxNumber;
            maxNumber = GetMajor(list);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == maxNumber)
                    result++;
            }
            return result;
        }

        // FUNCION que ordena los elementos de una lista de forma inversa
        public static List<int> GetReverseList(List<int> list)
        {
            if (list == null || list.Count < 0)
                return new List<int>();

            List<int> result = new List<int>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                result.Add(list[i]);
            }
            return result;
        }

        // FUNCION reverse con arrays
        public static int[] GetReverseList(int[] array)
        {
            int[] result = new int[array.Length];
            int cont = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                result[cont] = array[i];
                cont++;         // ESTA MAL
            }
            return result;

        }

        // FUNCION para imprimir series
        public static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public static void PrintList(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        // FUNCION que añade un valor a un array
        // TODO: Añadir un valor a un array
        public static int[] AddValuetoArray(int[] array, int number)
        {
            if (array == null)
            {
                int[] output = new int[1];
                output[0] = number;
                return output;
            }

            int[] result = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }
            result[array.Length] = number;
            return result;
        }

        // FUNCION que elimina un elemento de la posicion indicada de una lista de enteros
        // TODO: Funcion que elimina el valor que está en una posicion indicada
        public static void RemovePosition(List<int> list, int index)
        {
            if (list == null)
                return;
            list.RemoveAt(index);
            // list.Remove(index); Elimina el valor que es igual a index
        }

        // FUNCION que elimina un valor que le paso por parametros de la lista
        public static void RemoveElement(List<int> list, int value)
        {
            if (list == null)
                return;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        // FUNCION anterior que utiliza la ruptura BREAK
        public static void RemoveElementBreak(List<int> list, int value)
        {
            if (list == null)
                return;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    list.RemoveAt(i);
                    i--;
                    break;      // Rompe el bucle dentro del cual esta metido
                }
            }
        }

        // FUNCION que borra un elemento de un array
        // TODO Examen
        public static bool IsDequal(int number1, int number2)
        {
            return (number1 != number2);
        }

        public static int CountArray(int[] array, int value)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (IsDequal(array[i], value))
                    count++;
            }
            return count;
        }

        public static void MakeArray(int[] array, int value)
        {
            int capacity = CountArray(array, value);
            int[] result = new int[capacity];
            for (int i = 0; i < capacity; i++)
                if (IsDequal(value, array[i]))
                    result[i] = value;
        }

        // FUNCION que elimina de una lista, una lista de valores
        public static void RemoveValues(List<int> list, List<int> listValues)
        {
            if (list == null)
                return;

            for (int j = 0; j < listValues.Count; j++)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == list[j])
                        list.RemoveAt(i--);
                }
            }
        }

        public static void RemoveValuesAlter(List<int> list, List<int> listValues)
        {
            if (list == null)
                return;

            for (int i = 0, j = 0; i < listValues.Count; i++)
            {
                while(j < listValues.Count)
                {
                    if (list[i] == listValues[j])
                        list.RemoveAt(i--);
                    j++;
                }
                j = 0;
            }
        }
    }
}