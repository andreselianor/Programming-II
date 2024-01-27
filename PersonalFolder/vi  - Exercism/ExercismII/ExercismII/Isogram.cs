namespace ExercismII
{
    public static class Isogram
    {
        // Funcion que devuelve verdadero si una palabra es 'Isogram' o no contiene letras repetidas.
        public static bool IsIsogram(string word)
        {
            if (word == null)
                return false;

            List<char> listResult = new List<char>();
            word = word.ToLower();

            listResult = AddCharToList(word);
            listResult = RemoveSignFromList(listResult);
            bool result = IsCharWithoutRepeating(listResult);

            return result;
        }

        private static List<char> AddCharToList(string word)
        {
            List<char> listResult = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                listResult.Add(word[i]);
            }
            return listResult;
        }

        private static List<char> RemoveSignFromList(List<char> list)
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

        private static bool IsCharWithoutRepeating(List<char> list)
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
