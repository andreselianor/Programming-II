namespace DAMLib
{
    public interface IList<T>
    {
        int GetListCount();
        T GetElementAt(int index);
        int GetIndexOf(T element);

        void AddElement(T element);
        void RemoveElement(T element);
        void RemoveElementAt(int index);

        bool Contains(T element);

        bool IsEmpty();
        bool IsSort();
        bool IsValid();

        List<T> Sort();
        List<T> Filter();
        void Visit();

        void Clear();
        List<T> Clone();
    }
}