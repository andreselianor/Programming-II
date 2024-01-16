namespace DAMLib
{
    public class ItemSet<T>
    {
        public Items[] _itemset;

        public class Items
        {
            public T element;
            public int hash;

            public Items(T element, int hash)
            {
                this.element = element;
                this.hash = hash;
            }

            // Opcional
            public T Element => element;
            public int Hash => hash;
        }

        public void Add(T element)
        {
            bool IsElementInSet = Contains(element);

            if (IsElementInSet)
                return;

            else
                AddElement(element);
        }

        public void AddElement(T element)
        {
            int newLength = _itemset.Length + 1;
            Items[] newItemArray = new Items[newLength];

            int hash = GetHashCode(element);
            Items newItem = new Items(element, hash);   // Llamada al constructor de Items

            for (int i = 0; i < newLength - 1; i++)
            {
                newItemArray[i] = _itemset[i];
            }
            newItemArray[newLength - 1] = newItem;

            _itemset = newItemArray;
        }

        public void RemoveAt(int index)
        {
            int newLength = _itemset.Length - 1;
            Items[] newItemArray = new Items[newLength];


            for (int i = 0; i < index; i++)
            {
                newItemArray[i] = _itemset[i];
            }

            for (int i = index; i < newLength; i++)
            {
                newItemArray[i] = _itemset[i + 1];
            }

            _itemset = newItemArray;
        }

        public bool Contains(T element)
        {
            int index = IndexOf(element);

            return index > -1;
        }

        public int IndexOf(T element)
        {
            if (element == null)
                return -1;

            if (_itemset == null)
                return -1;

            for (int i = 0; i < _itemset.Length; i++)
            {
                T? item = _itemset[i].element;
                if (item.Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Count
        {
            get
            {
                if (_itemset == null)
                    return 0;
                return _itemset.Length;
            }
        }

        public bool IsEmpty => _itemset.Length == 0;


        public int GetHashCode(T element)
        {
            return 133 * 335 * element.GetHashCode();
        }

        public ItemSet()
        {
            _itemset = new Items[0];
        }        
    }
}
