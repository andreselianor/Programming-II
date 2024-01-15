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
            return 0;
        }

        public string GetElementAt(int index)
        {
            return "";
        }

        public bool Contains(string element)
        {
            return false;
        }

        public override bool Equals(object? obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public int Count => _dictionary.Count;
        public bool Empty => _dictionary.Count < 0;

        public override string ToString()
        {
            return "";
        }
    }
}
