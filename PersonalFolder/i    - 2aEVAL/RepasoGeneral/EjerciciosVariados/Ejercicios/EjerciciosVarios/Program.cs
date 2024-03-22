namespace EjerciciosVarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inheritance c1 = new Child(1900);
            int result1 = c1.GetDate();

            Inheritance c2 = new Child(10);
            int result = c2.GetDate();

            Inheritance c3 = new Child(1900);
            int result2 = c3.GetDay();
        }
    }
}
