namespace DAMLib
{
    public class Dictionary<K, V>
    {
        // La documentacion de la clase 'Dictionary' se encuentra al final del fichero.

        public delegate bool DelegateFilterWithKey(K key);
        public delegate bool DelegateFilterWithValue(V value);
        public delegate bool DelegateFilterWithKeyValue(K key, V value);

        private Item[] _item = new Item[0];

        private class Item
        {
            public K Key;
            public V Value;

            public Item()
            {
                Key = default(K);
                Value = default(V);
            }
            public Item(K key, V value)
            {
                this.Key = key;
                this.Value = value;
            }
        }

        public int Count => _item.Length;
        public bool IsEmpty => _item.Length < 0;

        public int GetIndexOf(V value)
        {
            if (value == null)
                return 0;

            for (int i = 0; i < _item.Length; i++)
            {
                if (_item[i].Value.Equals(value))
                    return i;
            }
            return -1;
        }
        public int GetIndexOf(K key)
        {
            if (key == null)
                return 0;

            for (int i = 0; i < _item.Length; i++)
            {
                if (_item[i].Key.Equals(key))
                    return i;
            }
            return -1;
        }
        public V? GetElementWithKey(K key)
        {
            if (key == null)
                return default(V);

            for (int i = 0; i < _item.Length; i++)
            {
                if (_item[i].Key.Equals(key))
                    return _item[i].Value;
            }
            return default(V);
        }


        public void Add(K key, V value)
        {
            if (ContainsKey(key))
                return;

            int count = _item.Length;
            Item[] setResult = new Item[count + 1];
            Item element = new Item(key, value);

            for (int i = 0; i < count; i++)
            {
                setResult[i] = _item[i];
            }

            setResult[count] = element;
            _item = setResult;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > _item.Length)
                return;

            if (index == -1)
                return;

            int count = _item.Length;
            Item[] arrayResult = new Item[count - 1];

            for (int i = 0; i < index; i++)
            {
                arrayResult[i] = _item[i];
            }
            for (int i = index; i < count - 2; i++)
            {
                arrayResult[i] = _item[i + 1];
            }

            _item = arrayResult;
        }

        private bool ContainsKey(K key)
        {
            return GetIndexOf(key) >= 0;

            // Otra opcion
            //if (key == null)
            //    return false;

            //for (int i = 0; i < _item.Length; i++)
            //{
            //    if (_item[i].Key.Equals(key))
            //        return true;
            //}
            //return false;
        }

        public bool Contains(V value)
        {
            return GetIndexOf(value) >= 0;
            
            // Otra opcion
            //if (value == null)
            //    return false;

            //for (int i = 0; i < _item.Length; i++)
            //{
            //    if (_item[i].Value.Equals(value))
            //        return true;
            //}
            //return false;
        }

        public override bool Equals(object? obj)
        {
            return (this == obj);
        }

        public bool AreIdentical(object? obj)
        {
            if (obj == null)
                return false;
            if (obj is not Item)
                return false;
            Item identicalItem = (Item)obj;

            for(int i = 0; i < _item.Length;i++)
            {
                if (_item[i].Key.Equals(identicalItem.Key) &&
                    _item[i].Value.Equals(identicalItem.Value))
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _item.GetHashCode();
        }

        public Dictionary<K, V> Filter(DelegateFilterWithKeyValue del)
        {
            Dictionary<K, V> dictionaryResult = new Dictionary<K, V>();

            for (int i = 0; i < _item.Length; i++)
            {
                bool InsertIntoCollection = del(_item[i].Key, _item[i].Value);
                if (InsertIntoCollection)
                {
                    dictionaryResult.Add(_item[i].Key, _item[i].Value);
                }
            }
            return dictionaryResult;
        }
        public Dictionary<K, V> Filter(DelegateFilterWithKey del)
        {
            Dictionary<K, V> dictionaryResult = new Dictionary<K, V>();

            for (int i = 0; i < _item.Length; i++)
            {
                bool InsertIntoCollection = del(_item[i].Key);
                if (InsertIntoCollection)
                {
                    dictionaryResult.Add(_item[i].Key, _item[i].Value);
                }
            }
            return dictionaryResult;
        }
        public Dictionary<K, V> Filter(DelegateFilterWithValue del)
        {
            Dictionary<K, V> dictionaryResult = new Dictionary<K, V>();

            for (int i = 0; i < _item.Length; i++)
            {
                bool InsertIntoCollection = del(_item[i].Value);
                if (InsertIntoCollection)
                {
                    dictionaryResult.Add(_item[i].Key, _item[i].Value);
                }
            }
            return dictionaryResult;
        }

        public void Clear()
        {
            _item = new Item[0];
        }
        public override string ToString()
        {
            string result = "";
            foreach (Item i in _item)
            {
                result += $"La key {i.Key}, contiene el value {i.Value}\n";
            }
            return result;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE DICTIONARY · COLECCIONES DE DATOS.
        Los elementos de la coleccion se componen de:
        Un valor <K> 'Key', unico en la coleccion que sirve con indice de la coleccion.
        Un valor <V> 'Value', que contiene la informacion del elemento.

        (P) bool IsEmpty;
        (P) int Count;

        |#| Set() {}

        + GetIndexOf(V value) : int
        Devuelve el indice del elemento que le pasamos por parametros.

        + GetElementWithKey(K key) : V
        Devuelve el elemento que tiene la Key indicada.

        + Add(K key, V value) : void
        Funcion que añade un elemento SOLO en caso que no exista dentro de la coleccion.

        + RemoveAt(int index) : void
        Funcion que elimina el elemento que le pasamos por parametros.

        + Contains(V value) : bool
        Funcion que devuelve verdadero si existe el elemento dentro de la coleccion.

        + ContainsKey(K key) : bool
        Funcion que devuelve verdadero si existe una key determinada dentro de la coleccion.

        + IndexOf(T element) : int
        Funcion que devuelve el índice del elemento que le paso por parametros.

        + Equals(object obj) : bool
        Funcion que devuelve verdadero si dos elementos son iguales.

        + AreIdentical(object obj) : bool
        Funcion que devuelve verdadero si dos objetos son iguales en todos sus atributos.

        + override GetHashCode() : int
        Funcion que devuelve el 'Hashcode' personalizado del elemento 'this'

        + override Equals(object obj) : bool
        Funcion que devuelve verdadero o falso si un elemento es igual al this.

        + IsEqualsInDeep(object obj) : bool
        Funcion que devuelve verdadero o falso si un elemento es 'identico' al this.

        + Dictionary<K, V> Filter(DelegateFilterWithKeyValue del)
        Funcion que devuelve una nueva coleccion que contiene los elementos que filtra el usuario.

        + Dictionary<K, V> Filter(DelegateFilterWithKey del)
        El usuario le pasa una funcion que filtra elementos que tienen una key determinada.

        + Dictionary<K, V> Filter(DelegateFilterWithValue del)
        El usuario le pasa una funcion que filtra elementos que tienen un valor determinada.

        + Clear() : void
        Funcion que elimina todos los objetos del array.

        + override ToString() : string
        Funcion que devuelve una cadena de texto con la descripcion del objeto 'QUEUE'.

        */
        #endregion
    }
}