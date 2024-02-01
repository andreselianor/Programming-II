namespace ExercismII
{
    public class Pangram
    {
        public static bool IsPangram(string input)
        {
            if (input == null)
                return false;

            string text = input.ToLower();
            List<int> listLetters = new List<int>();

            for (int i = 97; i < 123; i++)
                listLetters.Add(i);

            for (int i = 0; i < input.Length; i++)
            {                
                int letterCast = (int)text[i];
                int index = GetIndexWithLetter(letterCast, listLetters);

                if (index != -1)
                    listLetters.RemoveAt(index);
            }

            return listLetters.Count == 0 ? true : false;
        }

        public static int GetIndexWithLetter(int letter, List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (letter == list[i])
                    return i;
            }
            return -1;
        }
    }
}
