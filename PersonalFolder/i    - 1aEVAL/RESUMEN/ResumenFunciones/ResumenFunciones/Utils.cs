namespace ResumenFunciones
{
    public class Utils
    {
        private static Random random = new Random();
        public static int GetRandom(int min, int max)
        {            
            return random.Next(min, max);
        }
    }
}
