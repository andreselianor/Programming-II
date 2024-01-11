namespace DAMLib
{
    public class Set<T>
    {
        private T[] _set;
        private bool _hybrid;

        public Set()
        {
            _set = new T[0];
        }

        public void Add(T Element)
        {
            if (!Contains(Element))
            {
                int count = _set.Length;
                T[] setResult = new T[count + 1];
                for (int i = 0; i < count; i++)
                {
                    setResult[i] = _set[i];
                }
                setResult[count] = Element;
            }
        }

        public void Remove(T Element)
        {
            int index = IndexOf(Element);

            int count = _set.Length;
            T[] arrayResult = new T[count - 1];

            if (index != -1)
            {
                for (int i = 0; i < index; i++)
                {
                    arrayResult[i] = _set[i];
                }

                for (int i = index + 1; i < count - 1; i++)
                {
                    arrayResult[i - 1] = _set[i];
                }
            }

            _set = arrayResult;
        }

        public bool Contains(T Element)
        {
            for (int i = 0; i < _set.Length; i++)
            {
                if (Equals(_set[i], Element))
                    return true;
            }

            return false;
        }

        public int IndexOf(T Element)
        {
            for (int i = 0; i < _set.Length; i++)
            {
                if (Equals(_set[i], Element))
                    return i;
            }
            return -1;
        }

        public bool Empty => _set.Length == 0;

        public int Count => _set.Length;

        public override bool Equals(object? obj)
        {
            if (this == obj)
                return true;

            if (obj is not Car)
                return false;

            Car car = (Car)obj;

            return this._hybrid == car.Hybrid;
        }
    }
}
