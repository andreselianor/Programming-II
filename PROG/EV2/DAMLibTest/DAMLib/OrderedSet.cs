using System.Xml.Linq;

namespace DAMLib
{
    public class OrderedSet<T>
    {
        private Item[] _orderedSet;

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
                if (_orderedSet == null)
                    return 0;
                return _orderedSet.Length;
            }
        }
        public bool IsEmpty => _orderedSet.Length == 0;


        public OrderedSet()
        {
            _orderedSet = Array.Empty<Item>();
        }

        // Funcion publica que añade un elemento al Set. Despues lo ordena.
        public void Add(T element)
        {
            if (element == null)
                return;

            if (Contains(element))
                return;
            else
                AddElement(element);

            SortSet();
        }

        // Funcion que añade un elemento al Set.
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

        // Funcion que elimina el item que se encuentra en la posicion del index.
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

        // Funcion que ordena el Set de menor a mayor.
        public void SortSet()
        {
            int count = _orderedSet.Length;
            Item aux;

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (_orderedSet[i].hash > _orderedSet[j].hash)
                    {
                        aux = _orderedSet[i];
                        _orderedSet[i] = _orderedSet[j];
                        _orderedSet[j] = aux;
                    }                        
                }
            }
        }

        // Funcion que realiza una busqueda binaria de un elemento segun el Hash.
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

                if (element.Equals(_orderedSet[searchIndex].element))
                    return _orderedSet[searchIndex].element;

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

        // Funcion que evalua si el Set contiene un elemento.
        public bool Contains(T element)
        {
            return IndexOf(element) >= 0;
        }

        // Funcion que devuelve el indice de un elemento dentro del Set.
        public int IndexOf(T element)
        {
            if (element == null)
                return -1;

            int hash = element.GetHashCode();

            for (int i = 0; i < _orderedSet.Length; i++)
            {
                Item item = _orderedSet[i];
                if (hash == item.hash && item.element.Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        // Funcion que elimina todos los elementos del Set.
        public void Clear()
        {
            _orderedSet = new Item[0];
        }

        // Funcion que sobreescribe el metodo para recoger el Hash de un elemento.
        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _orderedSet.GetHashCode();
        }

        public override string ToString()
        {
            string result = "";
            int count = 0;

            foreach(Item i in _orderedSet)
            {
                result += $"El elemento numero {count} de la coleccion es: {i.element}.\n";
                count++;
            }
            return result;
        }
    }
}
