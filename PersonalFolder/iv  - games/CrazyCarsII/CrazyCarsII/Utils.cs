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
            if (result < 0.2)
                return 0;
            if (result < 0.4)
                return 1;
            if (result < 0.6)
                return 2;
            if (result < 0.8)
                return 3;
            if (result < 0.9)
                return 4;
            if (result < 1.0)
                return 5;
            return 3;
        }
    }
}
