namespace CrazyCarsII
{
    public class Utils
    {
        private static Random random = new Random();

        public static double GetRandomDouble()
        {
            return random.NextDouble();
        }

        public static int SelectReport()
        {
            double result = Utils.GetRandomDouble();
            if (result < 0.3)
                return 0;
            if (result < 0.6)
                return 1;
            if (result < 0.9)
                return 2;
            return 3;
        }
    }
}
