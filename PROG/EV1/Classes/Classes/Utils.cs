namespace Classes
{
    public class Utils
    {
        private static Random random = new Random();

        public static int getRandomInt(int min, int max)
        {
            return random.Next(min, max);
        }


        public static int LastDigits(int year)
        {
            string lastDigits = "" + year;
            string result = "" + lastDigits[2] + lastDigits[3];
            return Int32.Parse(result);
        }
    }
}
