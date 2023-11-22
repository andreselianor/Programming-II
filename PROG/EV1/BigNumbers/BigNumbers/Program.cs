namespace BigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            BigNumber test1 = new BigNumber(45000);
            BigNumber test2 = new BigNumber(3500);
            BigNumber test3 = new BigNumber(1500);
            BigNumber test4 = new BigNumber(2500);

            List<BigNumber> listSum = new List<BigNumber>();
            listSum.Add(test1);
            listSum.Add(test2);
            listSum.Add(test3);
            listSum.Add(test4);

            BigNumber result;
            result = BigNumber.AddList(listSum);
            */

            BigNumber test1 = new BigNumber(1800000);
            BigNumber test2 = new BigNumber(400);
            BigNumber result = BigNumber.Mul(test1, test2);
            result.ShowBigNumberReverse();
        }
    }
}