namespace ExercismII
{
    public static class CharacterTests
    {
        public static char Test(string text)
        {
            char result = ' ';

            result = char.ToLower(text[2]);

            return result;
        }

        public static char Test2(string text)
        {
            char result = ' ';

            char letter = text[2];
            bool test2 = char.IsLetter(letter);

            return result;
        }
    }
}
