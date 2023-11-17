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
            long nextBigNumber;
            int numberList;

            while(bigNumber > 0)
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
            foreach(char c in bigNumberString)
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
            foreach(int number in _list)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine("\n");
        }

        public void ShowBigNumberRow()
        {
            foreach (int number in _list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");

        }
        #endregion

        #region Funciones Calculate
        public static BigNumber Sum(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            BigNumber bigNumberResult = new BigNumber();
            int result;

            for(int i = 0; i < 10; i++)
            {
                int number1 = 0, number2 = 0;

                if(bigNumber1.GetDigitCount() > i)
                {
                    number1 = bigNumber1.GetDigitAt(i);
                }

                if (bigNumber2.GetDigitCount() > i)
                {
                    number2 = bigNumber2.GetDigitAt(i);
                }

                result = number1 + number2;
                bigNumberResult._list.Add(result);
            }
            return bigNumberResult;
        }

        #endregion










    }
}
