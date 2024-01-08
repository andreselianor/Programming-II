namespace DAMLib
{
    public class Stack<T>
    {
        //private static int _capacity = 0;
        private T[] _stackArray;
        private int _count = 0;

        public Stack(int number)
        {
            _stackArray = new T[number];
        }

        public void Push(T Element)
        {
            _stackArray[_count] = Element;
            _count++;
        }

        public T Pop()
        {
            _count--;
            return _stackArray[_count];
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