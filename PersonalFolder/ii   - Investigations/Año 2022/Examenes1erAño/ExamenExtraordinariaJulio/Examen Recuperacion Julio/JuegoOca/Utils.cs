using System;

namespace JuegoOca
{
    public class Utils
    {
        private static Random random = new Random();

        public static int GetRandom()
        {
            return random.Next(1,7);
        }
    }
}
