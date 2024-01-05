namespace ExercismII
{
    public static class ReverseString
    {
        public static string Reverse(string input)
        {
            if (input == null || input.Length == 0)
                return "";

            string result = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }

            return result;
        }
    }
}
