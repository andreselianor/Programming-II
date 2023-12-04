using System.Runtime.InteropServices;

namespace Classes
{
    public class BigNumber
    {
        private List<int> _list = new List<int>();



        #region Constructores
        public BigNumber(long bigNumber)
        {
            SetLong(bigNumber);
        }

        public BigNumber(string bigNumber)
        {
            SetString(bigNumber);
        }

        public BigNumber()
        {

        }
        #endregion



        #region Set BigNumber
        public void SetLong(long bigNumber)
        {
            int digit;

            while (bigNumber > 0)
            {
                digit = (int)bigNumber % 10;
                bigNumber = (int)bigNumber / 10;

                _list.Add(digit);
            }
        }

        public void SetString(string bigNumberString)
        {
            int bigNumberCount = 0;
            foreach (char c in bigNumberString)
            {
                bigNumberCount++;
            }

            for (int i = bigNumberCount - 1; i >= 0; i--)
            {
                _list.Add(bigNumberString[i]);
            }
        }
        #endregion



        #region GetDigits
        public int GetDigitCount()
        {
            return _list.Count;
        }

        public int GetDigitAt(int index)
        {
            return _list[index];
        }

        public List<int> GetBigNumber()
        {
            return _list;
        }

        override public string? ToString()
        {
            return _list.ToString();
        }
        #endregion


        #region Clone
        public BigNumber Clone(BigNumber bigNumber)
        {
            return bigNumber;
        }

        public BigNumber CloneV2()
        {
            BigNumber bigNumber = new BigNumber();
            bigNumber._list = _list;
            return bigNumber;
        }
        #endregion



        #region Display
        public void ShowBigNumber()
        {
            foreach (int number in _list)
            {
                Console.Write(number);
            }
            Console.WriteLine("\n");
        }

        public void ShowBigNumberReverse()
        {

            for (int i = _list.Count - 1; i >= 0; i--)
            {
                Console.Write(_list[i]);
            }

            Console.WriteLine("\n");
        }
        #endregion



        #region Calculate
        // Función que realiza la suma de dos BigNumbers
        public static BigNumber Add(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            BigNumber bigNumberResult = new BigNumber();

            // Recogemos el número de dígitos de cada operando
            int Count1 = bigNumber1.GetDigitCount();
            int Count2 = bigNumber2.GetDigitCount();

            // El operando de mayor número de digitos se coloca arriba
            int MaxDigitsBigNumber = GetMaxCountBigNumber(Count1, Count2);

            int operatorSum1;
            int operatorSum2;
            int operatorRest = 0;
            int result;


            // Añado ceros si el número tiene menos dígitos que el máximo.
            for (int i = 0; i < MaxDigitsBigNumber; i++)
            {
                if (i >= Count1)
                    operatorSum1 = 0;
                else
                    operatorSum1 = bigNumber1._list[i];

                if (i >= Count2)
                    operatorSum2 = 0;
                else
                    operatorSum2 = bigNumber2._list[i];


                // Funcion que realiza la suma de cada operando
                result = MakeSum(operatorSum1, operatorSum2, operatorRest);


                // Si supera el 9 se resta una decena a la suma.
                if (result > 9)
                {
                    operatorRest = GetRest(result);
                    result -= 10;
                }

                // añade el resultado a la lista de BigNumber
                bigNumberResult._list.Add(result);
            }

            if (operatorRest > 0)
                bigNumberResult._list.Add(operatorRest);

            return bigNumberResult;
        }

        // Devuelve el operando de mayor tamaño.
        public static int GetMaxCountBigNumber(int Count1, int Count2)
        {
            return Count1 > Count2 ? Count1 : Count2;
        }


        // Función que realiza la suma de los operandos.
        public static int MakeSum(int operator1, int operator2, int operatorRest)
        {
            return operator1 + operator2 + operatorRest;
        }


        // Función que devuelve el número de decenas que pasan de 9
        public static int GetRest(int number)
        {
            int count = 0;

            while (number >= 9)
            {
                number -= 10;
                count++;
            }
            return count;
        }

        // Función que añade un valor a la lista resultado de BigNumber
        public static BigNumber AddNumbersList(List<BigNumber> listBigNumbers)
        {
            int BigNumberCount = listBigNumbers.Count;

            BigNumber result = listBigNumbers[0];

            for (int i = 1; i < BigNumberCount; i++)
            {
                result = Add(result, listBigNumbers[i]);
            }

            return result;
        }

        // Función que realiza la multiplicacion de dos 'BigNumber'
        public static BigNumber Mul(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            BigNumber bigNumberResult;

            // Se ordenan los operandos, el 'BigNumber' mayor arriba y el 'BigNumber' menor abajo.
            BigNumber BiggerMultOperator = GetBiggerOperando(bigNumber1, bigNumber2);
            BigNumber SmallerMultOperator = BiggerMultOperator == bigNumber1 ? bigNumber2 : bigNumber1;

            // Se crea una lista con los operandos que se suman en las lineas de resultado.
            List<BigNumber> listOperators;
            listOperators = GetListOperators(BiggerMultOperator, SmallerMultOperator);

            // Se añaden ceros a las líneas que se suman
            for (int i = 0; i <= SmallerMultOperator.GetDigitCount() - 1; i++)
            {
                listOperators[i] = InsertZero(listOperators[i], i);
            }
            bigNumberResult = AddNumbersList(listOperators);

            return bigNumberResult;
        }

        // Función que devuelve el 'BigNumber' de mayor valor
        public static BigNumber GetBiggerOperando(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            int Count1 = bigNumber1.GetDigitCount();
            int Count2 = bigNumber2.GetDigitCount();

            return Count1 > Count2 ? bigNumber1 : bigNumber2;
        }

        // Funcion que crea una lista
        public static List<BigNumber> GetListOperators(BigNumber BiggerMultOperator, BigNumber SmallerMultOperator)
        {
            List<BigNumber> listResult = new List<BigNumber>();
            BigNumber bigNumberResult;

            for (int i = 0; i < SmallerMultOperator.GetDigitCount(); i++)
            {
                bigNumberResult = MulOperation(BiggerMultOperator, SmallerMultOperator._list[i]);
                listResult.Add(bigNumberResult);
            }
            return listResult;
        }

        // Funcion que realiza la operacion de la multiplicacion de un 'BigNumber' con el valor del operando de menor tamaño.
        public static BigNumber MulOperation(BigNumber bignumber, int number)
        {
            BigNumber resultBigNumber = new BigNumber();
            int result;
            int rest = 0;
            foreach (int i in bignumber._list)
            {
                result = i * number + rest;
                while (result >= 9)
                {
                    rest++;
                    result -= 10;
                }
                resultBigNumber._list.Add(result);
            }
            return resultBigNumber;
        }

        // Función que añade ceros a las lineas de resultado de la multiplicación.
        public static BigNumber InsertZero(BigNumber bigNumber, int ZeroCount)
        {
            BigNumber result = new BigNumber();

            for (int i = 0; i < ZeroCount; i++)
            {
                result._list.Add(0);
            }
            for (int i = 0; i < bigNumber.GetDigitCount(); i++)
            {
                result._list.Add(bigNumber._list[i]);
            }
            return result;
        }


        // Función que ordena los sumandos
        public static BigNumber Sub(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            BigNumber bigNumberResult;

            BigNumber BiggerMultOperator = GetBiggerOperando(bigNumber1, bigNumber2);
            BigNumber SmallerMultOperator = BiggerMultOperator == bigNumber1 ? bigNumber2 : bigNumber1;

            bigNumberResult = SubOperation(BiggerMultOperator, SmallerMultOperator);

            return bigNumberResult;
        }

        // Funcion que realiza la resta
        public static BigNumber SubOperation(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            BigNumber bigNumberResult = new BigNumber();
            int subCount = bigNumber1.GetDigitCount();
            int operatorUpper;
            int operatorLower;

            int countRestDown = 0;
            int result;


            for (int i = 0; i < subCount; i++)
            {
                operatorUpper = bigNumber1.GetDigitAt(i);

                if (i >= bigNumber2.GetDigitCount())
                    operatorLower = 0;
                else
                    operatorLower = bigNumber2.GetDigitAt(i);

                operatorLower += countRestDown;

                if (operatorUpper >= operatorLower)
                {
                    result = operatorUpper - operatorLower;
                    bigNumberResult._list.Add(result);
                    countRestDown = 0;
                }
                else
                {
                    countRestDown = 1;
                    result = (10 + operatorUpper) - operatorLower;
                    bigNumberResult._list.Add(result);
                }
            }

            return bigNumberResult;

        }


        #endregion
    }
}

