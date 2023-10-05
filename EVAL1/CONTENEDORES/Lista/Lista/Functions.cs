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
        public static List<int> Sort(List<int> list)
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

        public static bool BinarySearch(List<int> list, int number)
        {
            int minIndex = 0;
            int minValue = list[0];

            int maxIndex = list.Count;
            int maxValue = list[list.Count];

            int midIndex = (minIndex + maxIndex) / 2;
            int midValue = list[midIndex];            

            while (midValue != midIndex || minIndex > maxIndex)
            {
                if (number > minValue)
                {
                    minIndex = list[minIndex];
                    midIndex = (minIndex + maxIndex) / 2;
                }

                if ( number < maxValue)
                {
                    maxIndex = list[maxIndex];
                    maxIndex = (minIndex + maxIndex) / 2;
                }

                if( number == midValue)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool BinarySearch(int[] array , int number)
        {

            if(array == null || array.Length == 0)
            {
                return false;
            }

            int minIndex = 0;
            int minValue = array[0];

            int maxIndex = array.Length - 1;
            int maxValue = array[array.Length - 1];

            int midIndex = (minIndex + maxIndex) / 2;
            int midValue = array[midIndex];

            while (midValue != number || minIndex < maxIndex ||
                   number < minValue  || number > maxValue)
            {
                if (number > minValue)
                {
                    minIndex = midIndex;
                    midIndex = (minIndex + maxIndex) / 2;
                }

                if (number < maxValue)
                {
                    maxIndex = midIndex;
                    maxIndex = (minIndex + maxIndex) / 2;
                }

                if (number == midValue)
                {
                    return true;
                }

                if (number == minValue || number == maxValue)
                {
                    return true;
                }

                if(minIndex == maxIndex)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
