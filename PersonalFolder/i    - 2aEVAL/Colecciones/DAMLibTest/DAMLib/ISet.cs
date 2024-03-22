namespace DAMLib
{
    public interface ISet<T>
    {
        int GetElementsCount();
        int GetIndexOf(T element);
        T GetElementAt(int index);

        void Add(T element);
        void RemoveAt(int index);
        void Remove(T element);

        bool Contains(T element);

        int Count { get; }  
        bool IsEmpty { get; }

        T Clone();
        void Clear();
        string ToString();
    }
}