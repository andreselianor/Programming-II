namespace BigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigNumber test1 = new BigNumber(115000);
            BigNumber test2 = new BigNumber(332500);
            
            test1.ShowBigNumberReverse();
            test2.ShowBigNumberReverse();
            Console.WriteLine("***");

            BigNumber result = BigNumber.Sum(test1, test2);
            result.ShowBigNumber();
            result.ShowBigNumberReverse();
        }
    }
}