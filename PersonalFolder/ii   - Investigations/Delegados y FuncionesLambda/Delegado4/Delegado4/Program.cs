namespace Delegado4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte1
            Calculo c1 = new Calculo();

            c1.CalculateResult();
            int number = c1.result;

            c1.CalculateResultDelegate1(() => 25);
            int number1 = c1.result;

            c1.CalculateResultDelegate2((ndelegate2) => 200);
            int number2 = c1.result;

            c1.CalculateResultDelegate3((ndelegate3) => 200);
            int number3 = c1.result;

            c1.CalculateResultDelegate4((ndelegate4) => 200 + ndelegate4);
            int number4 = c1.result;

            c1.CalculateResultDelegate5((ndelegate5) => 200 + ndelegate5);
            int number5 = c1.result;
            #endregion

            #region Parte2

            int result;
            //int number10 = 1;
            //int number20 = 2;
            result = CalculoStatic.CalculateSum((number10, number20) => number10 * number20, 20, 30);


            #endregion
        }
    }
}