using System.Runtime.InteropServices;

namespace BigNumbers
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
        public BigNumber Clone()
        {
            return this;
        }

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
        public static BigNumber Sum(BigNumber bigNumber1, BigNumber bigNumber2)
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
                if (i > Count1)
                    operatorSum1 = 0;
                else
                    operatorSum1 = bigNumber1._list[i];

                if (i > Count2)
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

        /*
        public static BigNumber Sum(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            BigNumber bigNumberResult = new BigNumber();

            int resultPartialSum;
            int restPartialSum;
            int result;

            int longitud1 = bigNumber1.GetDigitCount();
            int longitud2 = bigNumber2.GetDigitCount();


            int longitud = GetSumNumbersDigit(bigNumber1, bigNumber2);
            int count = 0;

            while (count <= longitud)
            {
                if(longitud1 > count && longitud2 > count)
                {
                    resultPartialSum = bigNumber1._list[count] + bigNumber2._list[count];
                    restPartialSum = resultPartialSum > 9 ? resultPartialSum / 10 : resultPartialSum;

                    bigNumberResult._list.Add(result);
                    count++;
                }

                else if (longitud1 > count && longitud2 < count)
                {
                    bigNumberResult._list.Add(bigNumber2._list[count]);
                    count++;
                }

                else if (longitud1 < count && longitud2 > count)
                {
                    bigNumberResult._list.Add(bigNumber1._list[count]);
                    count++;
                }

                else
                {
                    bigNumberResult._list.Add(1);
                    count++;
                }

            }
            return bigNumberResult;
        }

        public static int GetSumNumbersDigit(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            int longitud1 = bigNumber1.GetDigitCount();
            int longitud2 = bigNumber2.GetDigitCount();

            return longitud1 > longitud2 ? longitud1 : longitud2;
        }
        */
        #endregion
    }
}
