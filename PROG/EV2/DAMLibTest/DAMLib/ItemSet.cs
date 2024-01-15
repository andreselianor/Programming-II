namespace DAMLib
{
    public class ItemSet<T>
    {
        private Items[] _items = new Items[0];

        private class Items
        {
            public T? element;
            public int hash;

            public Items(T? element, int hash)
            {
                this.element = element;
                this.hash = hash;
            }



            // Opcional
            public T? Element => element;
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
            int newLength = _items.Length + 1;
            Items[] newItemArray = new Items[newLength];

            int hash = element.GetHashCode();
            Items newItem = new Items(element,hash);

            for(int i = 0; i < newLength; i++)
            {
                newItemArray[i] = _items[i];
            }

            newItemArray[newLength] = newItem;
            _items = newItemArray;
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

            for(int i = 0; i < _items.Length; i++)
            {
                if(_items[i].element.Equals(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Count => _items.Length;
        public bool IsEmpty => _items.Length == 0;
    }
}
