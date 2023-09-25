namespace Dolphin01
{
    public class Utils
    {
        public static Random random = new Random();

        public static int GetRandom(int value)
        {
            return random.Next(value);
        }
    }
}
