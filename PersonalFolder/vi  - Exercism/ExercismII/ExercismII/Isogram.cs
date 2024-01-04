namespace ExercismII
{
    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            List<char> listResult = new List<char>();
            word = word.ToLower();
            listResult = AddCharToList(word);
            listResult = RemoveSignFromList(listResult);
            bool result = ContainsRepeatedChar(listResult);
            return result;
        }

        public static List<char> AddCharToList(string word)
        {
            List<char> listResult = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                listResult.Add(word[i]);
            }
            return listResult;
        }

        public static List<char> RemoveSignFromList(List<char> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 97 || list[i] > 123)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            return list;
        }

        public static bool ContainsRepeatedChar(List<char> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                        return false;
                }
            }
            return true;
        }
    }
}
