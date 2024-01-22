namespace DAMLib
{
    public interface ISet<T>
    {
        void Add(T element);
        bool Contains(T element);
        int Count { get; }  
        bool IsEmpty { get; }
        void Clear();
        void Remove(T Element);
    }
}
