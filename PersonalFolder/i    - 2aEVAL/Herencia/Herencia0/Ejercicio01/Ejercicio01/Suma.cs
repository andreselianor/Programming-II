namespace Ejercicio01
{
    public class Suma : Calculo
    {
        public double CalculateOperation()
        {
            return Value1 + Value2;
        }

        public void Get()
        {
            Console.WriteLine(Value1.GetType());
        }
    }
}
