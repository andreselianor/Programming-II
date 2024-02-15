namespace Colecciones
{
    public interface IList
    {
<<<<<<< Updated upstream
        int GetListCount();
        Object GetElementAt(int index);
        int GetIndexOf(Object element);

        void AddElement(Object element);
        void RemoveElement(Object element);
=======
        int GetIndexOf(T element);
        int GetListCount();
        T GetElementAt(int index);
        
        void AddElement(T element);
        void RemoveElement(T element);
>>>>>>> Stashed changes
        void RemoveElementAt(int index);

        void ContainsElement(Object element);

        bool IsEmpty();
        bool IsSort();
        bool IsValid();

        void Sort();
        void Filter();
        void Visit();

        void Clear();
        List<Object> Clone();
    }
}
