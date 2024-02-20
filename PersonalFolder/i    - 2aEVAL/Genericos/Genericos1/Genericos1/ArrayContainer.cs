namespace Genericos1
{    
    public class ArrayContainer<T>
    {
        public delegate bool DelegateFilter(T element);
        public delegate void DelegateSort(T element);
        public delegate void DelegateVisit(T element);


        private T[] _array = new T[0];

        public bool IsEmpty => _array.Length == 0;
        public int Count => _array.Length;  


        public int GetElementsCount()
        {
            return _array.Length;
        }
        public T GetElementAt(int index)
        {
            return _array[index];
        }

        public int GetIndexOf(T element)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(element))          //TO DO: Metodo Equals
                    return i;
            }
            return -1;
        }

        public bool Contains(T element)
        {
            return GetIndexOf(element) >= 0;
        }

        public void AddElement(T element)
        {
            int count = _array.Length;
            T[] arrayResult = new T[count + 1];

            for (int i = 0; i < count; i++)
            {
                arrayResult[i] = _array[i];
            }
            _array = arrayResult;
        }
        public void Remove(T element)
        {
            int count = _array.Length;
            T[] arrayResult = new T[count - 1];

            for (int i = 0; i < count; i++)
            {
                arrayResult[i] = _array[i];
            }
            _array = arrayResult;
        }
        public void RemoveAt(int index)
        {

        }

        public void Filter(DelegateFilter del)
        {

        }

        public void Sort(DelegateSort del)
        {

        }
        public void Visit(DelegateVisit del)
        {

        }

        public T[] Clone()
        {

        }

        public void Clear()
        {

        }
    }
}
