namespace BigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigNumber test1 = new BigNumber(125);

            test1.ShowBigNumberRow();
            

            BigNumber test2 = new BigNumber(156789123);

            test2.ShowBigNumberRow();


            BigNumber test4 = BigNumber.Sum(test1, test2);
            test4.ShowBigNumberRow();
        }
    }
}