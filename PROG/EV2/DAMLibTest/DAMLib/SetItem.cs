using System.Xml.Linq;

namespace DAMLib
{
    public class SetItem<T>
    {
        private Item[] _itemset;

        private class Item
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


        public SetItem()
        {
            _itemset = Array.Empty<Item>();
        }

        // Funcion publica que añade un elemento al Set.
        public void Add(T element)
        {
            if (element == null)
                return;

            if (Contains(element))
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

        // Funcion que elimina un elemento del Set.
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

        // Funcion que comprueba si contiene un elemento.
        public bool Contains(T element)
        {
            return IndexOf(element) >= 0;
        }

        // Funcion que devuelve el indice de un elemento del Set.
        public int IndexOf(T element)
        {
            if (element == null)
                return -1;

            int hash = element.GetHashCode();

            for (int i = 0; i < _itemset.Length; i++)
            {
                Item item = _itemset[i];
                if (hash == item.hash && item.element.Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        // Funcionn que elimina todo el contenido de la coleccion.
        public void Clear()
        {
            _itemset = new Item[0];
        }

        // Funcion que devuelve el codigo hash de un elemento.
        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _itemset.GetHashCode();
        }

        public override string ToString()
        {
            string result = "";
            int count = 0;

            foreach (Item item in _itemset)
            {
                result = $"El elemento numero {count} del Set es {item.element}";
                count++;
            }
            return result;
        }
    }
}
