namespace Darts
{
    public class Utils
    {
        private static Random random = new Random();
        public static int GetRandom(int min, int max)
        {
            return random.Next(min,max);
        }

        public static int CalculatePuntuation(int number)
        {
            switch (number)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 5;
                case 3:
                    return 10;
                case 4:
                    return 50;
                case 5:
                    return 100;
                default:
                    return 101;
            }
        }
    }
}
