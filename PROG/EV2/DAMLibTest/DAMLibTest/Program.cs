using DAMLib;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(10);
            stack.Push("Efigenio");
            stack.Push("Osvaldo");
            stack.Top();
            string result = stack.Pop();
        }
    }
}