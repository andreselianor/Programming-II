namespace Funciones
{
    public class Functions
    {

        #region FUNCION 1

        /// <summary>
        /// OPCION 1:
        /// Funcion que devuelve si el segundo parametro es mayor que el primer parametro
        /// </summary>
        /// <param name="value1">Primer Parametro</param>
        /// <param name="value2">Segundo Parametro</param>
        /// <returns>Verdadero/Falso</returns>
        /// 

        public static bool IsGreaterSecondValue1(int value1, int value2)
        {
            if (value1 < value2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // OPCION 2:

        public static bool IsGreaterSecondValue2(int value1, int value2)
        {
            if (value1 < value2)
                return true;
            else
                return false;
        }

        // OPCION 3:

        public static bool IsGreaterSecondValue3(int value1, int value2)
        {
            if (value1 < value2)
                return true;
            return false;
        }

        // OPCION 4:

        public static bool IsGreaterSecondValue4(int value1, int value2)
        {
            return (value1 < value2);
        }
        #endregion

        #region FUNCION 2

        /// <summary>
        /// Funcion que devuelve si un número es par o no es par.
        /// </summary>
        /// <param name="value">numero</param>
        /// <returns>Verdadero/Falso</returns>
        /// 

        public static bool IsEven(int value)
        {
            return (value % 2 == 0);
        }
        #endregion



        #region FUNCION 3 

        /// <summary>
        /// Funcion que devuelve el mayor de 3 numeros enteros
        /// </summary>
        /// <param name="value1">numero entero 1</param>
        /// <param name="value2">numero entero 2</param>
        /// <param name="value3">numero entero 3</param>
        /// <returns>numero entero mayor</returns>
        /// 

        public static int GetMajorNumber(int value1, int value2, int value3)
        {
            if (value1 > value2 && value1 > value3)
                return value1;
            else if (value2 > value3)
                return value2;
            else
                return value3;
        }

        #endregion
    }
}
