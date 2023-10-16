namespace DragonBall
{
    public class Utils
    {
        public static double GetRandom(double min, double max)
        {
            Random number = new Random();
            return (min + (number.NextDouble() * (max - min)));
        }


        private double _random;

        public void GetRandom2(double min, double max)
        {
            Random randomNumber = new Random();
            _random = (min + (randomNumber.NextDouble() * max));
        }
    }
}
