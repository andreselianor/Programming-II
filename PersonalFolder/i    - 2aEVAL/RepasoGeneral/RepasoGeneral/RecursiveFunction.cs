namespace RepasoGeneral
{
    public static class RecursiveFunctionStatic
    {
        public static int GetRecursiveSum(int number)
        {
            if (number * number > 10)
                return number;
            return GetRecursiveSum(number + 1);
        }

        public static int GetProductory(int number)
        {            
            if (number == 1)
                return number;
            return GetProductory(number - 1) * number;
        }

        public static int GetSumatory(int number)
        {
            if (number <= 1)
                return number;
            return GetSumatory(number - 1) + number;
        }
        public static int GetPow(int number, int pow)
        {
            if (pow <= 1)
                return number;
            return GetPow(number, pow - 1) * number;
        }
    }

    public class RecursiveFunction
    {

    }
}