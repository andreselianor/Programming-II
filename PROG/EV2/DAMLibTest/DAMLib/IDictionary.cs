namespace DAMLib
{
    public interface IDictionary<K, V>
    {
        void GetElementsCount();
        int GetIndexWithKey(K key);
        int GetIndexWithValue(V value);
        V GetValueWithKey(K key);

        void AddKeyValue(K key,V value);
        void AddMultipleKeyValue(K[] key, V[] value);
        void RemoveValue(V value);
        void RemoveAt(int index);
        void RemoveAtKey(K key);

        bool Contains(V value);

        void Filter();
        void Sort();
        void Visit();

        void Clear();
        void Clone();
        void ToString();
    }
}