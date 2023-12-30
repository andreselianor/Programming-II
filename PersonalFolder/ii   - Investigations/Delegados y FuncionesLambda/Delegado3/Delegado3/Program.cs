namespace Delegado3
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Functions funcion1 = new Functions("En un lugar de la mancha, de cuyo nombre no quiero acordarme");
            funcion1.DelegateMethod();

            int a = funcion1.countA;
            int b = funcion1.countN;
            int c = funcion1.countI;




        }

    }
}