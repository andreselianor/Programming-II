namespace Dolphin01
{
    public class Utils
    {
        public static Random random = new Random();

        public static double GetRandom(double value)
        {               
            return (random.NextDouble() * value);
        }
    }
}
