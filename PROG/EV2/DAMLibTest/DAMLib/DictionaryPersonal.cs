using System.Security.Cryptography.X509Certificates;

namespace DAMLib
{
    public class DictionaryPersonal<K, V>
    {
        private Item[] _item = new Item[0];

        public delegate bool DelegateFilterKeyValue(K key, V value);
        public delegate bool DelegateFilterWithoutParameters();
        public delegate bool DelegateFilterKey(K key);

        private class Item
        {
            public K key;
            public V value;

            public Item(K key, V value)
            {
                this.key = key;
                this.value = value;
            }

            public K Key
            {
                get { return key; }
                set { key = value; }
            }
            public V Value
            {
                get { return value; }
                set { this.value = value; }
            }
        }

        public int Count => _item.Length;
        public bool IsEmpty => _item.Length < 0;


        public void Clear()
        {
            _item = Array.Empty<Item>();
        }

        public void Add(K key, V value)
        {
            int count = _item.Length;
            Item[] setResult = new Item[count + 1];
            Item element = new Item(default, default);
            setResult[count] = element;

            for (int i = 0; i < count; i++)
            {
                setResult[i] = _item[i];
            }

            setResult[count].Key = key;
            setResult[count].Value = value;
            _item = setResult;
        }

        public void RemoveAt(int index)
        {
            _item[0].Key = default;
            _item[0].Value = default;
        }

        public int IndexOf(V value)
        {
            for (int i = 0; i < _item.Length; i++)
            {
                if (_item[i].Value.Equals(value))
                    return i;
            }
            return -1;
        }

        public V GetElementAt(K key)
        {
            for (int i = 0; i < _item.Length; i++)
            {
                if (_item[i].Key.Equals(key))
                    return _item[i].Value;
            }
            return default(V);
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

        public override string ToString()
        {
            string result = "";
            foreach (Item i in _item)
            {
                result += $"La key {i.Key}, contiene el value {i.Value}\n";
            }
            return result;
        }

        public DictionaryPersonal<K, V> Filter(DelegateFilterKeyValue del)
        {
            DictionaryPersonal<K, V> dictionaryResult = new DictionaryPersonal<K, V>();

            for (int i = 0; i < _item.Length; i++)
            {
                bool InsertIntoCollection = del(_item[i].Key, _item[i].Value);
                if (InsertIntoCollection)
                {
                    dictionaryResult.Add(_item[i].Key, _item[i].Value);
                }
            }

            return dictionaryResult;
        }

        public DictionaryPersonal<K, V> Filter(DelegateFilterKey del)
        {
            DictionaryPersonal<K, V> dictionaryResult = new DictionaryPersonal<K, V>();

            for (int i = 0; i < _item.Length; i++)
            {
                bool InsertIntoCollection = del(_item[i].Key);
                if (InsertIntoCollection)
                {
                    dictionaryResult.Add(_item[i].Key, _item[i].Value);
                }
            }

            return dictionaryResult;
        }
        public DictionaryPersonal<K, V> Filter(DelegateFilterWithoutParameters del)
        {
            DictionaryPersonal<K, V> dictionaryResult = new DictionaryPersonal<K, V>();

            for (int i = 0; i < _item.Length; i++)
            {
                dictionaryResult.Add(_item[i].Key, _item[i].Value);
            }

            return dictionaryResult;
        }
    }
}
