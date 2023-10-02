namespace Dolphin01
{
    public class Utils
    {
        public static Random random = new Random();

        public static int GetRandom(int value)
        {
            return random.Next(value);
        }

        public static string blankPositions(int position)
        {
            string result = "";
            for (int i = 0; i < position; i++)
            {
                result += " ";
            }
            return result;
        }

        public static string lengthPositions(int position)
        {
            string result = "";
            for (int i = 0; i < 101 - position; i++)
            {
                result += "·";
            }
            return result;
        }
    }
}
