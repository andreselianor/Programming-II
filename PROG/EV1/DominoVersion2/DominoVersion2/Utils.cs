namespace DominoVersion2
{
    public class Utils
    {
        private static Random random = new Random();
        public static int getRandomInt(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
