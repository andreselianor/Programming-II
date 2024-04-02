namespace ExamenLista
{    
    public class ExList<T>
    {
        private T[] _array = Array.Empty<T>();

        public int Count => _array.Length;
        public T First => _array[0];
        public T Last => _array[^1];
        public T[] Reversed => Reverse();

        private T[] Reverse()
        {
            int count = _array.Length;
            T[] result = new T[count];
            for(int i = 0; i < count; i++)
            {
                result[i] = _array[count--];
            }
            return result;
        }


        public T GetElementAt(int index)
        {
            if (index < 0 || index > _array.Length)
                return default(T);
            return _array[index];
        }

        public void SetElementAt(int index, T element)
        {
            if (index < 0 || index > _array.Length)
                return;
            if (element == null)
                return;
            _array[index] = element;
        }

        public void Add(T element)
        {
            if (element == null)
                return;

            int count = _array.Length;
            T[] result = new T[count + 1];

            for(int i = 0; i < _array.Length; i++)
            {
                result[i] = _array[i];
            }
            result[count] = element;
            _array = result;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > _array.Length)
                return;
            int count = Count;
            T[] result = new T[count - 1];
            for (int i = 0; i < index; i++)
            {                
                result[i] = _array[i];
            }
            for(int i = index; i < _array.Length; i++)
            {
                result[i + 1] = _array[i];
            }
            _array = result;
        }

        public void Clear()
        {
            _array = Array.Empty<T>();
        }

        public void Insert(int index, T element)
        {
            if (index < 0 || index > _array.Length)
                return;
            if (element == null)
                return;

            int count = Count;
            T[] result = new T[count + 1];
            for (int i = 0; i < index; i++)
            {
                result[i] = _array[i];
            }
            result[index] = element;
            for (int i = index; i < _array.Length; i++)
            {
                result[i + 1] = _array[i];
            }
            _array = result;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == null)
                    return -1;
                if (_array[i].Equals(element))                
                    return i;                
            }
            return -1;
        }

        public bool Contains(T element)
        {
            if (element == null)
                return false;
            return IndexOf(element) >= 0;
        }


        public delegate bool DelegateFilter(T element);
        public ExList<T> Filter(DelegateFilter del)
        {
            ExList<T> result = new ExList<T>();
            if (del == null)
                return result;

            for(int i = 0; i < _array.Length; i++)
            {
                if (del(_array[i]))
                    result.Add(_array[i]);
            }
            return result;
        }


        public delegate int DelegateSort(T item1, T item2);
        public ExList<T> Sort(DelegateSort comparator)
        {
            if (comparator == null)
                return null;

            ExList<T> result = new ExList<T>();

            for(int i = 0; i < _array.Length - 1;i++)
            {
                for(int j = i + 1; j < _array.Length; j++)
                {
                    if(comparator(_array[i], _array[j]) > 0)
                    {
                        SwapItems(i, j);
                    }
                }
                result.Add(_array[i]);
            }

            return result;
        }

        private void SwapItems(int i, int j)
        {
            T aux;
            aux = _array[i];
            _array[i] = _array[j];
            _array[j] = aux;
        }


        public delegate void DelegateVisit(T visitor);
        public void Visit(DelegateVisit visitor)
        {
            if (visitor == null)
                return;

            for(int i = 0; i < _array.Length; i++)
            {
                visitor(_array[i]);
            }
        }

        public T[] ToArray()
        {
            int count = Count;
            T[] result = new T[count];
            for (int i = 0; i < _array.Length; i++)
            {
                result[i] = _array[i];
            }
            return result;
        }

        public ExList<T> Clone()
        {
            ExList<T> clone = new ExList<T>();
            int count = Count;
            clone._array = new T[count];
            for(int i = 0; i < _array.Length; i++)
            {
                clone._array[i] = _array[i];
            }
            return clone;
        }


        public override bool Equals(object? obj)
        {
            return obj == this;
        }

        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _array.GetHashCode();
        }
    }
}