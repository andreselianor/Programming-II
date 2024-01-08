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
            stack.Top();
            string result = stack.Pop();
        }
    }
}