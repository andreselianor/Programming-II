namespace Exercism
{
    public class AssemblyLane
    {
        public static double SuccessRate(int speed)
        {
            if (speed == 0)
                return 0.0;
            if (speed < 5)
                return 1.0;
            if (speed < 9)
                return 0.90;
            if (speed == 9)
                return 0.80;
            if (speed == 10)
                return 0.77;
            return 0.0;
        }

        public static double ProductionRatePerHour(int speed) => SuccessRate(speed) * speed * 221.0;

        public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
    }
}

