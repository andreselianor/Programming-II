namespace DAMLib
{
    public class SetWithHash<T>
    {        
        public T[] _set;
        public int[] _hash;

        public bool IsEmpty => _set.Length == 0;
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

        public SetWithHash()
        {
            _set = new T[0];
            _hash = new int[0];
        }
        public SetWithHash(int count)
        {
            _set = new T[count];
            _hash = new int[count];
        }

        public void Add(T element)
        {
            if (element == null)
                return;

            if (!Contains(element))
            {
                int count = _set.Length;

                T[] setResult = new T[count + 1];
                int[] hashResult = new int[count + 1];

                for (int i = 0; i < count; i++)
                {
                    setResult[i] = _set[i];
                    hashResult[i] = _hash[i];
                }

                setResult[count] = element;
                hashResult[count] = GetHashCode();

                _set = setResult;
                _hash = hashResult;
            }
        }

        public void Remove(T element)
        {
            int index = GetIndexOf(element);

            if (index == -1)
                return;

            int count = _set.Length;
            T[] arrayResult = new T[count - 1];
            int[] hashResult = new int[count - 1];

            for (int i = 0; i < count; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    arrayResult[i] = _set[i];
                    hashResult[i] = _hash[i];
                }
            }

            _set = arrayResult;
            _hash = hashResult;
        }

        public int HashWithIndex(int index)
        {
            return _hash[index];
        }

        public int GetIndexOf(T element)
        {
            if (element == null)
                return -1;

            int hash = element.GetHashCode();            

            for (int i = 0; i < _set.Length; i++)
            {
                if (hash == _set[i].GetHashCode() && 
                    _set[i].Equals(element))
                    return i;
            }
            return -1;
        }

        public bool Contains(T element)
        {
            if (element == null)
                return false;

            int index = GetIndexOf(element);

            if (index == -1)
                return false;

            if (_hash[index].GetHashCode() == element.GetHashCode())
                return true;
            return false;
        }
        public override bool Equals(object? obj)
        {
            return this == obj;
        }
        public bool EqualsDeep(object? obj)
        {
            if (this == obj)
                return true;

            if (obj is not SetWithHash<T>)
                return false;

            SetWithHash<T> testObj = (SetWithHash<T>)obj;

            if (this._set == testObj._set && this._hash == testObj._hash)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _set.GetHashCode();
        }

        public void Clear()
        {
            _set = Array.Empty<T>();
            _hash = Array.Empty<int>();
        }
        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < _set.Length; i++)
            {
                result += string.Format("El valor {0} ocupa la posicion {1} y cuyo hash es el numero {2}\n", _set[i], i, _hash[i]);
            }

            return result;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE SETWITHHASH · COLECCIONES DE DATOS
        Los elementos de la coleccion contienen un numero unico llamado Hash.
        Este numero sirve para ordenar y comprobar que no existen valores repetidos.

        (P) bool IsEmpty;
        (P) int Count;

        |#| SetWithHash() {}
        |#| SetWithHash(int count) {T[] = new T[count]; int[] = new int[count]}

        + Add(T element) : void
        Funcion que añade un elemento y un numero Hash a la coleccion.

        + Remove(T element) : void
        Funcion que elimina el elemento y el numero hash que le pasamos por parametros.

        + HashWithIndex(int index) : int
        Funcion que devuelve el numero hash de la posicion que le pasamos por parametros.

        + GetIndexOf(T element) : int
        Funcion que devuelve el indice del elemento que le pasamos por parametros.

        + Contains(T element) : bool
        Funcion que devuelve verdadero si existe el elemento dentro de la coleccion.

        + override GetHashCode() : int
        Funcion que devuelve el 'Hashcode' personalizado del elemento 'this'

        + override Equals(object obj) : bool
        Funcion que devuelve verdadero o falso si un elemento es igual al this.

        + EqualsDeep(object obj) : bool
        Funcion que devuelve si dos elementos son iguales en contenido y numero Hash.

        + Clear() : void
        Funcion que elimina todos los elementos y hashes del Set.

        + override ToString() : string
        Funcion que devuelve una cadena de texto con la descripcion del objeto 'QUEUE'.

        */
        #endregion
    }
}