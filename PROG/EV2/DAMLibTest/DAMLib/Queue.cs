namespace DAMLib
{
    public class Queue<T>
    {
        // La documentacion de la clase 'Queue' se encuentra al final del fichero.

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
        public Queue(int count)
        {
            _queue = new T[count];
        }

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

        public T[] ToArray()
        {
            int size = _queue.Length;
            T[] clone = new T[size];

            for (int i = 0; i < size; i++)
            {
                clone[i] = _queue[i];
            }
            return clone;
        }
        public Queue<T> Clone()
        {
            int count = _queue.Length;
            Queue<T> clone = new Queue<T>(count);
            for (int i = 0; i < _queue.Length; i++)
            {
                clone._queue[i] = _queue[i];
            }
            return clone;
        }
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
            _queue = Array.Empty<T>();
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

        #region · DOCUMENTACION
        /*                                                                                   
        DOCUMENTACION PARA LA CLASE QUEUE · COLECCIONES DE DATOS
        Funciona según un algoritmo FIFO; Los elementos se 'extraen' segun el orden de entrada.

        (P) bool IsEmpty;
        (P) int Count;
        (P) T First;
        (P) T Last;

        |#| Queue() {}
        |#| Queue(int count) { Queue element = new Queue[count]}

        + Enqueue(T element) : void
        Funcion que introduce un elemento generico en el QUEUE.
        Queda establecido que el elemento se introduce en la ultima posicion del QUEUE [^1].
        
        + Dequeue() : T
        Funcion que extrae el primer elemento que contiene el QUEUE.
        Queda establecido que el primer elemento ocupa la primera posicion del QUEUE [0].

        + Clone() : Queue
        Funcion que clona un objeto 'QUEUE'

        + QueueMultipleElements(T[] elements) : void
        Funcion que introduce un array de elementos genericos en la Queue.

        + Clone() : Queue<T>
        Funcion que devuelve una copia del objeto Queue.

        + Clear() : void
        Funcion que elimina todos los objetos del array.
        
        + override ToString() : string
        Funcion que devuelve una cadena de texto con la descripcion del objeto 'QUEUE'.
        
        */
        #endregion
    }
}