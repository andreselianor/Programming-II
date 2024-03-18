namespace AutosLocos
{
    public static class Utils
    {
        private static Random random = new Random();

        public static double GetRandom()
        {
            return random.NextDouble();
        }
    }
}
