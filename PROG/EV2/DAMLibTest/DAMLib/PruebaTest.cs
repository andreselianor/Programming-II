using static DAMLib.PruebaTest;

namespace DAMLib
{
    public class PruebaTest
    {
        public delegate bool isMajor(int number1, int number2);

        public int number1;
        public int number2;

        isMajor delegado = new isMajor((number1, number2) => number1 > number2);
        

    }
}
