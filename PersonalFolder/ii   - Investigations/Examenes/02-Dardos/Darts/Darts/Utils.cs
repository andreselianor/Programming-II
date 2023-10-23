namespace Darts
{
    public class Utils
    {
        private static Random random = new Random();
        public static int GetRandom(int min, int max)
        {
            return random.Next(min,max);
        }

        public static double ThrowAbility()
        {
            return random.NextDouble();
        }

        public static int CalculatePuntuation(double number)
        {
            switch (number)
            {
                case < 1:
                    return 0;
                case < 2:
                    return 1;
                case < 3:
                    return 5;
                case < 4:
                    return 10;
                case < 5:
                    return 50;
                case < 6:
                    return 100;
            }
            return 0;
        }
    }
}
