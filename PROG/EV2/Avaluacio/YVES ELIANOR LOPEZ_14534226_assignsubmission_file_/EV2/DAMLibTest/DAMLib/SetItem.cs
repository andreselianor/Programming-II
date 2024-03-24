namespace DAMLib
{
    // Javi: La clase se llama ItemSet
    public class SetItem<T>
    {        
        private Item[] _itemset;

        private class Item
        {
            public T Element;
            public int Hash;

            public Item()
            {

            }
            public Item(T element, int hash)
            {
                Element = element;
                Hash = hash;
            }
        }

        public int Count
        {
            get
            {
                // Javi: _itemset no puede ser null
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

        public void Add(T element)
        {
            if (element == null)
                return;

            if (!Contains(element))
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

        public override bool Equals(object? obj)
        {
            return this == obj;
        }
        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _itemset.GetHashCode();
        }

        public void Clear()
        {
            _itemset = new Item[0];
        }
        public override string ToString()
        {
            string result = "";
            int count = 0;

            foreach (Item item in _itemset)
            {
                result = $"El elemento numero {count} del Set es {item.Element}";
                count++;
            }
            return result;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE SETITEM · COLECCIONES DE DATOS.

        (P) bool IsEmpty;
        (P) int Count;

        |#| SetItem() {}

        + Add(T element) : void
        Funcion que evalua si element existe dentro de la coleccion.

        - AddElement(T element) : void
        Funcion que añade un elemento SOLO en caso que no exista dentro de la coleccion.

        + Contains(T element) : bool
        Funcion que devuelve verdadero si existe el elemento dentro de la coleccion.

        + IndexOf(T element) : int
        Funcion que devuelve el índice del elemento que le paso por parametros.

        + Remove(T element) : void
        Funcion que elimina el elemento que le pasamos por parametros.

        + override GetHashCode() : int
        Funcion que devuelve el 'Hashcode' personalizado del elemento 'this'

        + override Equals(object obj) : bool
        Funcion que devuelve verdadero o falso si un elemento es igual al this.

        + Clear() : void
        Funcion que elimina todos los objetos del array.

        + override ToString() : string
        Funcion que devuelve una cadena de texto con la descripcion del objeto 'QUEUE'.

        */
        #endregion
    }
}