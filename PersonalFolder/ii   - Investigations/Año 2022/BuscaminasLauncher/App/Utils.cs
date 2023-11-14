namespace Buscaminas
{
    public static class Utils
    {
        public static Random random = new Random();
        public static int GetRandom(int min, int max)
        {            
            return random.Next(min, max);
        } 
    }
}
