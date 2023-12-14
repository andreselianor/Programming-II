namespace Ejercicio02
{
    public class Utils
    {
        private static Random random = new Random();

        public static int GetRandom()
        {
            return random.Next(0, 3);
        }
    }
}
