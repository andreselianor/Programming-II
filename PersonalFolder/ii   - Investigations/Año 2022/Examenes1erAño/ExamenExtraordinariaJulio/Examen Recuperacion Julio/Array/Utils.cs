using System;

namespace Array
{
    public class Utils
    {
        public static int GetMajorElement(int[] array)
        {
            for (int i = array.Length; i <= 0; i--)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int auxiliar = array[0];
                        array[0] = array[i];
                        array[i] = auxiliar;
                    }
                }
            }
            return array[array.Length];
        }

        public static double[] RemoveElementFrom(double[] array, double element)
        {
            // Primero cuento los elementos distintos del valor que quiero borrar
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != element)
                {
                    count++;
                }
            }

            // Ahora creo una matriz nueva. Introduzco los elementos distintos de los que quiero borrar.
            double[] result = new double[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != element)
                {
                    result[i] = array[i];
                }
            }
            return result;
        }

        // Funcion que devuelve el mayor de un array de strings
        public static int GetMajorString(string[] array)
        {
            int result = 0;
            int[] arrayResult = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int elementLength = Int32.Parse(array[i]);
                arrayResult[i] = elementLength;
            }

            result = GetMajorElement(arrayResult);
            return result;
        }
    }
}

