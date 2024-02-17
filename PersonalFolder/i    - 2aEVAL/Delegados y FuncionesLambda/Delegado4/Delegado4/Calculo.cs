namespace Delegado4
{
    public class Calculo
    {
        public delegate int DelegateSum();
        public delegate int DelegateSum1(int number1);

        //public int n1;
        //public int n2;
        public int result;        

        public void CalculateResult()
        {
            result = 10;
        }

        public void CalculateResultDelegate1(DelegateSum del)
        {
            result = del();
        }

        public void CalculateResultDelegate2(DelegateSum1 del)
        {
            int a = 0;
            result = del(a);
        }

        public void CalculateResultDelegate3(DelegateSum1 del)
        {
            int a = 5000;
            result = del(a);
        }

        public void CalculateResultDelegate4(DelegateSum1 del)
        {
            int a = 5000;
            result = del(a);
        }

        public void CalculateResultDelegate5(DelegateSum1 del)
        {
            int a = 10000;
            result = del(a + 300) + 2;
        }
    }
}
