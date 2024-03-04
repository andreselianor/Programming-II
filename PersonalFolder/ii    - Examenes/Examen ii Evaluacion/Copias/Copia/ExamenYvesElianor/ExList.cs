namespace ExamenYvesElianor
{
    public class ExList<T>
    {
        private T[] _itemsArray = new T[0];

        public int Count => _itemsArray.Length;


        public T? First
        {
            get
            {
                return GetFirstElement();
            }
        }
        private T? GetFirstElement()
        {
            try
            {
                return _itemsArray[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
            finally
            {
                Console.WriteLine($"La lista contiene {_itemsArray.Length} valores");
            }
        }


        public T? Last
        {
            get
            {
                return GetLastElement();
            }
        }
        private T? GetLastElement()
        {
            try
            {
                return _itemsArray[_itemsArray.Length - 1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
            finally
            {
                Console.WriteLine($"La lista contiene {_itemsArray.Length} valores");
            }
        }

        public T[] Reversed
        {
            get
            {
                return ReverseItems();
            }
        }
        private T[] ReverseItems()
        {
            int count = _itemsArray.Length;
            T[] result = new T[count];

            for (int i = 0; i < _itemsArray.Length; i++)
            {
                result[i] = _itemsArray[count - 1];
                count--;
            }
            return result;
        }

        public T? GetElementAt(int index)
        {
            if (index < 0 || index >= _itemsArray.Length)
                return default(T);
            return _itemsArray[index];
        }

        public void SetElementAt(int index, T element)
        {
            if (index < 0 || index >= _itemsArray.Length)
                return;

            if (element == null)
                return;

            _itemsArray[index] = element;
        }

        public void AddElement(T element)
        {
            if (element == null)
                return;

            int count = _itemsArray.Length;
            T[] result = new T[count + 1];

            for (int i = 0; i < count; i++)
            {
                result[i] = _itemsArray[i];
            }

            result[count] = element;
            _itemsArray = result;
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= _itemsArray.Length)
                return;

            int count = _itemsArray.Length;
            T[] result = new T[count - 1];

            for (int i = 0; i < index; i++)
            {
                result[i] = _itemsArray[i];
            }

            for (int i = index + 1; i < count; i++)
            {
                result[i] = _itemsArray[i + 1];
            }

            _itemsArray = result;
        }

        public void Clear()
        {
            _itemsArray = new T[0];
        }

        public void Insert(int index, T element)
        {
            if (index < 0 || index >= _itemsArray.Length)
                return;
            if (element == null)
                return;

            int count = _itemsArray.Length;
            T[] result = new T[count + 1];

            for (int i = 0; i < index; i++)
            {
                result[i] = _itemsArray[i];
            }

            result[index] = element;

            for (int i = index + 1; i < count - 1; i++)
            {
                result[i + 1] = _itemsArray[i];
            }
            _itemsArray = result;
        }

        public int IndexOf(T element)
        {
            if (element == null)
                return -1;

            for (int i = 0; i < _itemsArray.Length; i++)
            {
                if (_itemsArray[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T element)
        {
            if (element == null)
                return false;

            for (int i = 0; i < _itemsArray.Length; i++)
            {
                if (_itemsArray[i].Equals(element))
                    return true;
            }
            return false;
        }


        public delegate void DelegateVisit(T element);
        public delegate int DelegateSort(T element1, T element2);
        public delegate bool DelegateFilter(T element);

        //public void Visit(DelegateVisit visitor)
        //{
        //    if (_item == null)
        //        return;

        //    visitor(this);

        //    for (int i = 0; i < _item.Length; i++)
        //    {
        //        _item[i].Visit(visitor);
        //    }
        //}

        public T[] Sort(DelegateSort del)
        {
            T[] result = new T[0];

            for (int i = 0; i < _itemsArray.Length; ++i)
            {
                if (del(_itemsArray[i], _itemsArray[i + 1]) >= 1)
                {
                    result = new T[i + 1];
                    result[i] = _itemsArray[i];
                }
            }
            return result;
        }

        public T[] Filter(DelegateFilter del)
        {
            T[] result = new T[0];

            for (int i = 0; i < _itemsArray.Length; ++i)
            {
                if (del(_itemsArray[i]))
                {
                    result = new T[i + 1];
                    result[i] = _itemsArray[i];
                }
            }
            return result;
        }

        public T[] Reverse()
        {
            int count = _itemsArray.Length;
            T[] result = new T[count];

            for(int i = 0; i < count; i++)
            {
                result[i] = _itemsArray[count];
                count--;
            }
            return result;
        }

        public T[] ToArray()
        {
            int count = _itemsArray.Length;
            T[] result = new T[count];

            for(int i = 0; i < count; i++)
            {
                result[i] = _itemsArray[i];
            }
            return result;
        }

        public ExList<T> Clone()
        {
            ExList<T> clone = new ExList<T>();

            for(int i = 0; i < _itemsArray.Length;i++)
            {
                clone.AddElement(_itemsArray[i]);
            }

            return clone;
        }
    }
}