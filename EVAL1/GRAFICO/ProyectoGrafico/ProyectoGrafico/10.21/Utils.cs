namespace Grafico1
{
    public class Utils
    {
        private static Random random = new Random();
        public static double GetRandom(double min, double max)
        {
            return (min + random.NextDouble() * (max - min));
        }

        public static int GetIntRandom(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
