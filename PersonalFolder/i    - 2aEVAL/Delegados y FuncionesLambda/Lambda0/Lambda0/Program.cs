using System.Threading.Channels;

namespace Lambda0
{
    public delegate void DelegateString();
    public delegate bool DelegatePositives(int number);
    public delegate bool DelegateMajor(int number1, int number2);

    internal class Program
    {
        static void Main(string[] args)
        {
            DelegateString delegado1 = new DelegateString(() => Console.WriteLine("prueba de lambda1"));
            delegado1();

            DelegatePositives delegado2 = new DelegatePositives((number1) => number1 >= 0);
            delegado2(5);

            DelegateMajor delegado3 = new DelegateMajor((number1, number2) => number1 > number2);
            delegado3(1, 5);
        }
    }
}