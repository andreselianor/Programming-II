namespace DAMLib
{
    public class Stack<T>
    {
        private T[] _stackArray;


        public int Count => _stackArray.Length;
        public bool IsEmpty => _stackArray.Length == 0;



        public Stack()
        {
            _stackArray = new T[0];
        }



        public void Push(T Element)
        {
            if (Element == null)
                return;

            int count = _stackArray.Length;

            T[] stackResult = new T[count + 1];

            for (int i = 0; i < count; i++)
            {
                stackResult[i] = _stackArray[i];
            }

           stackResult[count] = Element;
            _stackArray = stackResult;
        }

        public T? Pop()
        {
            int count = _stackArray.Length;

            T result = _stackArray[count - 1];
            if (result == null)
                return default(T);

            T[] stackResult = new T[count - 1];
            for(int i = 0; i < count - 1; i++)
            {
                stackResult[i] = _stackArray[i];
            }

            _stackArray = stackResult;            

            return result;
        }

        public T Top()
        {
            T result = _stackArray[_stackArray.Length - 1];

            if (result == null)
                return default(T);

            return result;
        }
    }
}