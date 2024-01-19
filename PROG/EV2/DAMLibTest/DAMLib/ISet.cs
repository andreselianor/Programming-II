namespace DAMLib
{
    public interface ISet<T>
    {
        void Add(T element);
        bool Contains(T element);
        int Count { get; }        
    }
}
