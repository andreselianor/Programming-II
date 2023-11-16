using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public class Functions
    {
        // FUNCION que devuelve el numero de los valores de una lista mayores de 0
        public static int GetGreaterThanZero(List<double> list)
        {
            int result = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                    result++;
            }
            return result;
        }

        public static int GetGreaterThanZero(double[] list)
        {
            int result = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > 0)
                    result++;
            }
            return result;
        }

        // FUNCION que devuelve true si una lista contiene un numero dado
        public static bool ContainsNumber(List<int> list, int number)
        {
            if (list == null)               //  COMPROBACION DE QUE LA LISTA NO ES NULL
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
                // return -1;
                return int.MinValue;                //  retorno de valor minimo para numeros dentro de la lista

            int result = list[0];
            for (int i = 0; i < list.Count; i++)    //  cuidado con inicializar el for => for(int i = 1; i < list.Count; i++)
            {
                if (list[i] > result)
                    result = list[i];
            }
            return result;
        }

        // FUNCION que devuelve el índice del numero mayor
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
        public static List<int> SortPersonal(List<int> list)
        {
            if (list == null || list.Count == 0)
                throw new Exception("Error de parametros");

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

        // FUNCION Binary Search
        // TODO : funcionamiento TODO
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

        public static double GetAverage(double[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            double aux = 0.0;

            for (int i = 0; i < array.Length; i++)
            {
                aux += array[i];
            }
            return aux / array.Length;
        }

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

        public static void Swap(List<int> list)
        {
            int aux;
            aux = list[0];
            list[0] = list[1];
            list[1] = aux;

        }

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
    }
}
