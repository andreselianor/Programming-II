namespace ExercismII
{
    public class Acronym
    {

        public static string Abbreviate(string phrase)
        {
            string result = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                result += phrase[i];

                if (i > 0 && IsMayus(phrase[i]))
                    result += phrase[i];
                else if (i > 0 && IsSign(phrase[i - 1]))
                    result += phrase[i];
                
            }

            return result.ToUpper();
        }

        public static bool IsMayus(char letter)
        {
            return (64 < letter && letter < 91);
        }

        public static bool IsSign(char letter)
        {
            return (31 < letter && letter < 65);
        }

        public static bool IsSpace(char letter)
        {
            return letter == 32;
        }
    }
}
