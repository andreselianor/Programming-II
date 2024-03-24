namespace DAMLib
{
    public class SetOrdered<T>
    {
        private Item[] _orderedSet;

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

        public bool IsEmpty => _orderedSet.Length == 0;
        public bool IsNull => _orderedSet == null;

        public SetOrdered()
        {
            _orderedSet = Array.Empty<Item>();
        }
        public SetOrdered(int count)
        {
            _orderedSet = new Item[count];
        }

        public int GetItemsCount()
        {
            return _orderedSet.Length;
        }

        // Javi: No, ..., si los tienes ordenados, esta función debería ser un binary search
        public int GetIndexOf(T element)
        {
            if (element == null)
                return -1;

            for (int i = 0; i < _orderedSet.Length; i++)
            {
                if (_orderedSet[i].Hash == element.GetHashCode())
                    return i;
            }
            return -1;
        }

        public T GetItemAt(int index)
        {
            return _orderedSet[index].Element;
        }
        public T GetItemWithHash(int hash)
        {
            for (int i = 0; i < _orderedSet.Length; i++)
            {
                if (_orderedSet[i].Hash == hash)
                    return _orderedSet[i].Element;
            }
            return default(T);
        }

        public void Add(T element)
        {
            if (element == null)
                return;

            if (!Contains(element))
                AddElement(element);

            SortSet();
        }

        private void AddElement(T element)
        {
            int newLength = _orderedSet.Length + 1;
            Item[] arrayResult = new Item[newLength];

            int hash = element.GetHashCode();
            Item newItem = new Item(element, hash);

            for (int i = 0; i < newLength - 1; i++)
            {
                arrayResult[i] = _orderedSet[i];
            }
            arrayResult[newLength - 1] = newItem;

            _orderedSet = arrayResult;
        }

        public bool Contains(T element)
        {
            return GetIndexOf(element) >= 0;
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

        private void Remove(T element)
        {
            if (element == null)
                return;

            for (int i = 0; i < _orderedSet.Length; i++)
            {
                if (_orderedSet[i].Hash.Equals(element.GetHashCode()))
                    RemoveAt(i);
            }
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

        // Javi: Esto es lo que debería ser el IndexOf
        public T BinarySearch(T element)
        {
            if (element == null)
                return default(T);

            int hash = element.GetHashCode();
            int count = _orderedSet.Length;
            int superiorIndex = _orderedSet[count - 1].GetHashCode();
            int inferiorIndex = _orderedSet[0].GetHashCode();

            while (superiorIndex > inferiorIndex)
            {
                int searchIndex = superiorIndex / inferiorIndex;

                if (searchIndex == hash)
                    return _orderedSet[searchIndex].Element;

                if (hash > searchIndex)
                    inferiorIndex = searchIndex + 1;
                else
                    superiorIndex = searchIndex - 1;
            }
            return default(T);
        }
        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _orderedSet.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return this == obj;
        }

        public SetOrdered<T> Clone()
        {
            int count = _orderedSet.Length;
            SetOrdered<T> clone = new SetOrdered<T>(count);

            for (int i = 0; i < count; i++)
            {
                clone._orderedSet[i].Element = _orderedSet[i].Element;
                clone._orderedSet[i].Hash = _orderedSet[i].Hash;
            }
            return clone;
        }

        public void Clear()
        {
            _orderedSet = new Item[0];
        }
        public override string ToString()
        {
            string result = "";
            int count = 0;

            foreach (Item i in _orderedSet)
            {
                result += $"El elemento numero {count} de la coleccion es: {i.Element}.\n";
                count++;
            }
            return result;
        }

        #region · DOCUMENTACION
        /* 
        DOCUMENTACION PARA LA CLASE SETWITHORDER · COLECCIONES DE DATOS

        (P) bool IsEmpty;
        (P) bool IsNull;

        |#| SetOrdered() {}

        + GetItemsCount() : int
        Devuelve el numero de items dentro del Set

        + GetIndexOf(T element) : int
        Devuelve la posicion del elemento dentro del set.

        + GetItemAt(int index) : T
        Devuelve el elemento que existe dentro de la posicion que se le indica.

        + GetItemWithHash(int hash) : T
        Devuelve el elemento que tiene el Hash indicado.

        + Add(T element) : void
        Comprueba el que elemento T no existe dentro de la colecion. 
        Despues lo añade y entonces ordena la coleccion.

        + Contains(T element) : bool
        Funcion que devuelve verdadero si existe el elemento dentro de la coleccion.

        + SortSet() : void
        Ordena el Set con los numeros hash de manera ascendente.

        + Remove(T element) : void
        Funcion que elimina el elemento que le pasamos por parametros.

        + RemoveAt(int index) : void
        Funcion que elimina el elemento que ocupa la posicion indicada.

        + BinarySearch(T element) : bool
        Funcion que busca el elemento dentro del set.

        + override GetHashCode() : int
        Funcion que devuelve el 'Hashcode' personalizado del elemento 'this'

        + override Equals(object obj) : bool
        Funcion que devuelve verdadero o falso si un elemento es igual al this.

        + OrderedSet<T> Clone() : OrderedSet<T>
        Funcion que realiza una copia de la coleccion Set.

        + Clear() : void
        Funcion que elimina todos los objetos del array.

        + override ToString() : string
        Funcion que devuelve una cadena de texto con la descripcion del objeto 'QUEUE'.

        */
        #endregion
    }
}