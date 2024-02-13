﻿namespace Colecciones
{
    public interface IList
    {
        int GetListCount();
        Object GetElementAt(int index);
        int GetIndexOf(Object element);

        void AddElement(Object element);
        void RemoveElement(Object element);
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
