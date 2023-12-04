using System.Runtime.InteropServices;

namespace Classes
{
    public class BigNumber
    {
        private List<int> _list = new List<int>();



        #region Constructores
        public BigNumber(long bigNumber)
        {
            Set(bigNumber);
        }

        public BigNumber(string bigNumber)
        {
            Set(bigNumber);
        }

        public BigNumber()
        {

        }
        #endregion



        #region Set BigNumber
        public void Set(long bigNumber)
        {
            int digit;

            while (bigNumber > 0)
            {
                digit = (int)bigNumber % 10;
                bigNumber = (int)bigNumber / 10;

                _list.Add(digit);
            }
        }

        public void Set(string bigNumberString)
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
        public static BigNumber Add(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            BigNumber bigNumberResult = new BigNumber();

            int Count1 = bigNumber1.GetDigitCount();
            int Count2 = bigNumber2.GetDigitCount();

            int numberDigitsBigNumber = GetMaxCountBigNumber(Count1, Count2);

            int operatorSum1;
            int operatorSum2;
            int operatorRest = 0;
            int result;

            for (int i = 0; i < numberDigitsBigNumber; i++)
            {
                if (i >= Count1)
                    operatorSum1 = 0;
                else
                    operatorSum1 = bigNumber1._list[i];

                if (i >= Count2)
                    operatorSum2 = 0;
                else
                    operatorSum2 = bigNumber2._list[i];


                result = MakeSum(operatorSum1, operatorSum2, operatorRest);

                if (result > 9)
                {
                    operatorRest = GetRest(result);
                    result -= 10;
                }

                bigNumberResult._list.Add(result);
            }
            if (operatorRest > 0)
                bigNumberResult._list.Add(operatorRest);

            return bigNumberResult;
        }

        public static int GetMaxCountBigNumber(int Count1, int Count2)
        {
            return Count1 > Count2 ? Count1 : Count2;
        }

        public static int MakeSum(int operator1, int operator2, int operatorRest)
        {
            return operator1 + operator2 + operatorRest;
        }

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

        public static BigNumber Mul(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            BigNumber bigNumberResult;

            BigNumber BiggerMultOperator = GetBiggerOperando(bigNumber1, bigNumber2);
            BigNumber SmallerMultOperator = BiggerMultOperator == bigNumber1 ? bigNumber2 : bigNumber1;

            List<BigNumber> listOperators;
            listOperators = GetListOperators(BiggerMultOperator, SmallerMultOperator);

            for (int i = 0; i <= SmallerMultOperator.GetDigitCount() - 1; i++)
            {
                listOperators[i] = InsertZero(listOperators[i], i);
            }
            bigNumberResult = AddNumbersList(listOperators);

            return bigNumberResult;
        }

        public static BigNumber GetBiggerOperando(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            int Count1 = bigNumber1.GetDigitCount();
            int Count2 = bigNumber2.GetDigitCount();

            return Count1 > Count2 ? bigNumber1 : bigNumber2;
        }

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

        public static BigNumber Sub(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            BigNumber bigNumberResult;

            BigNumber BiggerMultOperator = GetBiggerOperando(bigNumber1, bigNumber2);
            BigNumber SmallerMultOperator = BiggerMultOperator == bigNumber1 ? bigNumber2 : bigNumber1;

            bigNumberResult = SubOperation(BiggerMultOperator, SmallerMultOperator);

            return bigNumberResult;
        }
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

