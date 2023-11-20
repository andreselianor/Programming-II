using System.Runtime.InteropServices;

namespace BigNumbers
{
    public class BigNumber
    {
        private List<int> _list = new List<int>();
        private int _restNumber;



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
            long nextBigNumber;
            int numberList;

            while (bigNumber > 0)
            {
                numberList = (int)bigNumber % 10;
                nextBigNumber = (int)bigNumber / 10;

                _list.Add(numberList);
                bigNumber = nextBigNumber;
            }
        }


        public void Set(string bigNumberString)
        {
            int bigNumberCount = 0;
            foreach (char c in bigNumberString)
            {
                bigNumberCount++;
            }

            for (int i = bigNumberCount - 1; i == 0; i--)
            {
                _list.Add(bigNumberString[i]);
            }
        }


        public List<int> GetBigNumber()
        {
            return _list;
        }


        override public string? ToString()
        {
            return _list.ToString();
        }


        // Funciones CLONE
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



        #region GetDigits
        public int GetDigitCount()
        {
            return _list.Count;
        }

        public int GetDigitAt(int index)
        {
            return _list[index];
        }
        #endregion


        #region Utils
        public void ShowBigNumber()
        {
            foreach (int number in _list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
        }

        public void ShowBigNumberReverse()
        {

            for (int i = _list.Count - 1; i >= 0; i--)
            {
                Console.Write(_list[i] + " ");
            }

            Console.WriteLine("\n");
        }

        #endregion

        #region Funciones Calculate


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
        #endregion










    }
}
