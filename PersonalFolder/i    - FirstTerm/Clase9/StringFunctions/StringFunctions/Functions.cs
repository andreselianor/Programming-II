namespace StringFunctions
{
    public class Functions
    {
        public static string StringFunction1(string a, string b)
        {
            return a + b;
        }

        public static string StringFunction2(int number)
        {
            string result = "0";
            for (int i = 0; i < number; i++)
            {
                result += "," + (i + 1);
            }
            return result;
        }

        public static string StringFunction3(int number)
        {
            string result = "1";
            int aux = 1;
            for (int i = 0; i < number; i++)
            {
                aux *= 2;
                result += "," + aux;
            }
            return result;
        }
    }
}
