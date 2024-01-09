using DAMLib;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            DAMLib.Stack<string> stack = new DAMLib.Stack<string>();
            stack.Push("Efigenio");
            stack.Push("Osvaldo");
            stack.Push("Erion");
            string result1 = stack.Top();
            string result = stack.Pop();
            string result2 = stack.Pop();
            string result3 = stack.Top();
            int result4 = stack.GetCount();
            bool result7 = stack.IsEmpty();
        }
    }
}