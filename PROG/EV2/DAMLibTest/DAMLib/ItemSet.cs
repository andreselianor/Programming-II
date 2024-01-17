using System.Xml.Linq;

namespace DAMLib
{
    public class ItemSet<T>
    {
        public Item[] _itemset;

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

        public ItemSet()
        {
            _itemset = Array.Empty<Item>();
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
        }

        private void AddElement(T element)
        {
            if (element == null)
                return;

            int newLength = _itemset.Length + 1;
            Item[] newItemArray = new Item[newLength];

            int hash = element.GetHashCode();
            Item newItem = new Item(element, hash);

            for (int i = 0; i < newLength - 1; i++)
            {
                newItemArray[i] = _itemset[i];
            }
            newItemArray[newLength - 1] = newItem;

            _itemset = newItemArray;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _itemset.Length)
                return;

            int newLength = _itemset.Length - 1;
            Item[] newItemArray = new Item[newLength];


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
            return IndexOf(element) >= 0;
        }

        public int IndexOf(T element)
        {
            if (element == null)
                return -1;

            int hash = element.GetHashCode();

            for (int i = 0; i < _itemset.Length; i++)
            {
                Item item = _itemset[i];
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
                if (_itemset == null)
                    return 0;
                return _itemset.Length;
            }
        }

        public bool IsEmpty => _itemset.Length == 0;

        public override int GetHashCode()
        {
            return 10;
        }
    }
}
