namespace ExamenRugby
{
    public static class Utils
    {
        private static Random _random = new Random();

        public static double GetRandom()
        {
            return _random.NextDouble();
        }

        public static double GetRandom(double start, double end)
        {
            return start + _random.NextDouble() * end;
        }

        public static int GetRandomInt(int end)
        {
            return _random.Next(end);
        }

        public static int GetRandomInt(int start, int end)
        {
            return _random.Next(start, end);
        }

        public static (int, int) DistancetoBall(int x1, int y1, int x2, int y2)
        {
            return (x1 - x2, y1 - y2);
        }
    }
}
