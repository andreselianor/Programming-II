namespace DAMLib
{
    public class SetWithHash<T>
    {
        private T[] _set;
        private int[] _hash;
        

        public SetWithHash()
        {
            _set = new T[0];
            _hash = new int[0];
        }

        // Funcion que añade un elemento SOLO en caso que no exista dentro de la coleccion.
        public void Add(T Element)
        {
            if (Element == null)
                return;

            if (!Contains(Element))
            {
                int count = _set.Length;

                T[] setResult = new T[count + 1];
                int[] hashResult = new int[count + 1];

                for (int i = 0; i < count; i++)
                {
                    setResult[i] = _set[i];
                    hashResult[i] = _hash[i];
                }

                setResult[count] = Element;
                hashResult[count] = Element.GetHashCode();

                _set = setResult;
                _hash = hashResult;
            }
        }

        public void Remove(T Element)
        {
            int index = IndexOf(Element);

            if (index == -1)
                return;

            int count = _set.Length;
            T[] arrayResult = new T[count - 1];

            // Posibilidad 1. Con dos bucles 'for'            
            for (int i = 0; i < index; i++)
            {
                arrayResult[i] = _set[i];
            }

            for (int i = index; i < count - 2; i++)
            {
                arrayResult[i] = _set[i + 1];
            }

            // Posibilidad 2. Con instruccion 'continue'
            /*
            for(int i = 0; i < count; i++)
            {
                if (i == index)
                    continue;
                arrayResult[i] = _set[i];
            }
            */

            _set = arrayResult;
        }

        // Funcion que devuelve verdadero si existe el elemento dentro de la coleccion.
        public bool Contains(T Element)
        {
            if (Element == null)
                return false;

            int index = IndexOf(Element);

            if (_hash[index] == Element.GetHashCode())
                return true;
            return false;
        }

        // Funcion que devuelve el índice del elemento que le paso por parametros.
        public int IndexOf(T Element)
        {
            if (Element == null)
                return -1;

            for (int i = 0; i < _set.Length; i++)
            {
                if (_set[i].Equals(Element))
                    return i;
            }

            return -1;
        }

        public bool Empty => _set.Length == 0;

        public int Count
        {
            get
            {
                if (_set == null)
                    return 0;
                else
                    return _set.Length;
            }
        }

        public override bool Equals(Object? obj)
        {
            return this == obj;
        }

        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _set.GetHashCode() * _hash.GetHashCode();
        }

        public bool EqualsDeep(object? obj)
        {
            if (this == obj)
                return true;

            if (obj is not Car)
                return false;

            Car car = (Car)obj;

            return false;
            //return this._hybrid == car.Hybrid;
        }

        // Funcion que devuelve un string con todos los elementos de la coleccion.
        public override string ToString()
        {
            string result = "";

            foreach (T element in _set)
            {
                result += element + ",";
            }

            return result;
        }
    }
}
