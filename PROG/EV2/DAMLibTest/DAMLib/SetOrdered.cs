using System.Xml.Linq;

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
            _orderedSet = new Item[0];
        }

        public int GetItemsCOunt()
        {
            return _orderedSet.Length;
        }

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

        public bool Contains(T element)
        {
            return GetIndexOf(element) >= 0;
        }

        // Funcion que añade un elemento al Set. Despues lo ordena.
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

        // Funcion que realiza una busqueda binaria de un elemento segun el Hash.
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

        private Item[] Clone()
        {
            int count = _orderedSet.Length;
            Item[] result = new Item[count];

            for(int i = 0; i < count; i++)
            {
                result[i].Element = _orderedSet[i].Element;
                result[i].Hash = _orderedSet[i].Hash;   
            }
            
            return result;
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
    }
}
