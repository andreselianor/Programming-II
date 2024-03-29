﻿namespace DAMLib
{
    public class Queue<T>
    {
        private T[] _queue;

        public T First => _queue[0];
        public T Last => _queue[Count - 1];
        public bool IsEmpty => _queue.Length == 0;
        public int Count
        {
            get
            {
                if (_queue == null)
                    return 0;
                else
                    return _queue.Length;
            }

        }

        public Queue()
        {
            _queue = new T[0];
        }

        // Funcion que introduce un elemento generico en el Queue.
        public void Enqueue(T element)
        {
            int count = _queue.Length;
            T[] _arrayResult = new T[count + 1];

            for (int i = 0; i < count; i++)
            {
                _arrayResult[i] = _queue[i];
            }

            _arrayResult[count] = element;

            _queue = _arrayResult;
        }

        // Funcion que extrae un elemento del Queue.
        public T Dequeue()
        {
            int count = _queue.Length;
            T result = _queue[0];
            T[] _arrayResult = new T[count - 1];

            for (int i = 0; i < count - 1; i++)
            {
                _arrayResult[i] = _queue[i + 1];
            }

            _queue = _arrayResult;

            return result;
        }

        public T[] CloneQueue()
        {
            int size = _queue.Length;
            T[] clone = new T[size];

            for (int i = 0; i < size; i++)
            {
                clone[i] = _queue[i];
            }
            return clone;
        }

        // Funcion que introduce un array de elementos genericos en la Queue.
        public void QueueMultipleElements(T[] elements)
        {
            int newElementsCount = elements.Length;
            int oldElementsCount = _queue.Length;

            T[] newQueue = new T[newElementsCount + oldElementsCount];

            for (int i = 0; i < oldElementsCount - 1; i++)
            {
                newQueue[i] = _queue[i];
            }

            for (int i = 0; i < newElementsCount - 1; i++)
            {
                newQueue[i + oldElementsCount] = elements[i];
            }

            _queue = newQueue;
        }
        public void Clear()
        {
            _queue = new T[0];
        }
        public override string ToString()
        {
            string result = "";
            int count = 0;

            foreach (T element in _queue)
            {
                result += $"El elemento {count} de la Queue es: {element}\n";
                count++;
            }

            return result;
        }
    }
}