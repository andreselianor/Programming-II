using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace DAMLib
{
    public class SetWithHash<T>
    {
        private T[] _set;
        private int[] _hash;


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


        public SetWithHash()
        {
            _set = new T[0];
            _hash = new int[0];
        }


        public int HashWithIndex(int index)
        {
            return _hash[index];
        }

        public int IndexOf(T element)
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

            int index = IndexOf(element);

            if (index == -1)
                return false;

            if (_hash[index].GetHashCode() == element.GetHashCode())
                return true;
            return false;
        }

        // Funcion que añade un elemento generico al Set. Incluye un numero entero para el hash del elemento.
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
            int index = IndexOf(element);

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

        public override bool Equals(object? obj)
        {
            return this == obj;
        }

        public bool EqualsDeep(object? obj)
        {
            if (this == obj)
                return true;

            if (obj is not T)
                return false;

            SetWithHash<T> testObj = (SetWithHash<T>)obj;

            if (this == testObj)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _set.GetHashCode();
        }

        public SetWithHash<T> Clone()
        {
            SetWithHash<T> clone = new SetWithHash<T>();

            for (int i = 0; i < _set.Length; i++)
            {
                clone._set = _set;
                clone._hash = _hash;
            }
            return clone;
        }
        public void Clear()
        {
            _set = new T[0];
            _hash = new int[0];
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
    }
}