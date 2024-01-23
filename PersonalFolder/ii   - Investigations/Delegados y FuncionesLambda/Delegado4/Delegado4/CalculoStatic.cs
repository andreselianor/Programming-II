namespace Delegado4
{
    public static class CalculoStatic
    {
        public delegate int delegateStatic(int n1, int n2);

        public static int CalculateSum(delegateStatic del, int a, int b)
        {
            int n1 = 3;
            int n2 = 7;
            return (a + b) * del(n1,n2);
        }
    }
}
