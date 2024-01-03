namespace ExercismII
{
    public class Pangram
    {
        public static bool IsPangram(string input)
        {
            if (input == null)
                return false;

            List<int> listResult = new List<int>();

            for (int i = 97; i < 123; i++)
                listResult.Add(i);

            for (int i = 0; i < input.Length; i++)
            {
                string text = input.ToLower();
                int charRemove = (int)text[i];
                int index = GetIndexWithLetter(charRemove, listResult);

                if (index != -1)
                    listResult.RemoveAt(index);
            }

            return listResult.Count == 0 ? true : false;
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
