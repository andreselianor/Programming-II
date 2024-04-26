namespace IntegralesNumericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result1 = Integral.GetAreaWithIntegral(x =>
            {
                return 2 * x * x * x + x;
            }, 0.0, 5.0, 0.001);

            // Prueba de nivel 1
            double test1 = TestUnidad.Test1();

            // Prueba de nivel 2
            double test2 = TestUnidad.Test2();
        }
    }
}
