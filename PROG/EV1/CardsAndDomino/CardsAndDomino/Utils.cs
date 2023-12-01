namespace CardsAndDomino
{
    public class Utils
    {
        private static Random random = new Random();
        public static int GetRandomInt(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
