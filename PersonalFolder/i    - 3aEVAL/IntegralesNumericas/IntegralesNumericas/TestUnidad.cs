namespace IntegralesNumericas
{
    public class TestUnidad
    {
        public static double Test1()
        {
            // Hallar el area de un rectangulo de 5 de largo * 1 m de alto;

            // Valor esperado = 5

            // La funcion es f(x) = 1;

            double result = Integral.GetAreaWithIntegral(x =>
            {
                return 1;
            },0.0, 5.0, 0.001);

            return result;
        }

        public static double Test2()
        {
            // Hallar el area de la curva x elevado a 2

            // Valor esperado, entre 0 y 5 
            // [0] = 0
            // [1] = 1
            // [2] = 4
            // [3] = 9
            // [4] = 16
            // [5] = 25
            // Total = 0 + 1 + 4 + 9 + 16 + 25 = 55

            double result = Integral.GetAreaWithIntegral(x =>
            {
                return x * x;
            }, 0.0, 5.0, 1.0);

            return result;
        }
    }
}