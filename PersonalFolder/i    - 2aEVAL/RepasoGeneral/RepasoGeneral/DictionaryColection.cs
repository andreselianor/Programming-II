namespace RepasoGeneral
{
    public class DictionaryColection<K, V>
    {
        private Entry[] _content;
        private class Entry
        {
            public K Key;
            public V Value;
        }

        public DictionaryColection()
        {
            _content = new Entry[0];
        }

        public DictionaryColection<K,V> Clone()
        {
            DictionaryColection<K, V> clone = new DictionaryColection<K, V> ();
            foreach(Entry e in _content)
            {
                clone.AddEntry(e.Key, e.Value);
            }

            return clone;
        }

        public void AddEntry(K key, V value)
        {
            int count = _content.Length;
            Entry addition = new Entry();
            addition.Key = key;
            addition.Value = value;
            Entry[] result = new Entry[count + 1];

            for (int i = 0; i < count - 1; i++)
            {
                result[i] = _content[i];
            }
            result[count - 1] = addition;

        }
    }
}
