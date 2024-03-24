namespace DAMLib
{
    public interface IDictionary<K, V>
    {
        int GetElementsCount();
        int GetIndexWithKey(K key);
        int GetIndexWithValue(V value);
        V GetValueWithKey(K key);

        void AddKeyValue(K key,V value);
        void AddMultipleKeyValue(K[] key, V[] value);
        void RemoveWithValue(V value);
        void RemoveAt(int index);
        void RemoveAtKey(K key);

        bool Contains(V value);

        // Javi: Esto no es necesario, ..., desde una interfaz, no deberias tener visibilidad
        // de las implementaciones
        Dictionary<K,V> Filter();
        Dictionary<K, V> Sort();
        void Visit();

        void Clear();
        // Javi: IDictionary
        Dictionary<K, V> Clone();
        string ToString();
    }
}