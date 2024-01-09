using DAMLib;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            DAMLib.Queue<int> test1 = new DAMLib.Queue<int>();

            test1.Enqueue(1);
            test1.Enqueue(2);
            test1.Enqueue(3);
            test1.Enqueue(4);
            test1.Enqueue(5);
            int number = test1.Count;
            int number2 = test1.First;
            int number3 = test1.Last;
            string container = test1.ToStringEntireQueue();
            test1.Dequeue();
            test1.Dequeue();
            container = test1.ToStringEntireQueue();
            number = test1.Count;
            number2 = test1.First;
            number3 = test1.Last;
            test1.Clear();
            container = test1.ToStringEntireQueue();
        }
    }
}