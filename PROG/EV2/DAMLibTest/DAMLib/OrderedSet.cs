namespace DAMLib
{
    public class OrderedSet<T>
    {
        public Item[] _orderedSet;

        public class Item
        {
            public T element;
            public int hash;

            public Item()
            {

            }
            public Item(T element, int hash)
            {
                this.element = element;
                this.hash = hash;
            }

            public T Element => element;
            public int Hash => hash;

            public override int GetHashCode()
            {
                //return 133 * 533 * base.GetHashCode();
                return 10;
            }

        }

        public OrderedSet()
        {
            _orderedSet = Array.Empty<Item>();
        }

        public void Add(T element)
        {
            if (element == null)
                return;

            bool IsElementInSet = Contains(element);

            if (IsElementInSet)
                return;
            else
                AddElement(element);

            SortSet();
        }

        private void AddElement(T element)
        {
            if (element == null)
                return;

            int newLength = _orderedSet.Length + 1;
            Item[] newItemArray = new Item[newLength];

            int hash = element.GetHashCode();
            Item newItem = new Item(element, hash);

            for (int i = 0; i < newLength - 1; i++)
            {
                newItemArray[i] = _orderedSet[i];
            }
            newItemArray[newLength - 1] = newItem;

            _orderedSet = newItemArray;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _orderedSet.Length)
                return;

            int newLength = _orderedSet.Length - 1;
            Item[] newItemArray = new Item[newLength];


            for (int i = 0; i < index; i++)
            {
                newItemArray[i] = _orderedSet[i];
            }

            for (int i = index; i < newLength; i++)
            {
                newItemArray[i] = _orderedSet[i + 1];
            }

            _orderedSet = newItemArray;
        }

        public void SortSet()
        {
            int count = _orderedSet.Length;
            Item aux;

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (_orderedSet[i].Hash > _orderedSet[j].Hash)
                    {
                        aux = _orderedSet[i];
                        _orderedSet[i] = _orderedSet[j];
                        _orderedSet[j] = aux;
                    }                        
                }
            }
        }

        public T BinarySearch(T element)
        {
            if (element == null)
                return default(T);

            int hash = element.GetHashCode();
            int superiorIndex = _orderedSet.Length.GetHashCode();
            int inferiorIndex = _orderedSet[0].GetHashCode();
            

            while(superiorIndex > inferiorIndex)
            {
                int searchIndex = superiorIndex / inferiorIndex;

                if (element.Equals(_orderedSet[searchIndex].Element))
                    return _orderedSet[searchIndex].Element;

                if(hash > searchIndex)
                {
                    inferiorIndex = searchIndex + 1;
                }
                else
                {
                    superiorIndex = searchIndex - 1;
                }
            }

            return default(T);
        }

        public bool Contains(T element)
        {
            return IndexOf(element) >= 0;
        }

        public int IndexOf(T element)
        {
            if (element == null)
                return -1;

            int hash = element.GetHashCode();

            for (int i = 0; i < _orderedSet.Length; i++)
            {
                Item item = _orderedSet[i];
                if (hash == item.Hash && item.Element.Equals(element))
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
                if (_orderedSet == null)
                    return 0;
                return _orderedSet.Length;
            }
        }

        public bool IsEmpty => _orderedSet.Length == 0;

        public override int GetHashCode()
        {
            return 10;
        }
    }
}
