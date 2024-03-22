namespace ExamenYvesElianor
{
    public class ExList<T>
    {
        private T[] _itemsArray = new T[0];

        public int Count => _itemsArray.Length;


        // Javi: No podrías hacer esto en una linea
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
                // Javi: Mal, no cumple las especificaciones
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


        // Javi: Una linea
        public T? Last
        {
            get
            {
                return GetLastElement();
            }
        }
        // Javi: Lo mismo que antes
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

        // Javi: Una linea
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
                // Javi: Un método poco ortodoxo, ..., pero vale
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

            // Javi: Null es un elemento válido
            if (element == null)
                return;

            _itemsArray[index] = element;
        }

        public void AddElement(T element)
        {
            // Javi: null es un elemento valido
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

            for (int i = index; i < count - 1; i++)
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

            // Javi: Creo que esto no funciona bien
            for (int i = index; i < count - 1; i++)
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
                // Javi: No lo tengo en cuenta, ..., pero y si _itemsArray[i] es null?
                if (_itemsArray[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        // Javi: Función duplicada
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

            // Javi: POR QUÉ NO HAS USADO ESTO!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?
            // Mas facil:
            //return IndexOf(element) >= 0;
        }


        public delegate void DelegateVisit(T element);
        public delegate int DelegateSort(T element1, T element2);
        public delegate bool DelegateFilter(T element);

        //public void Visit(DelegateVisit visitor)
        //{
        //    if (_item == null)
        //        return;

        //  
        //    for (int i = 0; i < _item.Length; i++)
        //    {
        //        _item[i].Visit(visitor);
        //    }
        //}

        public T[] Sort(DelegateSort del)
        {
            T[] result = new T[0];

            // Javi: Esta función no ordena
            for (int i = 0; i < _itemsArray.Length; ++i)
            {
                if (del(_itemsArray[i], _itemsArray[i + 1]) >= 1)
                {
                    SwapFunction(_itemsArray[i], _itemsArray[i + 1]);                    
                }
            }
            return result;
        }

        // Javi: EIN!?!?!?!?!?!?
        private T[] SwapFunction(T element1, T element2)
        {
            // Se recorre la lista con un doble for y se ordenan los elementos.
            T[] result = new T[0];
            return result;
        }

        public T[] Filter(DelegateFilter del)
        {
            T[] result = new T[0];

            for (int i = 0; i < _itemsArray.Length; ++i)
            {
                if (del(_itemsArray[i]))
                {
                    // Javi: MAL!!!!!!!!!!!!!!!!!!!
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