namespace DAMLib
{
    public class Stack<T>
    {
        private T[] _stackArray;

        public Stack()
        {
            _stackArray = new T[0];
        }

        public void Push(T Element)
        {
            if (Element == null)
                return;

            int count = _stackArray.Length;

            T[] _stackResult = new T[count + 1];

            for (int i = 0; i < count; i++)
            {
                _stackResult[i] = _stackArray[i];
            }

            _stackResult[count] = Element;
            _stackArray = _stackResult;
        }

        public T? Pop()
        {
            int count = _stackArray.Length;

            T result = _stackArray[count - 1];

            T[] _stackResult = new T[count - 1];

            for(int i = 0; i < count - 1; i++)
            {
                _stackResult[i] = _stackArray[i];
            }

            _stackArray = _stackResult;

            if (result == null)
                return default(T);

            return result;
        }

        public T Top()
        {
            T result = _stackArray[_stackArray.Length - 1];

            if (result == null)
                return default(T);

            return result;
        }

        public bool IsEmpty()
        {
            return _stackArray.Length < 0;
        }

        public int GetCount()
        {
            return _stackArray.Length;
        }
    }
}