namespace DAMLib
{
    public class Queue<T>
    {
        private T[] _queue;


        public int Count => _queue.Length;
        public T First => _queue[0];
        public T Last => _queue[Count - 1];
        public bool Empty => _queue.Length == 0;



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

            for(int i = 0; i < count - 1; i++)
            {
                _arrayResult[i] = _queue[i + 1];
            }

            _queue = _arrayResult;

            return result;
        }

        public void Clear()
        {
            T[] arrayResult = new T[0];
            _queue = arrayResult;
        }

        public override string ToString()
        {
            string result = "";
            int count = 1;

            foreach(T element in _queue)
            {
                result += $"El elemento {count} de la Queue es {element}";
                count++;
            }

            return result;
        }

        public T[] CloneQueue(T[] queue)
        {
            T[] result = new T[queue.Length];

            for(int i = 0; i < result.Length; i++)
            {
                result[i] = queue[i];
            }

            return result;
        }

        public void QueueMultipleElements(T[] elements)
        {
            int newElementsCount = elements.Length;
            int oldElementsCount = _queue.Length;

            T[] newQueue = new T[newElementsCount + oldElementsCount];

            for(int i = 0; i < oldElementsCount - 1; i++)
            {
                newQueue[i] = _queue[i];
            }

            for(int i = 0; i < newElementsCount - 1; i++)
            {
                newQueue[i + oldElementsCount] = elements[i];
            }

            _queue = newQueue;
        }
    }
}
