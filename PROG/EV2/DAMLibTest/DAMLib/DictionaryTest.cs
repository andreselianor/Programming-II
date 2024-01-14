namespace DAMLib
{
    public class DictionaryTest
    {
        private Dictionary<int,string> _dictionary= new Dictionary<int,string>();

        public void Add(int index, string element)
        {
            _dictionary[index] = element;
        }

        public void RemoveAt(int index)
        {
            
        }

        public int IndexOf(string element)
        {
            for(int i = 0; i < _dictionary.Count; i++)
            {
                if (_dictionary[i] == element)
                    return i;
            }
            return -1;
        }
    }
}
