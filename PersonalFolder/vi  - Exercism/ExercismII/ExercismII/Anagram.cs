namespace ExercismII
{
    public class Anagram
    {
        private string _anagramWord;

        public Anagram(string baseWord)
        {
            _anagramWord = baseWord;
        }

        public string[] FindAnagrams(string[] potentialMatches)
        {
            string[] arrayResult = new string[0];
            foreach (string s in potentialMatches)
            {
                if (s == _anagramWord)
                    AddElementToArray(s);
            }

            return arrayResult;
        }

        public List<string> GetListAnagrams(string word)
        {
            List<string> listResult = new List<string>();

            return listResult;

        }
        public void AddElementToArray(string element)
        {
            return;
        }
    }
}
