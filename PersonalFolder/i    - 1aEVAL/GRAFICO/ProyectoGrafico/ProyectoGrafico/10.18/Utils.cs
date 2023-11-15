namespace ProyectoGrafico
{
    public class Utils
    {
        private static Random random = new Random();

        public static double GetRandom()
        {
            return random.NextDouble();
        }

        public static double GetRandomDouble(double min, double max)
        {
            return (min + (random.NextDouble() * (max - min)));
        }
    }
}
