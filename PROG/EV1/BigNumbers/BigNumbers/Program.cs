namespace BigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigNumber test1 = new BigNumber(125);
            BigNumber test2 = new BigNumber(875);
            BigNumber result;
            result = BigNumber.Sum(test1, test2);

            result.ShowBigNumberReverse();
        }
    }
}