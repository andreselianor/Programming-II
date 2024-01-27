using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace DAMLib
{
    public class SetWithHash<T>
    {
        public T[] _set;
        public int[] _hash;


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

        public void Remove(T Element)
        {
            int index = IndexOf(Element);

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


        public override int GetHashCode()
        {
            return 10;                        
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


        // Funcion que devuelve un booleano si dos objetos son iguales
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
