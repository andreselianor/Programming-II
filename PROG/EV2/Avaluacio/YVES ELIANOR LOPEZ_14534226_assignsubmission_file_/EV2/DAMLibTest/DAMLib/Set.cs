namespace DAMLib
{
    // La documentacion de la clase 'Set' se encuentra al final del fichero.
    public class Set<T>
    {
        private T[] _set;

        public bool IsEmpty => _set.Length == 0;        
        public int Count
        {
            get
            {
                // Javi: Podrías hacerlo en una linea, ademas, puede _set ser null?!?!?!!?
                if (_set == null)
                    return 0;
                else
                    return _set.Length;
            }
        }       

        public Set()
        {
            _set = new T[0];
        }

        // Javi: IMPORTANTE, este constructor tendría que ser privado!!!!!
        public Set(int count)
        {
            _set = new T[count];
        }

        public void Add(T element)
        {
            if (element == null)
                return;

            if (!Contains(element))
            {
                int count = _set.Length;
                T[] setResult = new T[count + 1];

                for (int i = 0; i < count; i++)
                {
                    setResult[i] = _set[i];
                }

                setResult[count] = element;
                _set = setResult;
            }
        }
        public bool Contains(T element)
        {
            return IndexOf(element) >= 0;
        }
        public int IndexOf(T element)
        {
            if (element == null)
                return -1;

            for (int i = 0; i < _set.Length; i++)
            {                
                if (_set[i].Equals(element))
                    return i;
            }
            return -1;
        }

        public void Remove(T element)
        {
            if (element == null)
                return;

            int index = IndexOf(element);
            if (index == -1)
                return;

            int count = _set.Length;
            T[] arrayResult = new T[count - 1];
            
            for (int i = 0; i < index; i++)
            {
                arrayResult[i] = _set[i];
            }

            for (int i = index; i < count - 2; i++)
            {
                arrayResult[i] = _set[i + 1];
            }

            _set = arrayResult;
        }
        // Javi: Prefiero el anterior
        public void RemoveAlternative(T element)
        {
            if (element == null)
                return;

            int index = IndexOf(element);
            if (index == -1)
                return;

            int count = _set.Length;
            T[] arrayResult = new T[count - 1];            

            for(int i = 0; i < count; i++)
            {
                if (i == index)
                    continue;
                arrayResult[i] = _set[i];
            }            

            _set = arrayResult;
        }

        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _set.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return this == obj;
        }
        public bool IsEqualsInDeep(object? obj)
        {
            if (this == obj)
                return true;

            if (obj is not Set<T>)
                return false;

            Set<T> set = (Set<T>)obj;

            // Javi: Faltan cosas todavía

            //comprueba que los atributos sean identicos.
            //return (set._attribute == this._attribute);
            return true;
        }

        public Set<T> Clone()
        {
            int count = _set.Length;
            Set<T> clone = new Set<T>(count);
            for(int i = 0; i < _set.Length; i++)
            {
                clone._set[i] = _set[i];
            }
            return clone;
        }
        public T[] ToArray()
        {
            int count = _set.Length;
            T[] result = new T[count];
            for (int i = 0; i < _set.Length; i++)
            {
                result[i] = _set[i];
            }
            return result;
        }

        public void Clear()
        {
            _set = Array.Empty<T>();
        }
        public override string ToString()
        {
            string result = "";
            int count = 0;

            foreach (T element in _set)
            {
                result += $"El elemento numero {count} de la coleccion es: {element}.\n";
                count++;
            }

            return result;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE SET · COLECCIONES DE DATOS.
        En una coleccion 'Set' no se pueden introducir elementos repetidos.            

        (P) bool IsEmpty;
        (P) int Count;

        |#| Set() {}

        + Add(T element) : void
        Funcion que añade un elemento SOLO en caso que no exista dentro de la coleccion.

        + Contains(T element) : bool
        Funcion que devuelve verdadero si existe el elemento dentro de la coleccion.

        + IndexOf(T element) : int
        Funcion que devuelve el índice del elemento que le paso por parametros.

        + Remove(T element) : void
        Funcion que elimina el elemento que le pasamos por parametros.
        Funciona con dos bucles for.

        + RemoveAlternative(T element) : void
        Funcion que elimina el elemento que le pasamos por parametros.
        Funciona utilizando la instruccion 'continue'.

        + override GetHashCode() : int
        Funcion que devuelve el 'Hashcode' personalizado del elemento 'this'.

        + override Equals(object obj) : bool
        Funcion que devuelve verdadero o falso si un elemento es igual al this.

        + IsEqualsInDeep(object obj) : bool
        Funcion que devuelve verdadero o falso si un elemento es 'identico' al this.

        + Clone() : Set<T>
        Funcion que devuelve una copia del objeto Set.

        + Clear() : void
        Funcion que elimina todos los objetos del array.

        + override ToString() : string
        Funcion que devuelve una cadena de texto con la descripcion del objeto 'QUEUE'.

        */
        #endregion
    }
}