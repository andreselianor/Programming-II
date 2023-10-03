using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public class Functions
    {
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
    }
}
