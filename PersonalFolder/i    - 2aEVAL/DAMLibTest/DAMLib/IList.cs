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

        void Contains(T element);

        bool IsEmpty();
        bool IsSort();
        bool IsValid();

        void Sort();
        void Filter();
        void Visit();

        void Clear();
        List<T> Clone();
    }
}