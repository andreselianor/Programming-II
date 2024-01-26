using DAMLib;
using System.Text.Json;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            DAMLib.Stack<int> stack = new DAMLib.Stack<int>();
            stack.Push(5);
            stack.Push(25);
            int number = stack.Pop();


        }
    }
}