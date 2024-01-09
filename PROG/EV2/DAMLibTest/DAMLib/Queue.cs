namespace DAMLib
{
    public class Queue<T>
    {
        private T[] _queue;

        public Queue()
        {
            _queue = new T[0];
        }

        public void Enqueue(T element)
        {
            int count = _queue.Length;
            T[] _arrayResult = new T[count + 1];

            for(int i = 0; i < count; i++)
            {
                _arrayResult[i] = _queue[i];
            }

            _arrayResult[count] = element;

            _queue = _arrayResult;
        }

        public T Dequeue()
        {
            int count = _queue.Length;
            T result = _queue[0];
            T[] _arrayResult = new T[count - 1];

            for(int i = 0; i < count; i++)
            {
                _arrayResult[i + 1] = _queue[i];
            }

            _queue = _arrayResult;

            return result;
        }

        public void Clear()
        {
            T[] arrayResult = new T[0];
            _queue = arrayResult;
        }

        public int Count => _queue.Length;
        public T First => _queue[0];
        public T Last => _queue[Count - 1];
        public bool Empty => _queue.Length == 0;
    }
}
