namespace ExamenYvesElianor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ExList<int> list = new ExList<int>();

            int test0 = list.First;
            int test00 = list.Last;

            list.AddElement(10);

            int test1 = list.Count;

            list.AddElement(50);
            list.AddElement(100);

            int test2 = list.Count;
            int test3 = list.First;
            int test4 = list.Last;

            int[] test5 = list.Reversed;

            list.AddElement(20);
            list.AddElement(200);
            int[] test6 = list.Reversed;

            int test7 = list.GetElementAt(5);
            int element1 = 15;
            list.SetElementAt(0, element1);

            list.RemoveAtIndex(4);
        }
    }
}