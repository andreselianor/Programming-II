namespace MedievalGame
{
    public class Utils
    {
        private static Random random = new Random();

        public static int GetRandomInt(int min, int max)
        {
            return random.Next(min, max);
        }

        public static double GetRandomDouble(int min, int max)
        {
            return random.NextDouble() * (max - min) + min;
        }

        public static double GetRandomDouble()
        {
            return random.NextDouble();
        }
    }
}
