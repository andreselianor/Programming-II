namespace CrazyCars
{
    public class Utils
    {
        private static Random random = new Random();

        public static int GetRandomInt(int min, int max)
        {
            return random.Next(min, max);
        }

        public static double GetRandomDouble()
        {
            return random.NextDouble();
        }

        public static double GetRandomDouble(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }
    }
}
