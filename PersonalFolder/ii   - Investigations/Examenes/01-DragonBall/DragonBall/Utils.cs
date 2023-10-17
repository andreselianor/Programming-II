namespace DragonBall
{
    public class Utils
    {
        public static double GetRandom(double min, double max)
        {
            Random number = new Random();
            return (min + (number.NextDouble() * (max - min)));
        }
    }
}
