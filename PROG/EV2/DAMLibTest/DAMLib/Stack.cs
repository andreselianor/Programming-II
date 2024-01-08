namespace DAMLib
{
    public class Stack<T>
    {
        private T[] _stackArray;
        private int _count = 0;

        public Stack()
        {
            _stackArray = new T[0];
        }

        public void Push(T Element)
        {
            if (Element == null)
                return;

            T[] _stackResult = new T[_count + 1];

            for (int i = 0; i <= _count; i++)
            {
                _stackResult[i] = _stackArray[i];
            }

            _stackResult[_count] = Element;
            _stackArray = _stackResult;

            _count++;
        }

        public T Pop()
        {
            T result = _stackArray[_count];
            T[] _stackResult = new T[_count - 1];

            for(int i = 0; i < _count - 1; i++)
            {
                _stackResult[i] = _stackArray[i];
            }

            _count--;

            return result;
        }

        public T Top()
        {
            return _stackArray[_count];
        }

        public bool IsEmpty()
        {
            return _count < 0;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}