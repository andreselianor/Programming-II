using System.Reflection.PortableExecutable;

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

        // Funciones imprescindibles ADD y REMOVE

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

        // Funciones que trabajan con el HashCode

        public override int GetHashCode()
        {
            Random random = new Random();

            /*
            int maxValue = 100;
            int randomHashCode = random.Next(0, maxValue);
            int result = 13 * 53 * 22 * randomHashCode * (_set.Length + 1);
            */
            int result = 133 * 533 * 228 * GetRandomHash();
            return result;
        }

        public int GetRandomHash()
        {
            int result = 0;

            for (int i = 0; i < _set.Length; i++)
            {
                result += Int32.Parse(_set[i].ToString());
            }
            return result;
        }

        public int HashWithIndex(int index)
        {
            return _hash[index];
        }

        // Funciones que devuelven el indice y el booleano si el numero ya existe

        public int IndexOf(T Element)
        {
            if (Element == null)
                return -1;

            int hash = Element.GetHashCode();

            for (int i = 0; i < _set.Length; i++)
            {
                // if (Element.GetHashCode() == _set.GetHashCode())

                if (hash == _hash[i] && _set[i].Equals(Element))
                    return i;
            }
            return -1;
        }

        public bool Contains(T Element)
        {
            if (Element == null)
                return false;

            int index = IndexOf(Element);

            if (index == -1)
                return false;

            if (_hash[index] == Element.GetHashCode())
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

            if (obj is not TestCar)
                return false;

            TestCar car = (TestCar)obj;

            return false;
        }


        // Properties

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

        // Funcion override del metodo ToString

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < _set.Length; i++)
            {
                result += string.Format("El valor {0} que ocupa la posicion {1} y cuyo hash es el numero {2}\n", _set[i], i, _hash[i]);
            }

            return result;
        }
    }
}
